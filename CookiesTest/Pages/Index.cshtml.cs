using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookiesTest.Pages
{
    public class IndexModel : PageModel
    {

        public string Message { get; set; }


        public void OnGet()
        {
           

            if (Request.Cookies["NiallCookie"] != null)
            {
                Message = Request.Cookies["NiallCookie"];
            }
            else
            {
                Message = "Hello newcomer!";
            }

            CookieOptions options = new CookieOptions();

            options.Expires = DateTime.Now.AddHours(1);

            Response.Cookies.Append("NiallCookie", "Welcome back", options);
        }
    }
}
