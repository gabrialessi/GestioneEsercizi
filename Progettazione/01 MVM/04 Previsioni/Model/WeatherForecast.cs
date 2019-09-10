using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Previsioni.Model
{
    public class WeatherForecast
    {
        #region =================== membri & proprietà =========
        public string Location { get; set; }
        public double TemperaturaGiorno { get; set; }
        private double longitudine;

        public double Longitudine
        {
            get { return longitudine; }
            set { longitudine = value; }
        }

        private double latitudine;

        public double Latitudine
        {
            get { return latitudine; }
            set { latitudine = value; }
        }

        private string paese;

        public string Paese
        {
            get { return paese; }
            set { paese = value; }
        }

        private int alba;

        public int Alba
        {
            get { return alba; }
            set { alba = value; }
        }

        private int tramonto;

        public int Tramonto
        {
            get { return tramonto; }
            set { tramonto = value; }
        }

        private int idTempo;

        public int IdTempo
        {
            get { return idTempo; }
            set { idTempo = value; }
        }

        private string principale;

        public string Principale
        {
            get { return principale; }
            set { principale = value; }
        }

        private string descrizione;

        public string Descrizione
        {
            get { return descrizione; }
            set { descrizione = value; }
        }

        private string icona;

        public string Icona
        {
            get { return icona; }
            set { icona = value; }
        }

        private int umidita;

        public int Umidita
        {
            get { return umidita; }
            set { umidita = value; }
        }

        private int pressione;

        public int Pressione
        {
            get { return pressione; }
            set { pressione = value; }
        }

        private double temperaturaMassima;

        public double TemperaturaMassima
        {
            get { return temperaturaMassima; }
            set { temperaturaMassima = value; }
        }

        private double temperaturaMinima;

        public double TemperaturaMinima
        {
            get { return temperaturaMinima; }
            set { temperaturaMinima = value; }
        }

        private double velocitaVento;

        public double VelocitaVento
        {
            get { return velocitaVento; }
            set { velocitaVento = value; }
        }

        public string DirezioneVento { get; set; }

        private string pioggia;

        public string Pioggia
        {
            get { return pioggia; }
            set { pioggia = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int codice;

        public int Codice
        {
            get { return codice; }
            set { codice = value; }
        }
        #endregion

        #region =================== costruttori ================
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        #endregion

    }
}
