using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demineur
{
    public partial class FormDemineur : Form
    {
        const int MINE = -1;
        private int nombreMines;
        private Champ champDeJeu;

        /// <summary>
        /// Constructeur du form
        /// </summary>
        public FormDemineur()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Appeller au chargement du form
        /// </summary>
        private void FormDemineur_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanelJeu.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanelJeu.ColumnCount; j++)
                {
                    Button boite = new Button();
                    boite.Width = 42;
                    boite.Height = 42;
                    boite.Margin = new Padding(0, 0, 0, 0);
                    tableLayoutPanelJeu.Controls.Add(boite, i, j);
                    boite.Click += new System.EventHandler(Case_Click);
                }
            }
            nombreMines = (int)nudNombreMines.Value;
            champDeJeu = new Champ(tableLayoutPanelJeu.RowCount, tableLayoutPanelJeu.ColumnCount, nombreMines);


            champDeJeu.InitialiserJeu();



            timer.Enabled = true;

        }


        /// <summary>
        /// Appeler quand le joueur clic sur une case (Demine la case visé)
        /// </summary>
        private void Case_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            int x = tableLayoutPanelJeu.GetColumn(c);
            int y = tableLayoutPanelJeu.GetRow(c);

            champDeJeu.Deminer(x, y);
            Actualiser();

        }



        /// <summary>
        /// Appeler à toute les secondes pour avancer le nombre de secondes
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            int seconde = Convert.ToInt32(lblSeconde.Text);
            seconde++;
            lblSeconde.Text = seconde.ToString();
        }

        /// <summary>
        /// Réinitialise le jeu et remet tout au point de départ
        /// </summary>
        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            champDeJeu.NombreMines = (int)nudNombreMines.Value;
            champDeJeu.InitialiserJeu();
            cheat();
            Actualiser();
            Refresh();
            timer.Enabled = true;
            lblSeconde.Text = "0";
        }


        /// <summary>
        /// Actualise l'affichage du jeu
        /// </summary>
        private void Actualiser()
        {
            for (int i = 0; i < tableLayoutPanelJeu.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanelJeu.RowCount; j++)
                {
                    Button boite = (Button)tableLayoutPanelJeu.GetControlFromPosition(i, j);
                    if (!checkDebug.Checked)
                    {
                        boite.Image = null;
                    }
                    if (champDeJeu.Donnees[i, j].Deminee)
                    {                        
                        if (champDeJeu.Donnees[i, j].NombreAdjacentes != 0 )
                        {
                            if (champDeJeu.Donnees[i, j].NombreAdjacentes == -1)
                            {
                                boite.Image = imageBombe.Images[0];
                            }
                            else
                            {
                                boite.Text = champDeJeu.Donnees[i, j].NombreAdjacentes.ToString();
                            }
                        }
                        boite.FlatStyle = FlatStyle.Flat;

                    }
                }

            }

            if (champDeJeu.EtatJeu == Champ.EtatPartie.Perdu)
            {
                timer.Enabled = false;
                MessageBox.Show("LOSER!\nVous allez recommencer ;)", "Fin de la partie.");
                btnRecommencer.PerformClick();
                
            }
            else if (champDeJeu.EtatJeu == Champ.EtatPartie.Gagne)
            {
                timer.Enabled = false;
                MessageBox.Show("WINNER!!!\nVous avez réussi en " + lblSeconde.Text + " secondes et vous aviez " + champDeJeu.NombreMines.ToString() + " mines.\n le jeu va recommencer ;)", "Fin de la partie");
                if (checkDebug.Checked)
                {
                    checkDebug.Checked = false;
                    btnRecommencer.PerformClick();
                    checkDebug.Checked = true;
                }
                else
                {
                    btnRecommencer.PerformClick();
                }
              
            }
        }

        /// <summary>
        /// Active la vérification des données (cheat) mais peu créer des bugs
        /// </summary>
        private void checkDebug_CheckedChanged(object sender, EventArgs e)
        {
            cheat();
            Actualiser();

            if (checkDebug.Checked)
            {
                btnRecommencer.Enabled = false;
            }
            else
            {
                btnRecommencer.Enabled = true;
            }
        }

        /// <summary>
        /// Affiche toutes les bombes et les nombres d'adjacentes
        /// </summary>
        private void cheat()
        {

            int imageSymbole = 0;
            for (int i = 0; i < tableLayoutPanelJeu.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanelJeu.ColumnCount; j++)
                {
                    Button boite = (Button)tableLayoutPanelJeu.GetControlFromPosition(i, j);
                    imageSymbole = champDeJeu.Donnees[i, j].NombreAdjacentes;
                    if (checkDebug.Checked)
                    {
                        if (imageSymbole == -1)
                        {
                            boite.Image = imageBombe.Images[0];
                        }
                        else
                        {
                            boite.Text = imageSymbole.ToString();
                        }
                    }
                    else
                    {
                        boite.Text = "";
                    }
                    boite.FlatStyle = FlatStyle.Standard;
                }
            }
            Refresh();

        }
    }
}
