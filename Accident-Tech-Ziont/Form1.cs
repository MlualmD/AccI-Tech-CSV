using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accident_Tech_Ziont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AccidentsManager M = new AccidentsManager();
        private void button1_Click(object sender, EventArgs e)
        {
            long id = long.Parse(textBox1.Text);
            label1.Text = M.accidents.GetTkinutByAccidentId(id).ToString();
            label2.Text = M.accidents.GetSugDerechByAccident(id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int linestNumber = int.Parse(textBox2.Text); 
            CreateRandomFiles randomFiles = new CreateRandomFiles();
            string nameFile = textBox3.Text;
            randomFiles.Run(linestNumber, nameFile);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           string fName = textBox3.Text;
            ReadCSVfile readCSVfile = new ReadCSVfile(fName);
            string [] lines = readCSVfile.Read();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadCSVfiles readCSVfiles = new ReadCSVfiles();
            string fName = textBox3.Text;
            readCSVfiles.ReadAllFiles(fName);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fName = textBox3.Text;
            CreateThreeNumCSV createThree = new CreateThreeNumCSV(fName);
            createThree.CreateThreeNumber();
        }
    }
}
