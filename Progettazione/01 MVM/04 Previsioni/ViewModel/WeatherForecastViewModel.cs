using _04_Previsioni.Model;
using _04_Previsioni.Service;
using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Previsioni.ViewModel
{
    public class WeatherForecastViewModel : BindableBase
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private WeatherForecast model;
        private OpenWeatherMapService owms;

        public string City
        {
            get { return model.Location; }
            set
            {
                if (model.Location == value)
                {
                    return;
                }
                model.Location = value;
                OnPropertyChanged(() => City);
            }
        }

        public double DayTemperature
        {
            get { return model.TemperaturaGiorno; }
        }

        public double MinTemperature
        {
            get { return model.TemperaturaMinima; }
        }

        public double MaxTemperature
        {
            get { return model.TemperaturaMassima; }
        }

        public int Id
        {
            get { return model.IdTempo; }
        }

        public string Description
        {
            get { return model.Descrizione; }
        }

        public string Icona
        {
            get { return model.Icona; }
            set { model.Icona = value; }
        }


        public IDelegateCommand WeatherCommand { get; private set; }
        #endregion

        #region =================== costruttori ================
        public WeatherForecastViewModel()
        {
            model = new WeatherForecast();
            owms = new OpenWeatherMapService();
            City = "Lugano";
            WeatherCommand = new DelegateCommand(OnWeather);
        }
        #endregion

        #region =================== metodi aiuto ===============
        private void OnWeather(object obj)
        {
            model = owms.GetWeatherForecast(City);
            OnPropertyChanged(() => Id);
            OnPropertyChanged(() => Icona);
            OnPropertyChanged(() => Description);
            OnPropertyChanged(() => DayTemperature);
            OnPropertyChanged(() => MaxTemperature);
            OnPropertyChanged(() => MinTemperature);
        }
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}
