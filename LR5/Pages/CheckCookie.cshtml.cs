using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;

namespace LR5.Pages
{
    public class CheckCookieModel : PageModel
    {
        private readonly IDistributedCache _cache;

        public CheckCookieModel(IDistributedCache cache)
        {
            _cache = cache;
        }

        public string Data { get; set; }

        public void OnGet()
        {
            // Check if data exists in the cookie
            Data = _cache.GetString("UserData");
        }
    }
}
