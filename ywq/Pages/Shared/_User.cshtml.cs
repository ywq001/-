using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ywq.Pages.Shared
{
    public class UserPageModel : PageModel
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public int Level { set; get; }
        public void OnGet()
        {

        }
    }
}