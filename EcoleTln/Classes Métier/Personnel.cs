using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.ClassesEcole
{
    class Personnel : Contact
    {
        protected string nomLaboratoire;
        protected double salaire;

        public Personnel(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire)
            : base(matricule, nom, anneeArrivee)
        {
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }
    }
}
