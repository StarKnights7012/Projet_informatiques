namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.éditionFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerBasetoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.textBox_resume = new System.Windows.Forms.TextBox();
            this.textBox_realisateur = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_titre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationFilmToolStripMenuItem,
            this.éditionFilmToolStripMenuItem,
            this.supprimerFilmToolStripMenuItem,
            this.chargerBasetoolStripMenuItem2,
            this.sauvegarderBaseToolStripMenuItem,
            this.resetBaseToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // créationFilmToolStripMenuItem
            // 
            this.créationFilmToolStripMenuItem.Name = "créationFilmToolStripMenuItem";
            this.créationFilmToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.créationFilmToolStripMenuItem.Text = "Création";
            this.créationFilmToolStripMenuItem.Click += new System.EventHandler(this.créationFilmToolStripMenuItem_Click);
            // 
            // éditionFilmToolStripMenuItem
            // 
            this.éditionFilmToolStripMenuItem.Name = "éditionFilmToolStripMenuItem";
            this.éditionFilmToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.éditionFilmToolStripMenuItem.Text = "Edition";
            this.éditionFilmToolStripMenuItem.Click += new System.EventHandler(this.éditionFilmToolStripMenuItem_Click);
            // 
            // supprimerFilmToolStripMenuItem
            // 
            this.supprimerFilmToolStripMenuItem.Name = "supprimerFilmToolStripMenuItem";
            this.supprimerFilmToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.supprimerFilmToolStripMenuItem.Text = "Suppression";
            this.supprimerFilmToolStripMenuItem.Click += new System.EventHandler(this.supprimerFilmToolStripMenuItem_Click);
            // 
            // chargerBasetoolStripMenuItem2
            // 
            this.chargerBasetoolStripMenuItem2.Name = "chargerBasetoolStripMenuItem2";
            this.chargerBasetoolStripMenuItem2.Size = new System.Drawing.Size(230, 22);
            this.chargerBasetoolStripMenuItem2.Text = "Charger base de données";
            this.chargerBasetoolStripMenuItem2.Click += new System.EventHandler(this.chargerBasetoolStripMenuItem2_Click);
            // 
            // sauvegarderBaseToolStripMenuItem
            // 
            this.sauvegarderBaseToolStripMenuItem.Name = "sauvegarderBaseToolStripMenuItem";
            this.sauvegarderBaseToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.sauvegarderBaseToolStripMenuItem.Text = "Sauvegarder base de données";
            this.sauvegarderBaseToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderBaseToolStripMenuItem_Click);
            // 
            // resetBaseToolStripMenuItem
            // 
            this.resetBaseToolStripMenuItem.Name = "resetBaseToolStripMenuItem";
            this.resetBaseToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.resetBaseToolStripMenuItem.Text = "Reset base de données";
            this.resetBaseToolStripMenuItem.Click += new System.EventHandler(this.resetBaseToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            this.rechercheToolStripMenuItem.Click += new System.EventHandler(this.rechercheToolStripMenuItem_Click);
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_right);
            this.panel1.Controls.Add(this.button_left);
            this.panel1.Controls.Add(this.textBox_resume);
            this.panel1.Controls.Add(this.textBox_realisateur);
            this.panel1.Controls.Add(this.textBox_date);
            this.panel1.Controls.Add(this.textBox_titre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 363);
            this.panel1.TabIndex = 1;
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(214, 290);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 23);
            this.button_right.TabIndex = 10;
            this.button_right.Text = ">>>";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(57, 290);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 23);
            this.button_left.TabIndex = 9;
            this.button_left.Text = "<<<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // textBox_resume
            // 
            this.textBox_resume.Location = new System.Drawing.Point(447, 165);
            this.textBox_resume.Multiline = true;
            this.textBox_resume.Name = "textBox_resume";
            this.textBox_resume.ReadOnly = true;
            this.textBox_resume.Size = new System.Drawing.Size(282, 180);
            this.textBox_resume.TabIndex = 8;
            // 
            // textBox_realisateur
            // 
            this.textBox_realisateur.Location = new System.Drawing.Point(447, 121);
            this.textBox_realisateur.Name = "textBox_realisateur";
            this.textBox_realisateur.ReadOnly = true;
            this.textBox_realisateur.Size = new System.Drawing.Size(100, 20);
            this.textBox_realisateur.TabIndex = 7;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(447, 84);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.ReadOnly = true;
            this.textBox_date.Size = new System.Drawing.Size(100, 20);
            this.textBox_date.TabIndex = 6;
            // 
            // textBox_titre
            // 
            this.textBox_titre.Location = new System.Drawing.Point(447, 51);
            this.textBox_titre.Name = "textBox_titre";
            this.textBox_titre.ReadOnly = true;
            this.textBox_titre.Size = new System.Drawing.Size(100, 20);
            this.textBox_titre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Résumé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Réalisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de sortie :";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox.Location = new System.Drawing.Point(57, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(232, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Vidéothèque";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem éditionFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerBasetoolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_resume;
        private System.Windows.Forms.TextBox textBox_realisateur;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_titre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
    }
}

