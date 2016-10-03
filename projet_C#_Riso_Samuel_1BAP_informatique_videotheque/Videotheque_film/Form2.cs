
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        // 2 string pour le nom du fichier et le nom de l'emplacement du fichier
        string nom_image;
        string nom_fichier;
        bool entree = false;
        bool verification = false;
        bool existence = false;
        bool modification;
        int ligne_base;

        List<film> videotheque = new List<film>(); // liste contenant les films

        public List<film> Videotheque               //pour acceder à la liste
        {
            get { return videotheque; }
            set { videotheque = value; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //1ère initialisation objet, importation de la collection de films depuis le fichier seulement la première fois
            if (!entree)
            {
                modification = false;

                // Valeurs par défaut de l'image du film, le nom et l'emplacement de l'image, l'annee, le nom et du réalisateur du film
                nom_fichier = "film.jpg";
                try
                {
                    pictureBox.Image = Image.FromFile(Application.StartupPath + @"\images\film.jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                nom_image = Application.StartupPath + @"\images\film.jpg";

                entree = true;
            }

            if (modification)           //Si vrai
            {
                string[] nom_court = videotheque[ligne_base].Image.Split('\\');  //Récupération des éléments du chemin de fichier qu'on sépare par le \

                //Save des élémnents à modifier
                textBox_titre.Text = videotheque[ligne_base].Nom;
                textBox_realisateur.Text = videotheque[ligne_base].Realisateur;
                textBox_date.Text = videotheque[ligne_base].Annee;
                textBox_resume.Text = videotheque[ligne_base].Resume;

                nom_fichier = nom_court[2];         //Récupération du nom du fichier

                nom_image = Application.StartupPath + videotheque[ligne_base].Image;  //Récupération du chemin complet de l'image

                try //Test pour voir l'affichage de l'image
                {
                    pictureBox.Image = Image.FromFile(Application.StartupPath + videotheque[ligne_base].Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                button_add_film.Text = "Modifier film";   //"Modifier film" dans le caption du bouton 
            }
            //Sinon : Ajout de film
            else
            {
                nom_image = Application.StartupPath + @"\images\film.jpg";

                textBox_titre.Text = "New Film";
                textBox_realisateur.Text = "Director";
                textBox_date.Text = DateTime.Now.Year.ToString();
                textBox_resume.Text = "Empty.";

                button_add_film.Text = "Ajouter film";      //"Ajouter un film" dans le caption du bouton
            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            textBox_titre.Text = "";
            textBox_realisateur.Text = "";
            textBox_date.Text = "";
            textBox_resume.Text = "";

            this.DialogResult = DialogResult.Cancel;
            this.Hide();

        }

        private void button_add_film_Click(object sender, EventArgs e)   //bouton pour ajouter le film à la base donnée
        {
            int test1, test2, test3;

            test1 = textBox_titre.Text.IndexOf('#');
            test2 = textBox_realisateur.Text.IndexOf('#');
            test3 = textBox_resume.Text.IndexOf('#');

            // Test pour voir si on a bien entré des donneée au niveau du titre et réalisateur
            if (textBox_titre.Text != "" && textBox_realisateur.Text != "" && test1 == -1 && test2 == -1 && test3 == -1)
            {
                //VAR date
                int essai_annee;

                //Test pour voir si la date entré est valide
                if (int.TryParse(textBox_date.Text, out essai_annee))
                {
                    int annee_now = DateTime.Now.Year;
                    //Verification que la date entrée soit plus grande que 1900 et plus petite que 25 ans après l'année actuelle (pour les film future)
                    if (essai_annee >= 1900 && essai_annee <= (annee_now + 25))
                    {
                        string test_img = @"\images\" + nom_fichier;

                        if (!existence)
                        {
                            Ajout();
                        }
                        else
                        {
                            if (test_img != videotheque[ligne_base].Image) //Verification si l'image qu'on va copier n'est pas déjà présente
                            {
                                Ajout();
                            }
                        }

                        if (textBox_resume.Text == "")
                        {
                            textBox_resume.Text = "empty";
                        }

                        if (modification)
                        {
                            videotheque[ligne_base].Nom = textBox_titre.Text;
                            videotheque[ligne_base].Realisateur = textBox_realisateur.Text;
                            videotheque[ligne_base].Annee = textBox_date.Text;
                            videotheque[ligne_base].Image = @"\images\" + nom_fichier;
                            videotheque[ligne_base].Resume = textBox_resume.Text;
                        }
                        else
                        {
                             //Création du film avec les données entrées
                             film video = new film(textBox_titre.Text, @"\images\" + nom_fichier, textBox_realisateur.Text, textBox_date.Text, textBox_resume.Text);
                             

                             videotheque.Add(video);         //On ajoute l'objet dans la base donnée
                        }

                        this.DialogResult = DialogResult.OK;    //Revois OK
                        this.Hide();
                    }
                    //Partie sur les messages d'erreurs des conditions non respectées
                    else
                    {
                        MessageBox.Show("L'année entrée est incorrecte. Veuillez entrer une année comprise entre 1900 et " + (annee_now + 25) + "(Année limite).", "Erreur : Année incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas entrée une année en chiffre .","Erreur : Année invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Le titre et/ou le nom du réalisateur du film sont incorrects.", "Erreur : Titre et/ou réalisateur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void fonction()              //initialisation de form2 depuis form1
        {
           
            Form2_Load(null, null);
        }

        public bool Modification            //l'assesseur du booléen modif
        {
            get { return modification; }
            set { modification = value; }
        }

        public int Ligne_base               //l'assesseur de l'index
        {
            get { return ligne_base; }
            set { ligne_base = value; }
        }

        public bool Existence                  //l'assesseur du booléen existence
        {
            get { return existence; }
            set { existence = value; }
        }

        public bool Verification                //l'assesseur du booléen verification
        {
            get { return verification; }
            set { verification = value; }
        }

        public void Ajout()
        {
            if (!(File.Exists(Application.StartupPath + @"\images\" + nom_fichier)))
            {
                try
                {
                    //Test de copie l'image
                    File.Copy(nom_image, Application.StartupPath + @"\images\" + nom_fichier);
                }
                catch (Exception ex)
                {
                    //Message d'erreur
                    MessageBox.Show(ex.Message + Environment.NewLine + "Néanmoins, votre nouvelle entrée de film dans la base de donnée à bien été prise en compte.", "Erreur de copie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_add_ed_Click(object sender, EventArgs e)    //Lors du click "choisir/modifier image film"
        {
            
            //fenêtre openfiledialog, un seul fichier selectionnable et uniquement des images
            OpenFileDialog ouvert = new OpenFileDialog();
            ouvert.Title = "Enregistrement de l'image";
            ouvert.Multiselect = false;
            ouvert.Filter = "Images|*.jpg;*.gif;*jpg;*.png;*.bmp";

            //Afficher l'openfiledialog
            DialogResult resultat = ouvert.ShowDialog();

            //Si OK"
            if (resultat == DialogResult.OK)
            {
                try //Test de l'ouverture de l'image
                {
                    //Save le chemin de l'image ainsi que son nom
                    nom_image = ouvert.FileName;
                    nom_fichier = ouvert.SafeFileName;

                    //on affiche l'image dans le picturebox
                    pictureBox.Image = Image.FromFile(nom_image);
                }
                catch (Exception ex) //Erreur a affichée
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Mise_basedonnee (string nom_chemin)
        {
            int i = videotheque.Count; //Compte le nbe d'objets dans la liste

            if (i > 0) //Si un objet ou plus
            {
                videotheque.Clear();        //Suppression totale de la base de donnée
            }
            string[] fichier;

            try //Test ouverture fichier
            {
                fichier = File.ReadAllLines(nom_chemin);    //Ouvre le fichier dans un tableau de string

                string code;                                //variable "code" pour l'autentification
                bool fichier_pr = true;                     //Création bool

                code = "af3b5deaff";                        //Code d'autentification dans une chaine
                string fichier_code = "";                   //Variable avec la ligne à vérifier


                foreach (string line in fichier)            //Chaque ligne du fichier
                {

                    if (fichier_pr)                         //Si vrai (première fois seulement)
                    {
                        fichier_code = line;                //Première ligne dans la variable à vérifier
                        fichier_pr = false;                 //bool en false
                    }
                    else
                    {
                        if (fichier_code == code)           //Verification si identique (si pas, création d'un nouveau fichier dans le logiciel)
                        {
                            verification = true;            //Si verification ok

                            string[] mots = line.Split('#');                //ligne séparée par "#"

                            film film = new film(mots[0], mots[1], mots[2], mots[3], mots[4]);//on ajoute les éléments dans un objet de type film

                            videotheque.Add(film);              //on crée la liste d'objet
                        }
                        else
                        {
                            verification = false;
                        }
                    }
                }
            }
            catch (Exception ex)            // Affiche si erreur
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Verification)               //Si verification OK
            {
                this.Hide();
            }
            else                            //Si verification pas Ok : Erreru
            {
                MessageBox.Show("Le fichier séléctionné n'est pas un valide avec ce programme.", "Erreur fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}
