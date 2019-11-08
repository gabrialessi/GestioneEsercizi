using GestioneEsercizi.DA.Models;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Interfaccia che implementa i metodi relativi al database
    /// sul modello di dati dell'esercizio.
    /// </summary>
    public interface IEsercizioRepository : IDataRepository<Esercizio> { }
}