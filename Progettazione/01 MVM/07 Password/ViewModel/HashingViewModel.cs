using _07_Password.Model;
using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Password.ViewModel
{
    public class HashingViewModel : BindableBase
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        Hashing model;
        private string computedHash;

        public string ComputedHash
        {
            get { return computedHash; }
            set { computedHash = value; }
        }

        public string PlainText
        {
            get { return model.PlainText; }
            set { model.PlainText = value; }
        }

        public string Result { get; set; }

        public string Salt
        {
            get { return model.Salt; }
            set { model.Salt = value; }
        }

        #endregion

        #region =================== costruttori ================
        public HashingViewModel()
        {
            model = new Hashing();
        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}
