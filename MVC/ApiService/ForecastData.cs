using System;
using System.Collections.Generic;

namespace MVC.ApiService
{
    public class ForecastData : IForecastData
    {
        public List<String> getForeast()
        {
            var data = new List<String>();
            data.Add("Bright Sun Day");
            data.Add("Light Clouds");
            data.Add("Temperature 20*");
            data.Add("Wind 100");
            return data;
        }
    }
}
