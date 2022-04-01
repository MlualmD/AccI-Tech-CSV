using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accident_Tech_Ziont
{
    public class NumbersFileCSV
    {
        string fileName;

        public NumbersFileCSV(string fname)
        {
            this.fileName = fname;
        }

        public void Create(int linesCount)
        {
            string [] contents = new string[linesCount];

            Random random = new Random();

            for (int i = 0; i < contents.Length; i++)
            {
                contents[i] = random.Next(1, 999).ToString();
            }

            File.WriteAllLines(fileName, contents);
        }
    }
}
