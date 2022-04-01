using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Accident_Tech_Ziont
{
    public class Accidents
    {
        Hashtable hashtable = new Hashtable();

        public Accident[] Arr;

        public string [] FileldNames;

        public string filePath;

        public Accidents()
        {

        }

        public Accidents(string aFilePath)
        {
            this.filePath = aFilePath;

            Load(filePath);
        }
      
        public void Load(string filePath)
        {
           string [] Lines = File.ReadAllLines(filePath);

            Arr = new Accident[Lines.Length];

            FileldNames = Lines[0].Split(',');

            for (int i = 1; i < Lines.Length; i++)
            {
                string[] Line = Lines[i].Split(',');
                Accident accident = new Accident()
                {
                    id = long.Parse(Line[FieldNameToNumber("pk_teuna_fikt")]),
                    SugDerech = Line[FieldNameToNumber("SUG_DEREH")],
                    SugTeuna = Line[FieldNameToNumber("SUG_TEUNA")],
                    Tkinut = byte.Parse(Line[FieldNameToNumber("TKINUT")])
                };

                Arr[i -1] = accident;

                hashtable.Add(accident.id, accident);

            }
        }

        public string GetSugDerechByAccident(long id)
        {
            

           Accident acc = (Accident) hashtable[id];

            return acc.SugDerech;

            
        }
        public byte GetTkinutByAccidentId(long id)
        {
            byte ret = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if(Arr[i].id == id)
                {
                    return Arr[i].Tkinut;
                }
            }

            return ret;
        }

        public int FieldNameToNumber(string name)
        {
           string upper = name.ToUpper();

            for (int i = 0; i < FileldNames.Length; i++)
            {
                if (upper.Equals(FileldNames[i].ToUpper())){

                    return i;
                }
            }
            return -1; // Not Found Name Fields
        }

    }
}
