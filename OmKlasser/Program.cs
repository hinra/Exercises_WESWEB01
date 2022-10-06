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

            Produkt p = new Produkt() { pris = 1229.90, beteckning = "GeForce G1337GTX", tillverkare = "ASUS"};
            inköp.Add(p);
            p = new Produkt() { pris = 329, beteckning = "Musmatta", tillverkare = "DELL" };
            inköp.Add(p);
            p = new Produkt() { pris = 2099, beteckning = "ATX CHASSI Classic", tillverkare = "PishiMishi" };
            inköp.Add(p);

            foreach(Produkt pd in inköp)
            {
                Console.WriteLine(pd);
            }

        }
    }
}
