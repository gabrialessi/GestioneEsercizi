using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Numeri.ViewModel
{
    public class NumeroViewModel : BindableBase
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private string model;

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                    model == value)
                {
                    return;
                }
                model = value;
                OnPropertyChanged(() => Model);
            }
        }
        #endregion

        #region =================== costruttori ================
        public NumeroViewModel()
        {
            Model = "";
        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        #endregion

    }
}
