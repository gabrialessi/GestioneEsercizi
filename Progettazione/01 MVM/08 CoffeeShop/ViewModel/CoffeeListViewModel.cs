using _08_CoffeeShop.DA.Model;
using _08_CoffeeShop.DA.Service;
using MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CoffeeShop.ViewModel
{
    public class CoffeeListViewModel : BindableBase
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        public ObservableCollection<Coffee> Coffees { get; set; }
        #endregion

        #region =================== costruttori ================
        public CoffeeListViewModel()
        {
            CoffeeDataRepository cdr = new CoffeeDataRepository();
            Coffees = new ObservableCollection<Coffee>(cdr.Get());
        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}
