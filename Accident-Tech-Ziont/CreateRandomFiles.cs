using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident_Tech_Ziont
{
    public class CreateRandomFiles
    {
        

        public void Run(int linestNumber, string fName)
        {
            NumbersFileCSV NumbersFileCSV = new NumbersFileCSV(fName);
            NumbersFileCSV.Create(linestNumber);
        }
    }
}
