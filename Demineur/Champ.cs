using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demineur
{
    class Champ
    {
        public enum EtatPartie
        {
            EnCours,
            Perdu,
            Gagne
        }

        private Zone[,] donnees;
        private int nombreMines;
        private EtatPartie etatJeu;
        private int nombreDeDemine;
        private int nombreDeZone;

        /// <summary>
        /// Constructeur de la classe Champ
        /// </summary>
        /// <param name="nombreLignes">Nombre de ligne de jeu</param>
        /// <param name="nombreColonnes">Nombre de colonnes de jeu</param>
        /// <param name="nombreMines">Nombre de mine généré dans le jeu</param>
        public Champ(int nombreLignes, int nombreColonnes, int nombreMines)
        {
            donnees = new Zone[nombreLignes, nombreColonnes];
            for (int i = 0; i < nombreLignes; i++)
            {
                for (int j = 0; j < nombreColonnes; j++)
                {
                    donnees[i, j] = new Zone();
                }

            }

            this.nombreMines = nombreMines;
            this.etatJeu = EtatPartie.EnCours;
            this.nombreDeDemine = 0;
            this.nombreDeZone = nombreColonnes * nombreLignes;

        }

        /// <summary>
        /// Initialise le jeu/ les données
        /// </summary>
        public void InitialiserJeu()
        {
            Random aleatoire = new Random();
            int x = 0;
            int y = 0;
            bool different = false;

            this.etatJeu = EtatPartie.EnCours;
            this.nombreDeDemine = 0;

            for (int i = 0; i < this.Donnees.GetLength(0); i++)
            {
                for (int j = 0; j < this.Donnees.GetLength(1); j++)
                {
                    donnees[i, j].NombreAdjacentes = 0;
                    donnees[i, j].Deminee = false;
                }
            }

            for (int i = 0; i < this.nombreMines; i++)
            {
                while (!different)
                {
                    x = aleatoire.Next(0, this.Donnees.GetLength(0));
                    y = aleatoire.Next(0, this.Donnees.GetLength(1));
                    if (donnees[x, y].NombreAdjacentes != -1)
                    {
                        different = true;
                        donnees[x, y].NombreAdjacentes = -1;
                    }

                }
                different = false;
            }
            for (int i = 0; i < donnees.GetLength(0); i++)
            {
                for (int j = 0; j < donnees.GetLength(1); j++)
                {
                    donnees[i, j].NombreAdjacentes = GetNombreVoisins(i, j);
                }

            }


        }



        /// <summary>
        /// Retourne le nombre de mine(s) autour de la case
        /// </summary>
        /// <param name="coorX">Position en X de la case</param>
        /// <param name="coorY">Position en Y de la case</param>
        /// <returns>Retourne le nombre mine(s) autour de la case</returns>
        private int GetNombreVoisins(int coorX, int coorY)
        {
            int nombreVoisin = 0;

            if (donnees[coorX, coorY].NombreAdjacentes != -1)
            {
                for (int i = coorX - 1; i <= coorX + 1; i++)
                {
                    for (int j = coorY - 1; j <= coorY + 1; j++)
                    {
                        if (i >= 0 && i < donnees.GetLength(0) && j >= 0 && j < donnees.GetLength(1))
                        {
                            if (donnees[i, j].NombreAdjacentes == -1)
                            {
                                nombreVoisin++;
                            }
                        }
                    }
                }
            }
            else
            {
                nombreVoisin = -1;
            }

            return nombreVoisin;
        }


        /// <summary>
        /// Demine la case passé en X et Y, la démine et regarde si dois déminer les autres autours
        /// </summary>
        /// <param name="x">Position en X de la case à déminé</param>
        /// <param name="y">Position en Y de la case à déminé</param>
        public void Deminer(int x, int y)
        {

            if (!donnees[x, y].Deminee)
            {
                donnees[x, y].Deminee = true;

                if (donnees[x, y].NombreAdjacentes != -1)
                {
                    this.nombreDeDemine++;

                    if (donnees[x, y].NombreAdjacentes == 0)
                    {
                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            for (int j = y - 1; j <= y + 1; j++)
                            {
                                if (i >= 0 && i < donnees.GetLength(0) && j >= 0 && j < donnees.GetLength(1))
                                {
                                    if (!donnees[i, j].Deminee)
                                    {
                                        if (donnees[i, j].NombreAdjacentes == 0)
                                        {
                                            this.Deminer(i, j);
                                        }
                                        else
                                        {
                                            donnees[i, j].Deminee = true;
                                            this.nombreDeDemine++;
                                        }
                                    }
                                }

                            }
                        }

                    }
                }
                else if (donnees[x, y].NombreAdjacentes == -1)
                {
                    etatJeu = EtatPartie.Perdu;
                }

                if (nombreDeDemine == (this.nombreDeZone - this.nombreMines))
                {
                    etatJeu = EtatPartie.Gagne;
                }
            }



        }

        /// <summary>
        /// Tableau 2D d'objet de type zone
        /// </summary>
        internal Zone[,] Donnees
        {
            get { return donnees; }
            set { donnees = value; }
        }
        /// <summary>
        /// Nombre de mines dans le jeu
        /// </summary>
        public int NombreMines
        {
            get { return nombreMines; }
            set { nombreMines = value; }
        }

        /// <summary>
        /// État de la partie
        /// </summary>
        public EtatPartie EtatJeu
        {
            get { return etatJeu; }
        }

        /// <summary>
        /// Le nombre de zones qui ont été déminées
        /// </summary>
        public int NombreDeDemine
        {
            get { return nombreDeDemine; }
        }
    }
}
