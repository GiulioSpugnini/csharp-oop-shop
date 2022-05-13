using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int code;
        private string name;
        private string description;
        private double price;
        private double iva;

        public Prodotto(string name, string description, double price, double iva)
        {
            code = getCodice();
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = iva;
        }

        public double getPriceWithIva()
        {
            return price + (price / 100 * iva);
        }

        public double getPrice()
        {
            return price;
        }

        public string? getName()
        {
            return name;
        }
        public string? setName(string name)
        {
            return this.name = name;
        }
        public string getFullName()
        {
            return code.ToString() + name;
        }

        public static int getCodice()
        {
            Random code = new Random();
            return code.Next();
        }

        internal string getDescription()
        {
            return description;
        }
    }
}
