using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Tariffa.Model
{
    public class Tariffa
    {
        private const double MINORENNE = 0.5;
        private const double NORMALE = 0.8;
        #region =================== membri & proprietà =========
        private int km;

        public int Km
        {
            get { return km; }
            set
            {
                km = value;
                CalcolaTotale();
            }
        }

        private int eta;

        public int Eta
        {
            get { return eta; }
            set
            {
                eta = value;
                CalcolaTotale();
            }
        }
        #endregion

        #region =================== costruttori ================
        public Tariffa(int km, int eta)
        {
            Km = km;
            Eta = eta;
        }

        public Tariffa() : this(1, 1)
        {

        }
        #endregion

        #region =================== metodi aiuto ============
        public double CalcolaTotale()
        {
            double totale;
            if (Eta < 18)
            {
                totale = MINORENNE * Km;
            }
            else if (Eta >= 65)
            {
                totale = NORMALE * Km * 80 / 100;
            }
            else
            {
                totale = NORMALE * Km;
            }
            return totale;
        }
        #endregion


    }
}
