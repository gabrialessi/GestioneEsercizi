using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _04_Previsioni.Model;

namespace _04_Previsioni.Service
{
    public class OpenWeatherMapService : IOpenWeatherMapService
    {
        #region =================== costanti ===================
        private const string BASEURL = "http://api.openweathermap.org/data/2.5/";
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private HttpClient client;
        private IKeyService ks;
        #endregion

        #region =================== costruttori ================
        public OpenWeatherMapService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(BASEURL);
            ks = new KeyConstantService();
        }
        #endregion

        #region =================== metodi aiuto ===============
        private string ConstructUrl(string city)
        {
            string query = "weather?q=" + city + "&appid=" + ks.GetKey();
            return BASEURL + query + "&mode=xml&units=metric";
        }
        #endregion

        #region =================== metodi generali ============
        public WeatherForecast GetWeatherForecast(string city)
        {
            if (!string.IsNullOrWhiteSpace(city))
            {
                string path = ConstructUrl(city);
                try
                {
                    var result = client.GetStringAsync(path).Result;

                    var x = XElement.Load(new StringReader(result));

                    WeatherForecast ws = new WeatherForecast();

                    ws.Location = x.Element("city").Attribute("name").Value;
                    ws.TemperaturaGiorno = double.Parse(x.Element("temperature").Attribute("value").Value);
                    ws.TemperaturaMinima = double.Parse(x.Element("temperature").Attribute("min").Value);
                    ws.TemperaturaMassima = double.Parse(x.Element("temperature").Attribute("max").Value);
                    ws.DirezioneVento = x.Element("wind").Element("direction").Attribute("name").Value;
                    ws.IdTempo = int.Parse(x.Element("weather").Attribute("number").Value);
                    ws.Icona = x.Element("weather").Attribute("icon").Value;
                    ws.Descrizione = x.Element("weather").Attribute("value").Value;
                    ws.Umidita = int.Parse(x.Element("humidity").Attribute("value").Value);
                    ws.Pressione = int.Parse(x.Element("pressure").Attribute("value").Value);
                    ws.Longitudine = double.Parse(x.Element("city").Element("coord").Attribute("lon").Value);
                    ws.Latitudine = double.Parse(x.Element("city").Element("coord").Attribute("lat").Value);

                    return ws;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                throw new ArgumentNullException("City cannot be null");
            }
        }
        #endregion
    }
}
