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


        Contact(int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArrivee = anneeArrivee;
        }
    }
}
