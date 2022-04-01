using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductCSV
{
    public class Product
    {
        public Product()
        {

        }

        public string id;

        public string name;

        public int price, quantity, tax;
        


       public static Product BuildFromCSVLine(string line)
        {
            Product product = new Product();

            string [] oneFiled = line.Split(',');  //Get a size 4 row and inserts a field

            product.id = oneFiled[0];
            product.price = int.Parse(oneFiled[1]);
            product.quantity = int.Parse(oneFiled[2]);
            product.tax = int.Parse(oneFiled[3]);
            product.name = oneFiled[4];

            return product;
        }
       
    }
}
