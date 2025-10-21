using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace digioz.Forum.Filters
{
    // Factory to create PageLoggerFilter with DI support in RazorPages options
    public class PageLoggerFilterFactory : IFilterFactory
    {
        public bool IsReusable => false;
        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            return serviceProvider.GetRequiredService<PageLoggerFilter>();
        }
    }
}
