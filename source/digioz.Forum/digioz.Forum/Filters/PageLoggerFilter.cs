using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace digioz.Forum.Filters
{
    // Logs page requests for all Razor Pages using the configured ILogger (DbLogger provider)
    public class PageLoggerFilter : IAsyncPageFilter
    {
        private readonly ILogger<PageLoggerFilter> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PageLoggerFilter(ILogger<PageLoggerFilter> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
            => Task.CompletedTask;

        public Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            var http = _httpContextAccessor.HttpContext;
            var path = http?.Request?.Path.Value ?? "";
            var sessionId = http?.Session?.GetString("UniqueSessionId") ?? "";
            var pageName = context?.ActionDescriptor?.DisplayName ?? context?.HandlerMethod?.MethodInfo?.DeclaringType?.Name ?? "UnknownPage";

            _logger.LogWarning("Page loaded. Page: {Page}, Path: {Path}, SessionId: {SessionId}", pageName, path, sessionId);
            return next();
        }
    }
}
