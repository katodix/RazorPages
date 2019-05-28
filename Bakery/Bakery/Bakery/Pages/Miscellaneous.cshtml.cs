using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bakery.Pages
{
    public class MiscellaneousModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Miscellaneous.";
        }
    }
}