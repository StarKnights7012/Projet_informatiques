namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.lrecherche = new System.Windows.Forms.Label();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.button_recherche = new System.Windows.Forms.Button();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.button_voirrech = new System.Windows.Forms.Button();
            this.button_annulerrech = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // lrecherche
            // 
            this.lrecherche.AutoSize = true;
            this.lrecherche.Location = new System.Drawing.Point(123, 43);
            this.lrecherche.Name = "lrecherche";
            this.lrecherche.Size = new System.Drawing.Size(69, 13);
            this.lrecherche.TabIndex = 0;
            this.lrecherche.Text = "Rechercher :";
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.Location = new System.Drawing.Point(198, 40);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(172, 20);
            this.textBox_recherche.TabIndex = 1;
            // 
            // button_recherche
            // 
            this.button_recherche.Location = new System.Drawing.Point(386, 38);
            this.button_recherche.Name = "button_recherche";
            this.button_recherche.Size = new System.Drawing.Size(121, 23);
            this.button_recherche.TabIndex = 5;
            this.button_recherche.Text = " Rechercher";
            this.button_recherche.UseVisualStyleBackColor = true;
            this.button_recherche.Click += new System.EventHandler(this.button_recherche_Click);
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToResizeColumns = false;
            this.datagridview.AllowUserToResizeRows = false;
            this.datagridview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(53, 76);
            this.datagridview.MultiSelect = false;
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.Size = new System.Drawing.Size(482, 205);
            this.datagridview.TabIndex = 6;
            // 
            // button_voirrech
            // 
            this.button_voirrech.Location = new System.Drawing.Point(53, 302);
            this.button_voirrech.Name = "button_voirrech";
            this.button_voirrech.Size = new System.Drawing.Size(156, 23);
            this.button_voirrech.TabIndex = 7;
            this.button_voirrech.Text = "Voir Film";
            this.button_voirrech.UseVisualStyleBackColor = true;
            this.button_voirrech.Click += new System.EventHandler(this.button_voirrech_Click);
            // 
            // button_annulerrech
            // 
            this.button_annulerrech.Location = new System.Drawing.Point(379, 302);
            this.button_annulerrech.Name = "button_annulerrech";
            this.button_annulerrech.Size = new System.Drawing.Size(156, 23);
            this.button_annulerrech.TabIndex = 8;
            this.button_annulerrech.Text = "Annuler";
            this.button_annulerrech.UseVisualStyleBackColor = true;
            this.button_annulerrech.Click += new System.EventHandler(this.button_annulerrech_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 337);
            this.ControlBox = false;
            this.Controls.Add(this.button_annulerrech);
            this.Controls.Add(this.button_voirrech);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.button_recherche);
            this.Controls.Add(this.textBox_recherche);
            this.Controls.Add(this.lrecherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Recherche par Nom";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lrecherche;
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.Button button_recherche;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Button button_voirrech;
        private System.Windows.Forms.Button button_annulerrech;
    }
}