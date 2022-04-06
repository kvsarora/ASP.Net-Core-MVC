using System.Collections.Generic;

namespace MVC.ApiService
{
    public interface IForecastData
    {
        List<string> getForeast();
    }
}