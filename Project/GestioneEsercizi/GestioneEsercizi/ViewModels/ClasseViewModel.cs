﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using GestioneEsercizi.Models;

namespace GestioneEsercizi.ViewModels
{
    public class ClasseViewModel : ViewModelBase
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private Classe model;
        #endregion

        #region =================== costruttori ================
        public ClasseViewModel()
        {
            model = new Classe();
        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}