using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Boacao.Views.Home
{
    public class Donate : PageModel
    {
        private readonly ILogger<Donate> _logger;

        public Donate(ILogger<Donate> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}