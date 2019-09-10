using _09_RSI.DA;
using _09_RSI.DA.Service;
using MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RSI.ViewModel
{
    public class ScheduleListViewModel : BindableBase
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        public ObservableCollection<Schedule> Schedules { get; set; }
        #endregion

        #region =================== costruttori ================
        public ScheduleListViewModel()
        {
            ScheduleDataRepository sdr = new ScheduleDataRepository();
            IEnumerable<Schedule> schedules = sdr.Get();
            Schedules = new ObservableCollection<Schedule>();
        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}
