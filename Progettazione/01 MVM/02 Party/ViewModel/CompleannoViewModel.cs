using _01_Party.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Party.ViewModel
{
    public class CompleannoViewModel : INotifyPropertyChanged
    {

        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        public event PropertyChangedEventHandler PropertyChanged;
        private Compleanno model;

        public bool DecorazioneProfessionale
        {
            get { return model.DecorazioneProfessionale; }
            set
            {
                model.DecorazioneProfessionale = value;
                OnPropertyChanged("DecorazioneProfessionale");
                OnPropertyChanged("Totale");
            }
        }

        public int Persone
        {
            get { return model.Persone; }
            set
            {
                if (model.Persone != value)
                {
                    model.Persone = value;
                    OnPropertyChanged("Persone");
                    OnPropertyChanged("Totale");
                }
            }
        }

        public string Testo
        {
            get { return model.Testo; }
            set
            {
                if (model.Testo != value)
                {
                    model.Testo = value;
                    OnPropertyChanged("Testo");
                }
            }
        }

        public double Totale
        {
            get { return model.CalcolaTotale(); }
        }


        #endregion

        #region =================== costruttori ================
        public CompleannoViewModel()
        {
            model = new Compleanno();
        }
        #endregion

        #region =================== metodi aiuto ===============
        protected void OnPropertyChanged(string propertyName)
        {

            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {

                handler(this, new PropertyChangedEventArgs(propertyName));

            }

        }
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}
