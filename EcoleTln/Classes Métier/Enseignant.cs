using System;
using System.Collections.Generic;
using System.Text;
using Classes.ClassesEcole;

namespace Classes.ClassesEcole
{
    class Enseignant : Personnel
    {
        private string section;

        public Enseignant(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire, string section)
            :base(matricule, nom, anneeArrivee, nomLaboratoire, salaire)
        {
            this.section = section;
        }
    }
}
