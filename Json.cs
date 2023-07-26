using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequest
{
    internal class Json2Csharp
    {
        class Coordinator
        {
            double lon, lat;
            public Coordinator(double lon, double lat)
            {
                this.lon = lon; 
                this.lat = lat;
            }
        }
        class Weather //we can use list instead of array.
        {
            int[] id;
            string[] wMain, description, icon;
            public Weather(int[] id, string[] wMain, string[] description, string[] icon)
            {
                this.id = id;
                this.wMain = wMain;
                this.description = description;
                this.icon = icon;
            }
        }

        String baseUrl;
        class Main
        {
            double temp, feels_like, temp_min, temp_max, pressure, humidity;
            public Main(double temp, double feels_like, double temp_min, double temp_max, double pressure, double humidity)
            {
                this.temp = temp;
                this.feels_like = feels_like;
                this.temp_min = temp_min;
                this.temp_max = temp_max;
                this.pressure = pressure;
                this.humidity = humidity;
            }
        }
        Double visibility;
        class Wind
        {
            Double speed, deg;
            public Wind(double speed, double deg) 
            { 
                this.speed = speed;
                this.deg = deg;
            }
        }
        class Clouds
        {
            double all;
            public Clouds(double all)
            {
                this.all = all;
            }
        }
        float dt;
        class Sys
        {
            double type;
            double id;
            string country;
            double sunrise;
            double sunset;
            public Sys(double type, double id, string  country, double sunrise, double sunset)
            {
                this.type = type;
                this.id = id;
                this.country = country;
                this.sunrise = sunrise;
                this.sunset = sunset;
            }
        }
        float timezone;
        double id;
        string name;
        double cod;
        public Json2Csharp(string baseUrl, double visibility, float dt, float timezone, double id, string name, double cod)
        {
            this.baseUrl = baseUrl;
            this.visibility = visibility;
            this.dt = dt;
            this.timezone = timezone;
            this.id = id;
            this.name = name;
            this.cod = cod;
        }
    }
}
