using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accident_Tech_Ziont
{
    public class CreateThreeNumCSV
    {
        string fName;

        public ThreeNum [] Arraythree;

        string[] names = new string[4];
        

        public CreateThreeNumCSV(string fileName)
        {
            this.fName = fileName;

           
        }
        public void CreateThreeNumber()
        {
            names[0] = "mulu";
            names[1] = "yosef";
            names[2] = "simcha";
            names[3] = "zion";
            string[] lines = new string[2];
          
            Random random = new Random();

            string[] arr = new string[lines.Length];
             
            for (int i = 0; i < lines.Length; i++)
            {
              lines[i] =  random.Next(1, 999).ToString();
               int a =int.Parse(lines[i]);
              lines[i] = random.Next(1, 999).ToString();
               int b = int.Parse(lines[i]);
              lines[i] = random.Next(1, 999).ToString();
                int c = int.Parse(lines[i]);

              int num  = random.Next(1, 4);

               string  name = names[num];

                string newLine = string.Format("{0},{1},{2},{3},", a, b, c, name);
               
                arr[i] = newLine;

                File.WriteAllLines(fName, arr);
            }

           
        }

        public void Read()
        {
         string [] lines  = File.ReadAllLines(fName);

            Arraythree = new ThreeNum[lines.Length];
            ThreeNum num = new ThreeNum();
            for (int i = 0; i < lines.Length; i++)
            {
                string [] line = lines[i].Split(',');
                num.num1 = int.Parse(line[0]);
                num.num2 = int.Parse(line[1]);
                num.num3 = int.Parse(line[2]);

                Arraythree[i] = num;
            }
        }
    }
}
