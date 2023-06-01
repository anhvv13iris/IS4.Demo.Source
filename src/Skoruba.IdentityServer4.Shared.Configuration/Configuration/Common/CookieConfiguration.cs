namespace Skoruba.IdentityServer4.Shared.Configuration.Configuration.Common
{
    public class CookieConfiguration
    {
        public string NameIdentifer { get; set; }
        public int ExpireTimeSpan { get; set; }
        public bool SlidingExpiration { get; set; }
    }
}