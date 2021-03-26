using System;

namespace The_First
{
    class Program
    {
        static void Main(string[] args)
        {
            Mad solde= new Mad(200000);
            Mad solde1= new Mad(50000);
            Mad solde2= new Mad(5000);
            Client titulaire = new Client("marouane", "LHAMIDI", "Berrechid");
            Compte comp = new Compte(solde, titulaire);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("avant la crediter");
            comp.Aficher(); // pour aficher le compte avant la crediter

            if (comp.crediter(solde1)) //ajouter un solde 
            {
                Console.WriteLine("Le solde a était bien ajouter" ); //message pour verification de l'opration

            }
            else
            {
                Console.WriteLine("verifier la fonction que tu as fait"); //message pour verification de l'opration

            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("apres la crediter");
            comp.Aficher(); // pour aficher le compte apres la crediter
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("avant la débiter");
            comp.Aficher(); // pour aficher le compte avant la débiter

            if (comp.debiter(solde2)) //ajouter un solde 
            {
                Console.WriteLine("Le solde a était bien ajouter"); //message pour verification de l'opration

            }
            else
            {
                Console.WriteLine("verifier la fonction que tu as fait"); //message pour verification de l'opration

            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("apres la dibiter");
            comp.Aficher(); // pour aficher le compte apres la dibiter
            comp.showop();

            Console.ReadKey();
        }
    }
}
