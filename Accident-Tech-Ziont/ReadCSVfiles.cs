using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accident_Tech_Ziont
{
    public class ReadCSVfiles
    {
        public ReadCSVfile readCSVfile;

        
        public void ReadAllFiles(string folder)
        {
          
           string [] lines = Directory.GetFiles(folder);

            for (int i = 0; i < lines.Length; i++) 
            {
                readCSVfile = new ReadCSVfile(lines[i]);

               string [] line =  readCSVfile.Read();
               
            }
           
        }

    }
}
