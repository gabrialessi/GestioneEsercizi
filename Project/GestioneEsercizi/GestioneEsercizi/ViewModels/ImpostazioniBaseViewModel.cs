using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class ImpostazioniBaseViewModel : BindableBase
    {
        /// <summary>
        /// Insieme dinamico dei dati delle classi.
        /// </summary>
        public ObservableCollection<Classe> Classi { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati dei moduli.
        /// </summary>
        public ObservableCollection<Modulo> Moduli { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati delle tematiche.
        /// </summary>
        public ObservableCollection<Tematica> Tematiche { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public ImpostazioniBaseViewModel()
        {
            AppDbContext ctx = new AppDbContext();
            ClasseDbRepository repoClasse = new ClasseDbRepository(ctx);
            ModuloDbRepository repoModulo = new ModuloDbRepository(ctx);
            TematicaDbRepository repoTematica = new TematicaDbRepository(ctx);
            Classi = new ObservableCollection<Classe>(repoClasse.Get());
            Moduli = new ObservableCollection<Modulo>(repoModulo.Get());
            Tematiche = new ObservableCollection<Tematica>(repoTematica.Get());
        }
    }
}
