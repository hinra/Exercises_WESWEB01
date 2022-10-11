using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace OmKlasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kund besökare = new Kund();
            besökare.username = "hinra";
            besökare.realname = "Ralf Hintz";
            besökare.language = "de";
            

            Kund aktuellKund; // OBS! Utan new ...

            aktuellKund = besökare;
            aktuellKund.realname = "Joe Cool";

            //Console.WriteLine(besökare.fullname());
            Console.WriteLine(besökare);

            List<Produkt> inköp = new List<Produkt>();

            Produkt p = new Produkt() { pris = 1229.90, beteckning = "GeForce G1337GTX", tillverkare = "ASUS", vikt = 0.875};
            inköp.Add(p);
            p = new Produkt() { pris = 329, beteckning = "Musmatta", tillverkare = "DELL", vikt = 0.250 };
            inköp.Add(p);
            p = new Produkt() { pris = 2099, beteckning = "ATX CHASSI Classic", tillverkare = "PishiMishi" , vikt= 1.480};
            inköp.Add(p);
            p = new Produkt() { pris = 2799, beteckning = "DDR4  8GB Memory (Dimm)", tillverkare = "Corsail", vikt = 0.190 };
            inköp.Add(p);

            double totalPris = 0, totalVikt = 0; 
            foreach(Produkt pd in inköp)
            {
                Console.WriteLine(pd);
                totalPris += pd.pris;
                totalVikt += pd.vikt;
            }

            Console.WriteLine("Totalpris: " + totalPris + "\ttotalVikt: " + totalVikt) ;

        }
    }
}
