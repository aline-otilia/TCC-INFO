using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Boacao.Views.Home
{
    public class Gallery : PageModel
    {
        private readonly ILogger<Gallery> _logger;

        public Gallery(ILogger<Gallery> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}