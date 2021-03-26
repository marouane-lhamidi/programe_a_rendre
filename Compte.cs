using System;
using System.Collections.Generic;
using System.Text;

namespace The_First
{
    class Compte
    {
        private readonly Int64 num_compt;
        private Operation[] historiques = new Operation[10] ;
        private static Int64 ctr=0;
        private int contee=1;
        private readonly Client titulaire;
        protected Mad solde;
        protected static Mad plafond = new Mad(10000);

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
                
                this.historiques[(contee-1)] = new Operation("crediter");
                 this.contee++;

                return true;
            }

            return false;
        }
        public virtual bool debiter(Mad montant)
        {

            if (montant.comparer() == 1)
            {
                if(this.solde.comparer(montant) == 1)
                {
                    if (plafond.comparer(montant) == 1)
                    {
                        this.solde = this.solde - montant;

                        this.historiques[(contee - 1)] = new Operation("debiter");
                        this.contee++;
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
        public void showop()
        {
            for (int i = 0; i < this.contee-1; i++)
            {
                historiques[i].show();
            }
        }
    }
}
