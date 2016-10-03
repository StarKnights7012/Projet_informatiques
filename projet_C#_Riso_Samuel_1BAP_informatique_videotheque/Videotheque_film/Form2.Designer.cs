namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_add_film = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.button_add_ed = new System.Windows.Forms.Button();
            this.textBox_resume = new System.Windows.Forms.TextBox();
            this.textBox_realisateur = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_titre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_add_film);
            this.panel1.Controls.Add(this.button_annuler);
            this.panel1.Controls.Add(this.button_add_ed);
            this.panel1.Controls.Add(this.textBox_resume);
            this.panel1.Controls.Add(this.textBox_realisateur);
            this.panel1.Controls.Add(this.textBox_date);
            this.panel1.Controls.Add(this.textBox_titre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 373);
            this.panel1.TabIndex = 2;
            // 
            // button_add_film
            // 
            this.button_add_film.Location = new System.Drawing.Point(633, 314);
            this.button_add_film.Name = "button_add_film";
            this.button_add_film.Size = new System.Drawing.Size(110, 45);
            this.button_add_film.TabIndex = 11;
            this.button_add_film.Text = "Ajouter Film";
            this.button_add_film.UseVisualStyleBackColor = true;
            this.button_add_film.Click += new System.EventHandler(this.button_add_film_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(470, 314);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(110, 45);
            this.button_annuler.TabIndex = 10;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_add_ed
            // 
            this.button_add_ed.Location = new System.Drawing.Point(61, 230);
            this.button_add_ed.Name = "button_add_ed";
            this.button_add_ed.Size = new System.Drawing.Size(232, 45);
            this.button_add_ed.TabIndex = 9;
            this.button_add_ed.Text = "Ajouter / Modifier Image";
            this.button_add_ed.UseVisualStyleBackColor = true;
            this.button_add_ed.Click += new System.EventHandler(this.button_add_ed_Click);
            // 
            // textBox_resume
            // 
            this.textBox_resume.Location = new System.Drawing.Point(470, 119);
            this.textBox_resume.Multiline = true;
            this.textBox_resume.Name = "textBox_resume";
            this.textBox_resume.Size = new System.Drawing.Size(282, 180);
            this.textBox_resume.TabIndex = 8;
            // 
            // textBox_realisateur
            // 
            this.textBox_realisateur.Location = new System.Drawing.Point(470, 75);
            this.textBox_realisateur.Name = "textBox_realisateur";
            this.textBox_realisateur.Size = new System.Drawing.Size(100, 20);
            this.textBox_realisateur.TabIndex = 7;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(470, 38);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(100, 20);
            this.textBox_date.TabIndex = 6;
            // 
            // textBox_titre
            // 
            this.textBox_titre.Location = new System.Drawing.Point(470, 5);
            this.textBox_titre.Name = "textBox_titre";
            this.textBox_titre.Size = new System.Drawing.Size(100, 20);
            this.textBox_titre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Résumé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Réalisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de sortie :";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox.Location = new System.Drawing.Point(61, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(232, 200);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 407);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Ajouter/Modifier Film";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_add_ed;
        private System.Windows.Forms.TextBox textBox_resume;
        private System.Windows.Forms.TextBox textBox_realisateur;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_titre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Button button_add_film;
    }
}