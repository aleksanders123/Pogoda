
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aplikacja_pogodowa.Pages
{
    public class WheatherModel
    {
        public string Location { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }

    }

    public class IndexModel : PageModel
    {
        static HttpClient client = new HttpClient();

        [BindProperty]
        public WheatherModel Weather { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string location)
        {
            var result = client
            .GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={location}&appid=431f246a50ff4f5cdc59754224cc9d30&units=metric").Result;

            Weather = new WheatherModel
            {
                Location = location,
                Temperature = 20,
                Humidity = 55
            };
        }
    }
}
