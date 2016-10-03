using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int indice = 0;

        bool auto_ecriture = false; 
        
        Form2 montrer = new Form2();    // Création de la seconde form(FORM2)

        private void créationFilmToolStripMenuItem_Click(object sender, EventArgs e) //montrer formulaire pour creation film
        {
            DialogResult ajoute = new DialogResult();
            montrer.Modification = false;

            ajoute = montrer.ShowDialog();  //Affichage de la FORM2

            if (ajoute == DialogResult.OK)      //Si OK
            {

                                                            //Ajout duu film à la base donnée
                indice = montrer.Videotheque.Count - 1;

                Afficher_film(indice);          //Affichage film de l'index
            }
            
        }

        private void éditionFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ajoute = new DialogResult();

            montrer.Modification = true;
            montrer.Ligne_base = indice;

            ajoute = montrer.ShowDialog();      //Affichage de la FORM2

            
            if (ajoute == DialogResult.OK)      //Si OK
            {      
                Afficher_film(indice);          //Affichage 
            }
        }

        private void Afficher_film(int i)
        {
            
            bool attention = false;

            try                                         //TEST si l'affichage fonctionne corretement
            {
                                                        //Envoie des valeurs à la form
                textBox_titre.Text = montrer.Videotheque[i].Nom;
                textBox_realisateur.Text = montrer.Videotheque[i].Realisateur;
                textBox_date.Text = montrer.Videotheque[i].Annee;
                textBox_resume.Text = montrer.Videotheque[i].Resume;

                activation_boutons();                   //Activation des boutons et autres qui étaient desactivés
            }
            catch (Exception ex)     //Sinon, erreur et on desactive les boutons et autres
            {
                if (!attention)
                {
                    MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    desactivation_boutons();
                    attention = true;
                }

            }

            if (!attention)
            {
                try                     //on teste l'ouverture de l'image
                {
                    pictureBox.Image = Image.FromFile(Application.StartupPath + montrer.Videotheque[i].Image);
                }
                catch (Exception ex)
                {
                    string chemin;
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chemin = @"\images\film.jpg";
                    try
                    {
                        montrer.Videotheque[i].Image = chemin;
                    }
                    catch (Exception ex3)
                    {
                        MessageBox.Show(ex3.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        pictureBox.Image = Image.FromFile(Application.StartupPath + montrer.Videotheque[i].Image);
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                desactivation_boutons();
                montrer.Existence = false;
                suppression();
                indice = 0;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)         // quitter le programme
        {
            DialogResult exit = MessageBox.Show("Voulez vous quitter la vidéothèque ?",
                "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exit == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button_left_Click(object sender, EventArgs e)          //l'indice de film dimininue, va au film précédent
        {

            if (indice > 0)         //Si index plus grand que 0
            {
                indice--;         // -1 à l'index
            }
            else
            {
                indice = (montrer.Videotheque.Count) - 1;    //L'index égalera le nombre de film contenu dans la base de donnée -1
            }

            Afficher_film(indice);          //Affichage du film dans l'index

        }

        private void button_right_Click(object sender, EventArgs e)         //l'indice de film augmente, va au film suivant
        {
            if (indice < (montrer.Videotheque.Count) - 1)    //Si index plus petit que le nbre de film dans la base donnée
            {
                indice++;             // +1 à l'index
            }
            else
            {
                indice = 0;           //L'index repasse à 0
            }

            Afficher_film(indice);       //Affihage du film dans l'index
             
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)   //Onglet A propros de la Videotheque
        {
            MessageBox.Show("Créé par Riso Samuel" + Environment.NewLine + "Etudiant en 1ère Bachelier Informatique et Systèmes : finalité réseaux & télécommunications." + Environment.NewLine + "HEH Campus Technique (ISIMs)" + Environment.NewLine + "Année Académique : 2014-2015", "Créateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            desactivation_boutons();            //Desactive les boutons non neccessaire.


            montrer.fonction();                  //Démarage de FORM2 au lancement de FORM1(FORM LOAD)

        }

        private void activation_boutons()       //Active certains boutons et éléments
        {

            button_left.Enabled = true;
            button_right.Enabled = true;
            rechercheToolStripMenuItem.Enabled = true;
            éditionFilmToolStripMenuItem.Enabled = true;
            supprimerFilmToolStripMenuItem.Enabled = true;
            resetBaseToolStripMenuItem.Enabled = true;
            sauvegarderBaseToolStripMenuItem.Enabled = true;
        }

        private void desactivation_boutons()         //Desactive certains boutons et éléments
        {

            button_left.Enabled = false;
            button_right.Enabled = false;
            rechercheToolStripMenuItem.Enabled = false;
            éditionFilmToolStripMenuItem.Enabled = false;
            supprimerFilmToolStripMenuItem.Enabled = false;
            resetBaseToolStripMenuItem.Enabled = false;
            sauvegarderBaseToolStripMenuItem.Enabled = false;
        }

        private void supprimerFilmToolStripMenuItem_Click(object sender, EventArgs e) //suppression du film afficher en cours
        {
            montrer.Videotheque.RemoveAt(indice);                 //   Supression de l'élément dans l'index
            if (indice != 0)                                      // Si index != 0 
            {
                indice--;                                         //  -1 à l'index
            }
            if (montrer.Videotheque.Count == 0)
            {
                suppression();                                     // Suppression du film
                desactivation_boutons();                          //Desactivation des boutons et autres non utile
            }
            else
            {
                Afficher_film(indice);                            //Affichage du nouvel élément dans l'index
            }
        }

        private void resetBaseToolStripMenuItem_Click(object sender, EventArgs e) //Supprime la base de donnée en cours
        {
            montrer.Videotheque.Clear();         //Suppression totale de la base de donnée
            suppression();                           //Efface ce qui a à l'écran
            desactivation_boutons();            //Desactivation de certains boutons,...
            indice = 0;
        }

        private void suppression()                   // Efface le film en cours
        {
                                                //EFFACE les éléments du film affichés à l'écran
            textBox_titre.Text = "";
            textBox_date.Text = "";
            textBox_resume.Text = "";
            textBox_realisateur.Text = "";
            pictureBox.Image = null;
        }

        private void sauvegarderBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(); //Lancement de la sauvegarde
        }

        private void Save()                 //Sert lors de la sauvegarde
        {
                                            //savefiledialog et on paramètre bien tous les éléments
            SaveFileDialog sauvegarde = new SaveFileDialog();
            sauvegarde.Title = "Sauvegarde de la base de donnée";
            sauvegarde.Filter = "Texte | *.txt";
            sauvegarde.InitialDirectory = Application.StartupPath + @"\save";       //endroit du dossier pour sauvegarder
            sauvegarde.RestoreDirectory = true;

            DialogResult test_save = sauvegarde.ShowDialog();       //Ouverture savefiledialog

            if (test_save == DialogResult.OK)           //Si Ok par le user
            {
                try                                     //Test de l'écriture du fichier
                {
                    //1ère ligne = vérification + saut de ligne
                    File.WriteAllText(Application.StartupPath + @"\save\save.txt", "af3b5deaff" + Environment.NewLine);
                    auto_ecriture = true;           //bool auto_ecriture à true
                }
                catch (Exception ex)                //Si pas Ok : erreur
                {
                    MessageBox.Show(ex.Message, "Erreur de sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    auto_ecriture = false;          //bool auto_ecriture à false
                }

                if (auto_ecriture)              //Si autorisation d'écrire
                {
                    bool save_reussi = false;
                    //pour chaque élément film de la liste
                    foreach (film s in montrer.Videotheque)
                    {
                        try
                        {
                            //Test de sauvegarde dans un fichier texte
                            File.AppendAllText(Application.StartupPath + @"\save\save.txt", s.Nom + "#" + s.Image + "#" + s.Realisateur + "#" + s.Annee + "#" + s.Resume);
                            save_reussi = true;
                        }
                        catch (Exception ex)
                        {
                            //Si pas Ok : erreur
                            MessageBox.Show(ex.Message, "Erreur lors de la sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            save_reussi = false;
                        }
                        //Ajout d'un saut de ligne
                        File.AppendAllText(Application.StartupPath + @"\save\save.txt", Environment.NewLine);

                        
                    }
                    if (save_reussi)
                    {
                        MessageBox.Show("La base de donnée a bien été sauvegardée.", "Sauvegarde effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                auto_ecriture = false;      //Autorisation d'écriture à false
            }
        }

        private void Loading()                //Sert pour l'ouverture de Fichier
        {
            //Ouverture de fichier et on met quels seront les fichiers qui pourront être ouverts
            OpenFileDialog ouvert = new OpenFileDialog();
            ouvert.InitialDirectory = Application.StartupPath + @"\save";           //dossier racine des saves
            ouvert.Title = "Ouverture de base de donnée";
            ouvert.Multiselect = false;
            ouvert.Filter = "Texte | *.txt";
            ouvert.RestoreDirectory = true;

            DialogResult test = ouvert.ShowDialog();

            if (test == DialogResult.OK)        //Si OK
            {
                string nom_chemin = "";
                try             //Test si nom fichier
                {
                    nom_chemin = ouvert.FileName;       //Chemin complet du fichier dans une variable
                }
                catch (Exception ex)                    //Si pas Ok : erreur
                {
                    MessageBox.Show(ex.Message, "Erreur lors du chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                montrer.Existence = true;               //variable bool existence à true
                montrer.Mise_basedonnee(nom_chemin);    //Mise_basedonnee de la form2 en envoyant le chemin du fichier

                if (montrer.Verification)               //Si verification OK
                {
                    indice = 0;                         //index à 0
                    Afficher_film(indice);              //Affichage des films
                }
                else                                    //Si verification pas OK
                {
                    suppression();                      //Suppression des éléments de la FORM
                    desactivation_boutons();            //Desactivations boutons et menus
                    montrer.Existence = false;          //booléen existence à false
                    indice = 0;                         //index à 0
                }
            }
        }

        
        
        private void chargerBasetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int nombre_elem_base = montrer.Videotheque.Count;           //Compte le nbre de film
            if (!(nombre_elem_base > 0))                                //Si pas plus grand que 0
            {
                Loading();                                              //Ouverture du fichier
            }
            else
            {
                //Demande à l'user si il veut sauvegarder la base de donnée en cours avant de charger une autre
                DialogResult test_save = MessageBox.Show("Une bibliothèque de film est déja ouverte, voulez-vous la sauvegarder ?", "Ouverture du fichier", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (test_save == DialogResult.OK)       //Si il save puis load une base de donnée
                {
                    Save();
                    Loading();
                }
                else if (test_save == DialogResult.Cancel)  //Si il ne save pas puis load une base de donnée
                {
                    Loading();
                }
            }
         }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 rechercher = new Form3();//on créé une form3 qui servira à la recherche dans la bdd

            rechercher.Recherche_base = montrer.Videotheque;//on créé une copie de la bdd dans la form3

            DialogResult test = rechercher.ShowDialog();

            if (test == DialogResult.OK)//si la réponse de l'utilisateur est = à Ok
            {
                int i = rechercher.Index_base;//on copie l'index de la recherche et on l'affiche
                Afficher_film(i);
            }
        }
     }
}

