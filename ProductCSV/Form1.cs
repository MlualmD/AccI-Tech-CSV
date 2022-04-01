using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numFiles =int.Parse(textBox3.Text);
            string aLotFile = textBox1.Text;
            CreateFileRandom createFile = new CreateFileRandom();
            createFile.CreateBulkFiles(numFiles, aLotFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameFolder= textBox2.Text;
            ReadCSVFiles readCSV = new ReadCSVFiles();
            readCSV.ScanAndReadAllFiles(nameFolder);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nameFolder = textBox2.Text;
            ReadCSVFiles readCSV = new ReadCSVFiles();
            readCSV.AllFliesInHashtable(nameFolder);
        }
    }
}
