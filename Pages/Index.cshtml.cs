﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace aplikacja_pogodowa.Pages
{
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class WeatherModel
    {
        public string location { get; set; }
        public string locationInput { get; set; }
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }

        public WeatherModel()
        {
            main = new Main();
        }
    }



    public class IndexModel : PageModel
    {
        static HttpClient client = new HttpClient();
        const string AppId = "431f246a50ff4f5cdc59754224cc9d30";

        [BindProperty]
        public WeatherModel WeatherModel { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string locationInput)
        {
            var result = client
            .GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={locationInput}&appid={AppId}&units=metric&lang=pl").Result;
            string responseStr = result.Content.ReadAsStringAsync().Result;
            WeatherModel = JsonConvert.DeserializeObject<WeatherModel>(responseStr);
            WeatherModel.locationInput = locationInput;
        }
    }
}
