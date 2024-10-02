using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TorpedoJatek
{
    public class Palya
    {
        public List<Pont> Tenger { get; set; }
        public int oszlop { get; set; }
        public int sor { get; set; }
        public bool talalat { get; set; }
        public List<Hajo> hajok { get; set; }
       

        public void HajoLerak()
        {
            Console.Clear();
            hajok.Add(new Hajo(2, this));
            hajok.Add(new Hajo(3, this));
            foreach (Hajo hajo in hajok)
            {
                hajo.KordinataBekeres();
            }
            Kirajzol();
        }
        public Palya(int oszlopszam, int sorszam)
        {
            this.oszlop = oszlopszam;
            this.sor = sorszam;
            hajok = new List<Hajo>();
            Tenger = new List<Pont>();
        }
        public void Kirajzol()
        {
            Console.Clear();
            keret();
            Random r = new Random();
            foreach (Pont p in Tenger)
            {
              


                
                if (p.Hajo == null && p.talalat == true)
                {
                    Console.SetCursorPosition(p.y, p.x);
                    Console.WriteLine("X");
                }
                else if(p.talalat == true && p.Hajo != null)
                {
                    Console.SetCursorPosition(p.y, p.x);
                    Console.Write("O");
                }
                else
                {
                    Console.SetCursorPosition(p.y, p.x);
                    Console.WriteLine(p.Hajo.Meret);
                }

            }

        }

        public void HajoPontLerak(Pont p)
        {
            Tenger.Add(p);
        }

        private void keret()
        {
           
            Console.WriteLine(new string('#', oszlop + 2));

          
            for (int i = 0; i < sor; i++)
            {
                Console.Write("#");
                Console.Write(new string(' ', oszlop)); 
                Console.WriteLine("#");
            }

            
            Console.WriteLine(new string('#', oszlop + 2));

        }

      

        public Pont lovestalalt()
        {
            
            foreach(Pont p in Tenger)
            {
                if(p.Hajo == null)
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("O");
                    return p;
                }
                
            }
            return null;
        }

        public bool Foglaltpont(int x, int y)
        {
            
            foreach (Pont point in Tenger)
            {
                
                if (point.x == x && point.y == y)
                {
                    return true; 
                }
            }
            return false; 
        }

        public Pont Lovestalalt(int x, int y)
        {
            foreach(Pont point in Tenger)
            {
                if(point.x == x && point.y == y)
                {
                    return point;
                }
            }

            return null;
        }

        public int Osszelet()
        {
            return (from h in hajok select h.Meret).Sum();
        }

    }




}
