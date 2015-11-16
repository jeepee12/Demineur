namespace Demineur
{
    partial class FormDemineur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemineur));
            this.tableLayoutPanelJeu = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTxtSecondes = new System.Windows.Forms.Label();
            this.lblSeconde = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNombreMines = new System.Windows.Forms.NumericUpDown();
            this.checkDebug = new System.Windows.Forms.CheckBox();
            this.imageBombe = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreMines)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelJeu
            // 
            this.tableLayoutPanelJeu.ColumnCount = 10;
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelJeu.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelJeu.Name = "tableLayoutPanelJeu";
            this.tableLayoutPanelJeu.RowCount = 10;
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelJeu.Size = new System.Drawing.Size(420, 420);
            this.tableLayoutPanelJeu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temps écoulé :";
            // 
            // lblTxtSecondes
            // 
            this.lblTxtSecondes.AutoSize = true;
            this.lblTxtSecondes.Location = new System.Drawing.Point(140, 488);
            this.lblTxtSecondes.Name = "lblTxtSecondes";
            this.lblTxtSecondes.Size = new System.Drawing.Size(59, 13);
            this.lblTxtSecondes.TabIndex = 2;
            this.lblTxtSecondes.Text = "seconde(s)";
            // 
            // lblSeconde
            // 
            this.lblSeconde.AutoSize = true;
            this.lblSeconde.Location = new System.Drawing.Point(121, 488);
            this.lblSeconde.Name = "lblSeconde";
            this.lblSeconde.Size = new System.Drawing.Size(13, 13);
            this.lblSeconde.TabIndex = 3;
            this.lblSeconde.Text = "0";
            this.lblSeconde.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(257, 478);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(173, 23);
            this.btnRecommencer.TabIndex = 4;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de Mines :";
            // 
            // nudNombreMines
            // 
            this.nudNombreMines.Location = new System.Drawing.Point(111, 463);
            this.nudNombreMines.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudNombreMines.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNombreMines.Name = "nudNombreMines";
            this.nudNombreMines.Size = new System.Drawing.Size(88, 20);
            this.nudNombreMines.TabIndex = 6;
            this.nudNombreMines.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkDebug
            // 
            this.checkDebug.AutoSize = true;
            this.checkDebug.Location = new System.Drawing.Point(257, 455);
            this.checkDebug.Name = "checkDebug";
            this.checkDebug.Size = new System.Drawing.Size(58, 17);
            this.checkDebug.TabIndex = 7;
            this.checkDebug.Text = "Debug";
            this.checkDebug.UseVisualStyleBackColor = true;
            this.checkDebug.CheckedChanged += new System.EventHandler(this.checkDebug_CheckedChanged);
            // 
            // imageBombe
            // 
            this.imageBombe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageBombe.ImageStream")));
            this.imageBombe.TransparentColor = System.Drawing.Color.Transparent;
            this.imageBombe.Images.SetKeyName(0, "demineur.png");
            // 
            // FormDemineur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 510);
            this.Controls.Add(this.checkDebug);
            this.Controls.Add(this.nudNombreMines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.lblSeconde);
            this.Controls.Add(this.lblTxtSecondes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanelJeu);
            this.Name = "FormDemineur";
            this.Text = "Démineur";
            this.Load += new System.EventHandler(this.FormDemineur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreMines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelJeu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTxtSecondes;
        private System.Windows.Forms.Label lblSeconde;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNombreMines;
        private System.Windows.Forms.CheckBox checkDebug;
        private System.Windows.Forms.ImageList imageBombe;
    }
}

