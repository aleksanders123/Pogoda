using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aplikacja_pogodowa.Pages
{
    public class WheatherModel
    {
        public string City { get; set; }
        public string Country { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }

    }

    public class IndexModel : PageModel
    {
        [BindProperty]
        public WheatherModel Weather { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string city, string country)
        {
            Weather = new WheatherModel
            {
                City= city, 
                Country = country,
                Temperature= 20
            };
        }
    }
}
