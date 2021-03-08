using System;
using System.Collections.Generic;
using System.Text;

namespace The_First
{
    class Compte
    {
        private readonly Int64 num_compt;
        private static Int64 ctr=0;
        private readonly Client titulaire;
        private Mad solde;
        private static Mad plafond = new Mad(10000);

        public Compte(Mad solde, Client tituler)
        {
            ctr++;
            this.num_compt = ctr;
            this.titulaire = tituler;
            this.solde = solde;

        }
        public bool crediter(Mad montant)
        {
            if (montant.comparer() == 1)
            {
                this.solde = this.solde + montant;
                return true;
            }

            return false;
        }
        public bool debiter(Mad montant)
        {
            if (montant.comparer() == 1)
            {
                if(this.solde.comparer(montant) == 1)
                {
                    if (plafond.comparer(montant) == 1)
                    {
                        this.solde = this.solde - montant;
                        return true;
                    }

                }
            
            }

            return false;
        }
        public void Aficher()
        {
            Console.WriteLine("Le numero de compte  est :" + this.num_compt);
            this.titulaire.Afficher();
            this.solde.Afficher();
            
        }
    }
}
