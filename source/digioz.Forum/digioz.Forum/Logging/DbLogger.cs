using System;
using System.Text;
using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace digioz.Forum.Logging
{
    internal sealed class DbLogger : ILogger
    {
        private readonly string _category;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly DbLoggerOptions _options;

        public DbLogger(string category, IServiceScopeFactory scopeFactory, DbLoggerOptions options)
        {
            _category = category;
            _scopeFactory = scopeFactory;
            _options = options;
        }

        public IDisposable BeginScope<TState>(TState state) => _options.IncludeScopes ? new NoopScope() : NoopScope.Instance;

        public bool IsEnabled(LogLevel logLevel) => logLevel >= _options.MinLevel && logLevel != LogLevel.None;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel) || formatter is null) return;

            try
            {
                var message = formatter(state, exception);
                if (string.IsNullOrWhiteSpace(message) && exception is null) return;

                using var scope = _scopeFactory.CreateScope();
                var forumLogService = scope.ServiceProvider.GetRequiredService<IForumLogService>();

                var log = new ForumLog
                {
                    // Map to ForumLog schema; defaults for fields we don't have context for
                    LogType = (byte)MapLogType(logLevel),
                    UserId = 0,
                    ForumId = 0,
                    TopicId = 0,
                    PostId = 0,
                    ReporteeId = 0,
                    LogIp = "",
                    LogTime = DateTime.UtcNow,
                    LogOperation = BuildOperation(_category, eventId, logLevel, exception),
                    LogData = message
                };

                forumLogService.Add(log);
            }
            catch
            {
                // Avoid recursive logging if DB is unavailable
            }
        }

        private static int MapLogType(LogLevel level) => level switch
        {
            LogLevel.Trace => 0,
            LogLevel.Debug => 0,
            LogLevel.Information => 1,
            LogLevel.Warning => 2,
            LogLevel.Error => 3,
            LogLevel.Critical => 4,
            _ => 1
        };

        private static string BuildOperation(string category, EventId eventId, LogLevel level, Exception? ex)
        {
            var sb = new StringBuilder();
            sb.Append('[').Append(level).Append("] ").Append(category);
            if (eventId.Id != 0)
            {
                sb.Append(" (EventId: ").Append(eventId.Id).Append(')');
            }
            if (ex != null)
            {
                sb.Append(" | Exception: ").Append(ex.GetType().Name).Append(": ").Append(ex.Message);
            }
            return sb.ToString();
        }

        private sealed class NoopScope : IDisposable
        {
            public static readonly NoopScope Instance = new NoopScope();
            public void Dispose() { }
        }
    }
}
