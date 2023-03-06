using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.ClassesEcole
{
    class EtudiantEchange : Etudiant
    {
        private string universiteOrigine;

        public EtudiantEchange(int matricule, string nom, int anneeArrivee, string section, string universiteOrigine)
            :base(matricule, nom, anneeArrivee, section)
        {
            this.universiteOrigine = universiteOrigine;
        }
    }
}
