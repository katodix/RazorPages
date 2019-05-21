using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.RazorPages.Pages.Somatotype
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            string sf_si_str = Request.Form["skinfold_suprailliac"];
            // do something with emailAddress
            double sf_si = double.Parse(sf_si_str);
        }

    }
}
