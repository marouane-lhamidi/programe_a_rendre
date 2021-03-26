using System;
using System.Collections.Generic;
using System.Text;

namespace The_First
{
    class Operation
    {
        private readonly int numero;
        private static int ctr = 0;
        private DateTime Opedate;
        private Mad Montant;
        private string libele;

        public Operation(string libele)
        {
            ctr++;
            this.numero = ctr;
            this.Opedate = DateTime.Now;
            this.libele = libele;
        }

        public void show()
        {
            Console.WriteLine("le numero de l'operation est " + this.numero);
            Console.WriteLine("le date de l'operation est " + this.Opedate);
            Console.WriteLine("le fonction de l'operation est " + this.libele);
        }

    }
}
