using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.ClassesEcole
{
    class Contact
    {
        protected int matricule;
        protected string nom;
        protected int anneeArrivee;

        public Contact(int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.AnneeArrivee = anneeArrivee;
        }

        public int AnneeArrivee { get => anneeArrivee;
            set
            {
                if (value > 2023)
                {
                    throw new Exception("Impossible, l'année n'existe pas encore");
                }
                else { this.anneeArrivee = value; }
            } 
        }


        public override string ToString()
        {
            string message = $@"
{this.GetType().Name} :
    Matricule : {this.matricule}
    Nom : {this.nom}
    Année : {this.anneeArrivee}";
            return message;
        }

    }
}
