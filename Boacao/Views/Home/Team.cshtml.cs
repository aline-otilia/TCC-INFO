using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Boacao.Views.Home
{
    public class Team : PageModel
    {
        private readonly ILogger<Team> _logger;

        public Team(ILogger<Team> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}