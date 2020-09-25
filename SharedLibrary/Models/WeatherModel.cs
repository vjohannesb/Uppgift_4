﻿
namespace SharedLibrary.Models
{
    public class WeatherModel
    {
        // Struktur enligt OpenWeatherMaps JSON-respons
        public Main main { get; set; }

        public class Main
        {
            public double temp { get; set; }
            public double humidity { get; set; }
        }

    }
}
