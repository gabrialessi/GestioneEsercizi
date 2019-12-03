using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GestioneEsercizi.ViewModels
{
    public class ProvaViewModel : BindableBase
    {
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Comando che genera la prova.
        /// </summary>
        public IDelegateCommand SalvaCommand { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati delle classi.
        /// </summary>
        public ObservableCollection<Classe> Classi { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati degli esercizi.
        /// </summary>
        public ObservableCollection<Esercizio> Esercizi { get; set; }
        /// <summary>
        /// Titolo della prova.
        /// </summary>
        public string Titolo { get; set; }
        /// <summary>
        /// Data della prova.
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Classe della prova.
        /// </summary>
        public Classe Classe { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public ProvaViewModel()
        {
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            SalvaCommand = new DelegateCommand(OnSalva, CanSalva);
            ClasseDbRepository repoClasse = new ClasseDbRepository(new AppDbContext());
            EsercizioDbRepository repoEsercizio = new EsercizioDbRepository(new AppDbContext());
            Classi = new ObservableCollection<Classe>(repoClasse.Get());
            Esercizi = new ObservableCollection<Esercizio>(repoEsercizio.Get());
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private bool CanBenvenuto(object arg) => true;
        private void OnSalva(object obj)
        {
            ProvaDbRepository repoProva = new ProvaDbRepository(new AppDbContext());
            EsercizioProvaDbRepository repo = new EsercizioProvaDbRepository(new AppDbContext());
            // Aggiungo la prova
            Prova prova = new Prova(Titolo, Data, Classe);
            repoProva.Insert(prova);
            // Aggiungo gli esercizi della prova
            foreach (Esercizio esercizio in new List<Esercizio>(Esercizi))
            {
                repo.Insert(new EsercizioProva(esercizio, prova));
            }
            OnBenvenuto(obj);
        }
        private bool CanSalva(object arg) => true;
    }
}