using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCSV
{
    public static class DataBank
    {
        static bool AlreadyInit = false;

        static string [] NameRandom;

        public static void Init()
        {
            NameRandom = new string[4];

            NameRandom[0] = "mulu";
            NameRandom[1] = "maiden";
            NameRandom[2] = "yosef";
            NameRandom[3] = "mosha";

            AlreadyInit = true;
        }

        public static string GetName()
        {
            if (!AlreadyInit)
            {
                Init();
            }
             Random r = new Random();
             int num = r.Next(0, NameRandom.Length - 1);
             string name = NameRandom[num];
             return name;

        }
    }
}
