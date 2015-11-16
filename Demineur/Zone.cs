using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demineur
{
    class Zone
    {
        private bool deminee;
        private int nombreAdjacentes;


        /// <summary>
        /// constructeur de la classe Zone
        /// </summary>
        public Zone()
        {
            this.nombreAdjacentes = 0;
            this.deminee = false;
        }

        /// <summary>
        /// Si la zone a été déminée
        /// </summary>
        public bool Deminee
        {
            get { return deminee; }
            set { deminee = value; }
        }

        /// <summary>
        /// Nombre de mine(s) autour de la zone
        /// </summary>
        public int NombreAdjacentes
        {
            get { return nombreAdjacentes; }
            set { nombreAdjacentes = value; }
        }




    }
}
