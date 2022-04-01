using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductCSV
{
    public class CreateNumberLines
    {
         string fileName;

        public CreateNumberLines(string fname)
        {
            this.fileName = fname;
        }

        public void CreateLines(int countLines)
        {
            string[] lines = new string[countLines];

            Random random = new Random();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = $"{Guid.NewGuid()},{random.Next(1, 99)},{random.Next(1, 99)},{random.Next(1, 99)},{DataBank.GetName()},";
                lines[i] = line;
            }

            File.WriteAllLines(fileName, lines);
        }
    }
}
