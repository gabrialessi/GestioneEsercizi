using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Contadino.Model
{
    public class Contadino
    {

        #region =================== costanti ===================
        private const int FIENOINIZIALE = 1;
        #endregion

        #region =================== membri & proprietà =========
        private int fieno;

        public int Fieno
        {
            get { return fieno; }
            set { fieno = value; }
        }

        private int mucche;

        public int Mucche
        {
            get { return mucche; }
            set { mucche = value; }
        }
        #endregion

        #region =================== costruttori ================
        public Contadino(int fieno, int mucche)
        {
            Fieno = fieno;
            Mucche = mucche;
        }

        public Contadino() : this(FIENOINIZIALE, 0)
        {

        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        public int CalcolaFieno()
        {

            return Fieno * Mucche;

        }

        public override string ToString()
        {
            return string.Format("Sono necessarie {0} balle di fieno", CalcolaFieno());
        }
        #endregion

    }
}
