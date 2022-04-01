using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductCSV
{
    public class ReadCSVFile
    {

        string fname;

        public ReadCSVFile(string fName)
        {
            this.fname = fName;
        }

        public string [] Load()
        {

          
            string[] ret;

            ret = File.ReadAllLines(fname);

            return ret;
        }

       public Product[] LoadProducts()
        {
            Product[] proArry; 

            string[] lines = Load(); //Get 4 lines and set num length in arry product

            proArry = new Product[lines.Length];

            for (int i = 0; i < proArry.Length; i++)
            {
                proArry[i] = Product.BuildFromCSVLine(lines[i]);// Runs Product one by one
            }

            return proArry;
        }
    }
}
