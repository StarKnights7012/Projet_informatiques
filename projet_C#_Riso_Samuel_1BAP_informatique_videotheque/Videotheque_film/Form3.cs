using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<string> recherche_string = new List<string>();

        List<film> recherche_base;          //Copie de la base données d'origine

        string nom_recherche;

        int index_base = 0;

        public List<film> Recherche_base//l'assesseur de la copie de la bdd
        {
            get { return recherche_base; }
            set { recherche_base = value; }
        }

        public int Index_base//l'assesseur de l'index de la recherche
        {
            get { return index_base; }
            set { index_base = value; }
        }

        private void button_annulerrech_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_voirrech_Click(object sender, EventArgs e)
        {
            try
            {
                int numero_cell = datagridview.CurrentRow.Index;        //Récupération de l'index de la cellule choisie
                nom_recherche = datagridview[0, numero_cell].Value.ToString();      //récupération du nom de la recherche

                if (nom_recherche != "")        //Test si le nom n'est pas vide
                {
                    if (int.TryParse(datagridview[3, numero_cell].Value.ToString(), out index_base))//on teste si l'index est bien un chiffre si c'est le cas, on déclare que la réponse de l'utilisateur est Ok
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur a eu lieu lors de la recherche.", "Erreur de recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }           //Si nom est vide on affiche un message d'erreur
                else
                {
                    MessageBox.Show("La ligne sélectionnée est vide", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_recherche_Click(object sender, EventArgs e)
        {
            if (textBox_recherche.Text != "")//Vérification si le texte n'est pas vide
            {
                
                int recher, i, j = datagridview.Rows.Count - 1;

                for (i = j - 1; i >= 0; i--)        //Lancement d'une boucle qui va enlever toutes les lignes de la datagridview
                {
                    datagridview.Rows.RemoveAt(i);
                }

                datagridview.Rows[0].SetValues("", "", "");//on affiche à nouveau la première ligne

                i = 0;      //variable i à 0

                foreach (film s in recherche_base)
                {
                     recher = recherche_base[i].Nom.IndexOf(textBox_recherche.Text);        //Recherche le terme dans la base de donnée

                     if (recher != -1)      //Si résultat on créé une ligne dans le datagridview
                     {
                         datagridview.Rows.Add(recherche_base[i].Nom, recherche_base[i].Realisateur, recherche_base[i].Annee, i);
                     }

                     i++;
                 }      
                
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Ajout des éléments à la liste recherche_string
            recherche_string.Add("Nom du film");
            recherche_string.Add("Nom du réalisateur");
            recherche_string.Add("Année du film");

            //Ajout de 4 colonnes à la datagridview et on nomme chaque colonne
            datagridview.ColumnCount = 4;
            datagridview.Columns[0].Name = "Nom du film";
            datagridview.Columns[1].Name = "Nom du réalisateur";
            datagridview.Columns[2].Name = "Année";
            datagridview.Columns[3].Name = "Index";

            //Changement de la largeur du datagridview
            datagridview.Width = datagridview.Columns[0].Width + datagridview.Columns[1].Width + datagridview.Columns[2].Width + datagridview.Columns[3].Width + 50;

            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//on choisit le mode de sélection du datagridview en fullrow
        }
    }
}
