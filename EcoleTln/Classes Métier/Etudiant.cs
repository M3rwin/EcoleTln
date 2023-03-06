using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.ClassesEcole
{
    class Etudiant : Contact
    {
        protected string section;

        public Etudiant(int matricule, string nom, int anneeArrivee, string section)
            : base(matricule, nom, anneeArrivee)
        {
            this.section = section;
        }
    }
}
