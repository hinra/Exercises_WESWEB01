using System;
using System.Collections.Generic;
using System.Text;

namespace OmKlasser
{
    internal class Kund
    {
        /// <summary>
        /// Ett unikt namn för varje kund. Borde innehåller 8 tecken. 
        /// </summary>
        public string username;
        public string password;
        public string realname;
        public string language;

       public  int age;
       public int credit;
       public  List<string> items;



        public string TilltalLocal()
        {
            string svar = "ej definerad";

            switch(language)
            {
                case "de": svar = "Guten Morgen " + realname; break;
                case "se": svar = "Välkommen " + realname; break;
                case "es": svar = "Holá " + realname; break;
                default: svar = "Hello " + realname; break;
            }
            return svar; 
        }


        public Kund(string uname)
        {
            // Kod som kollar tillgänglighet.
            //...
            username = uname;
        }

        public Kund() { }

        public override string ToString()
        {
            return realname + "( " + username + " )";
        }

    } // End of class Kund
}
