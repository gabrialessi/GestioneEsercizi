using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Interfaccia che implementa i metodi relativi al database
    /// sul modello di dati dell'anno.
    /// </summary>
    public interface IAnnoRepository : IDataRepository<Anno>
    {
    }
}
