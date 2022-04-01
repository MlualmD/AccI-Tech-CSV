using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV_Write_Read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppendToCSV();
            ReadCSVFile();

            Console.ReadLine();
        }
        static void ReadCSVFile()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\מולועלם דפרשה\Desktop\traningC#\AccI-Tech-CSV\CSV_Write_Read\Contact.csv");



            foreach (var line in lines)
            {
                var value = line.Split(',');

                var list = new List<Contact>();

                 if(value.Length == 2)
                {
                    var c = new Contact()
                    {
                        Name = value[0],
                        Phone = value[1],
                    };

                    list.Add(c);
                }
                list.ForEach(x => { Console.WriteLine($"{x.Name}\t{x.Phone}"); });
            }
        }
        static void AppendToCSV()
        {
            var list = Contacts.GetContacts();
            foreach (var c in list)
            {
                File.AppendAllText(@"C:\Users\מולועלם דפרשה\Desktop\traningC#\AccI-Tech-CSV\CSV_Write_Read\Contact.csv", $"{c.Name},{c.Phone}\n");
            }
        }
    }
    public class Contact
    {
        public string Name { get; set; }

        public string Phone { get; set; }
    }

    public class Contacts
    {
        public static List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact { Name ="joni", Phone ="355-69-555"},
                new Contact { Name ="mair", Phone ="26-985-99"},
                new Contact { Name ="mosha", Phone ="3245-69-555"},
            };
        }
    }
}
