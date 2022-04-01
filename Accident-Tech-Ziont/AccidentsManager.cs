using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident_Tech_Ziont
{
    public class AccidentsManager
    {
        public Accidents accidents;

        public AccidentsManager()
        {
            string filePath = @"C:\Users\מולועלם דפרשה\Desktop\traningC#\AccI-Tech-CSV\Accident-Tech-Ziont\Data\2019.csv";
            accidents = new Accidents(filePath);

           
        }
    }
}
