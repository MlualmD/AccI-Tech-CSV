using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCSV
{
    public class CreateFileRandom
    {
        public void Run(int countLines, string fName)
        {
            CreateNumberLines numberLines = new CreateNumberLines(fName); //create file name and random lines
            numberLines.CreateLines(countLines);                         // create lines in file
        }

        public void CreateBulkFiles(int CountFiles, string folder)  // create a lot files
        {
            Random random = new Random();

            for(int i = 0; i < CountFiles; i++)
            {
                string newFileName = $"{folder}{Guid.NewGuid()}.csv";
                Run(random.Next(10,200), newFileName);
            }
        }
    }
}
