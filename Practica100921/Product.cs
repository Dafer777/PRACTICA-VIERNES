using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica100921
{
    class Product
    {
        // propiedades
        public int codProduct { get; set;  }
        public string productName { get; set; }
        
        public string productDescription { get; set; }
        
        public double buyPrice { get; set; }

        public string Category { get; set; }



        //Metodo para definir una coleccion de dato

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product{ codProduct=12001, productName="Coca Cola", productDescription="Bebida carbonatada, distribuida por ILC", buyPrice = 0.50d, Category = "Gaseosa" },
                new Product{ codProduct=12002, productName="Papas Lays", productDescription="Distribuido por sabritas", buyPrice = 0.30d, Category="Churros" },
                new Product{ codProduct=12003, productName="Galletas Pic Nic", productDescription="Distribuido por DIANA", buyPrice = 1.00d, Category="Galletas"},
                new Product{ codProduct=12004, productName="Jugo del valle Naranja", productDescription="Distribuido por ILC", buyPrice = 0.50d, Category="Jugo" },
                new Product{ codProduct=12005, productName="Galleta Florentina", productDescription="Distribuido por gamesa", buyPrice = 0.75d, Category="Galletas"}
            };

            return products; //retornamos la lista de productos
        }
    }
}
