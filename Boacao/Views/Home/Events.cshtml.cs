using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Boacao.Views.Home
{
    public class Events : PageModel
    {
        private readonly ILogger<Events> _logger;

        public Events(ILogger<Events> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}