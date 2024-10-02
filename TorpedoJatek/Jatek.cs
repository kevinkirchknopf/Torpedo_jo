using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TorpedoJatek
{
    public class Jatek
    {
        Palya p;

        public Jatek() 
        {
            p = new Palya(10, 10);
            p.HajoLerak();
         
              
                Loves();
           

         

           
        }

        public void Loves()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine(p.Osszelet());
                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Add meg a lövés koordinátáit (1,5)");
                string[] koord = Console.ReadLine().Split(",");
                x = int.Parse(koord[0]);
                y = int.Parse(koord[1]);

                if (p.Lovestalalt(x, y) == null)
                {
                    p.Tenger.Add(new Pont(x, y, null, true));
                }
                else
                {
                    p.Lovestalalt(x, y).Hajo.Meret--;
                    p.Lovestalalt(x, y).talalat = true; ;


                }
                p.Kirajzol();

               
            } while (p.Osszelet() != 0);
            System.Environment.Exit(0);
          
        }
    }
}
