using System;
using System.Collections.Generic;
using System.Text;

namespace The_First
{
    class Mad
    {
        private double sold;

        public Mad(double sold)
        {
            this.sold = sold;
        }
        public Mad()
        {
            this.sold = 0;
        }

        public void Afficher()
        {
            Console.WriteLine("Le solde est :" + sold + "Mad");
        }

        public int comparer()
        {
            if (this.sold > 0)
            {
                return 1;
            }
            return 0;

        }
        public int comparer(Mad m)
        {
            if (this.sold > m.sold)
            {
                return 1;
            }
            return 0;

        }
        public static Mad operator+(Mad b, Mad c)
        {
            Mad a = new Mad();
            a.sold = b.sold + c.sold;
            return a;
        }
        public static Mad operator -(Mad b, Mad c)
        {
            Mad a = new Mad();
            a.sold = b.sold - c.sold;
            return a;
        }
        public static bool operator <(Mad b, Mad c)
        {
            if (b.sold < c.sold)
            {
                return true;
            }
            return false ;
        }
        public static bool operator >(Mad b, Mad c)
        {
            if (b.sold > c.sold)
            {
                return true;
            }
            return false;
        }
        public static bool operator == (Mad b, Mad c)
        {
            if (b.sold == c.sold)
            {
                return true;
            }
            return false;
        }
        public static bool operator != (Mad b, Mad c)
        {
            if (b.sold != c.sold)
            {
                return true;
            }
            return false;
        } 
        public static Mad operator * (Mad b, double c)
        {
            Mad a = new Mad();
            a.sold = b.sold * c;
            return a;
        }
        public static Mad operator / (Mad b, double c)
        {
            Mad a = new Mad();
            a.sold = b.sold / c;
            return a;
        }
    }
}
