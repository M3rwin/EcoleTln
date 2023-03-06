using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.ClassesEcole
{
    class Ecole
    {
        // Attributs
        private string nom;
        private int anneeCreation;
        private Dictionary<int, Contact> contacts = new Dictionary<int, Contact>();

        // Constructeur
        public Ecole(string nom, int anneeCreation)
        {
            this.nom = nom;
            this.anneeCreation = anneeCreation;
        }

        // Propriétés
        public string Nom { get => nom; set => nom = value; }
        public int AnneeCreation { get => anneeCreation; set => anneeCreation = value; }
        internal Dictionary<int, Contact> Contacts { get => contacts; set => contacts = value; }

        // Méthodes
        static void AfficheTous()
        {

        }


    }
}
