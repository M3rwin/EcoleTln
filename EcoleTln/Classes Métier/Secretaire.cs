using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.ClassesEcole
{
    class Secretaire : Personnel
    {
        public Secretaire(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire)
            : base(matricule, nom, anneeArrivee, nomLaboratoire, salaire) {}

    }
}
