namespace digioz.Forum.Helpers
{
    public class IpAddressHelper
    {
        public string GetIpAddress(HttpContext httpContext)
        {
            string ipAddress = httpContext.Connection.RemoteIpAddress.ToString();
            if (httpContext.Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                ipAddress = httpContext.Request.Headers["X-Forwarded-For"];
            }
            return ipAddress;
        }

        public string GetBrowser(HttpContext httpContext)
        {
            string browser = httpContext.Request.Headers["User-Agent"];
            return browser;
        }
    }
}
