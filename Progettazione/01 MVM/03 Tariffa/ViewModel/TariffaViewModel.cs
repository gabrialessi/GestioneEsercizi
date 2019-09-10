using _03_Tariffa.Model;
using MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Tariffa.ViewModel
{
    public class TariffaViewModel : BindableBase
    {

        #region =================== membri & proprietà =========
        private Tariffa model;

        public int Km
        {
            get { return model.Km; }
            set
            {
                if (model.Km != value)
                {
                    model.Km = value;
                    OnPropertyChanged(() => Km);
                    OnPropertyChanged(() => Totale);
                }
            }
        }

        public int Eta
        {
            get { return model.Eta; }
            set
            {
                if (model.Eta != value)
                {
                    model.Eta = value;
                    OnPropertyChanged(() => Eta);
                    OnPropertyChanged(() => Totale);
                }
            }
        }

        public double Totale
        {
            get
            {
                return model.CalcolaTotale();
            }
        }


        #endregion

        #region =================== costruttori ================
        public TariffaViewModel()
        {
            model = new Tariffa();
        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

    }
}
