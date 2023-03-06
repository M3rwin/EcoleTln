using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.ClassesEcole
{
    class Contact
    {
        protected int matricule;
        protected string nom;
        private int anneeArrivee;

        public Contact(int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.AnneeArrivee = anneeArrivee;
        }

        protected int AnneeArrivee { get => anneeArrivee;
            set
            {
                if (value > 2023)
                {
                    throw new Exception("Impossible, l'année n'existe pas encore");
                }
                else { this.anneeArrivee = value; }
            } 
        }
    }
}
