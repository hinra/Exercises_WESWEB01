using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OmKlasser
{
    internal class Produkt
    {
        public string beteckning, tillverkare, kategori;
        public double pris, vikt;



        public double PrisMedMoms(double moms) { 
        return pris* (1+ moms); 
            }

        public double PrisUtanMoms()
        {
            return pris; 
        }

        public override string ToString()
        {
            return beteckning + "Company: " + tillverkare + ", Pris: " + pris;
        }


    }
}
