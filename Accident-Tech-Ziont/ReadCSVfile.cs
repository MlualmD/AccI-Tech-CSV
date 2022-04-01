using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident_Tech_Ziont
{
    public class ReadCSVfile
    {
        string fileName;
        public ReadCSVfile(string fname)
        {
            this.fileName = fname;

        }

        public string [] Read()
        {
            string [] allFile = File.ReadAllLines(fileName);

            return allFile;
        }
    }
}
