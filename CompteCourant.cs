using System;
using System.Collections.Generic;
using System.Text;

namespace The_First
{
    class CompteCourant : Compte 
    {
        public CompteCourant(Mad solde, Client tituler) :base(solde, tituler)
        {
           
        }
        public override bool debiter(Mad montant)
        {
            if (montant.comparer() == 1)
            {
                if (this.solde.comparer(montant) == 1)
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
    }
}
