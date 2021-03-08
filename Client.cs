using System;
using System.Collections.Generic;
using System.Text;

namespace The_First
{
    class Client
    {
        private string nom, prenom, adresse;
        public Client(string nom, string prenom, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }
        public void Afficher()
        {
            Console.WriteLine("Le nom est :" + nom);
            Console.WriteLine("Le prenom est :" + prenom);
            Console.WriteLine("La dresse est :" + adresse);

        }
    }
}
