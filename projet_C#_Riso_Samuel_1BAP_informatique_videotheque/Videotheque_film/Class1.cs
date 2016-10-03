using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class film
    {
        private string nom;
        private string image=@"\images\film.jpg";
        private string realisateur;
        private string annee;
        private string resume="";

        public film (string nom, string image, string realisateur, string annee, string resume)
        {
            this.nom = nom;
            this.image = image;
            this.realisateur = realisateur;
            this.annee = annee;
            this.resume = resume;
        }

        

       
        public string Nom
        {
            get {return nom;}
            set { nom = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public string Realisateur
        {
            get { return realisateur; }
            set { realisateur = value; }
        }



        public string Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }
    }
}
