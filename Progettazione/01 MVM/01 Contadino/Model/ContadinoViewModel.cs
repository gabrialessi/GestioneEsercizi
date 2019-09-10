using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Contadino.Model
{
    public class ContadinoViewModel : INotifyPropertyChanged
    {

        #region =================== membri & proprietà =========
        private Contadino model;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Fieno
        {
            get { return model.Fieno; }
            set
            {
                if (model.Fieno != value)
                {
                    model.Fieno = value;
                    OnPropertyChanged("Fieno");
                    OnPropertyChanged("Descrizione");
                    OnPropertyChanged("TotaleFieno");
                }
            }
        }

        public int Mucche
        {
            get { return model.Mucche; }
            set
            {
                if (model.Mucche != value)
                {
                    model.Mucche = value;
                    OnPropertyChanged("Mucche");
                    OnPropertyChanged("Descrizione");
                    OnPropertyChanged("TotaleFieno");
                }
            }
        }

        public int TotaleFieno
        {
            get { return model.CalcolaFieno(); }
        }

        public string Descrizione
        {
            get { return model.ToString(); }
        }


        #endregion

        #region =================== costruttori ================
        public ContadinoViewModel()
        {
            model = new Contadino();
        }
        #endregion

        #region =================== metodi generali ============
        protected void OnPropertyChanged(string propertyName)
        {

            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {

                handler(this, new PropertyChangedEventArgs(propertyName));

            }

        }
        #endregion

    }
}
