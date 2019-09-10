using _04_Previsioni.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Previsioni.Service
{
    public interface IOpenWeatherMapService
    {
        WeatherForecast GetWeatherForecast(string city);
    }
}
