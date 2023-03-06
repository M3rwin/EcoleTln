using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.ClassesEcole
{
    class EtudiantRegulier: Etudiant
    {
        private double noteMoyenne;

        public EtudiantRegulier(int matricule, string nom, int anneeArrivee, string section, double noteMoyenne)
            :base(matricule, nom, anneeArrivee, section)
        {
            this.noteMoyenne = noteMoyenne;
        }
    }
}
