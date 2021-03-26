using System;
using System.Collections.Generic;
using System.Text;

namespace The_First
{
    class CompteEpargen : Compte
    {
        private double tauxinteret;

        public CompteEpargen(Client titu, Mad solde) : base(solde, titu )
        {
            Double taux = double.Parse(Console.ReadLine());
            while ( taux <= 0 || taux > 0)
            {
                Console.WriteLine("donnez le taux");
                taux = Console.Read();
            }
            this.tauxinteret = taux;
        }
        public void calcullintere ()
        {
            this.solde += (this.solde * this.tauxinteret) / 100;
        }
    }
}
