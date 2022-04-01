using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ProductCSV
{
    public class ReadCSVFiles
    {

        public void ScanAndReadAllFiles(string folder)
        {
            string[] lines = Directory.GetFiles(folder);// run for all Files in Directory.


            for (int i = 0; i < lines.Length; i++) // run for 4 files in for.
            {
                ReadCSVFile readCSVFile = new ReadCSVFile(lines[i]); // give for one string file. 

                //string [] file = readCSVFile.Load();      

                Product[] products = readCSVFile.LoadProducts();

            }
        }

        public Hashtable AllFliesInHashtable(string folder)
        {
            string[] fileNames = Directory.GetFiles(folder);// run for all Files in Directory.

            Hashtable ht = new Hashtable();

            for (int i = 0; i < fileNames.Length; i++) // run for 4 files in for.
            {
                ReadCSVFile readCSVFile = new ReadCSVFile(fileNames[i]); // give for one string file. 

                //string [] file = readCSVFile.Load();      

                Product[] products = readCSVFile.LoadProducts();

                ht.Add(fileNames[i], products);
            }
            return ht;
        }
    }
}
