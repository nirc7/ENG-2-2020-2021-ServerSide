using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string inputFile = @"../../file1.txt";
        string studentData = @"studentData.txt";
        List<Student> sl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnWrite2File_Click(object sender, EventArgs e)
        {
            //File.WriteAllText( "../../file1.txt" , "Hello World!");
            File.AppendAllText(inputFile, "Hello World!\n");
        }

        private void btnReadFF_Click(object sender, EventArgs e)
        {
            string input = File.ReadAllText(inputFile);
            lblRes.Text = input;
        }

        private void btnLines_Click(object sender, EventArgs e)
        {
            lblRes.Text = "";
            int counter = 1;
            string[] lines = File.ReadAllLines(inputFile);
            foreach (var line in lines)
            {
                lblRes.Text += counter++ + ". " + line + "\n";
            }
        }

        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            File.AppendAllText(studentData,
                txtName.Text + "," + new Random().Next(60, 101) + "\n");
        }

        private void btnGetAllStudnets_Click(object sender, EventArgs e)
        {
            sl = new List<Student>();
            foreach (var line in File.ReadAllLines(studentData))
            {
                string[] inputs = line.Split(',');
                sl.Add(new Student() { Name = inputs[0], Grade = int.Parse(inputs[1]) });
            }
            ShowStudnets();
            ShowAvg();
        }

        private void ShowAvg()
        {
            lblStudnets.Text += "\n\n" + sl.Sum(st => st.Grade) / sl.Count;
        }

        private void ShowStudnets()
        {
            lblStudnets.Text = "";
            foreach (var st in sl)
            {
                lblStudnets.Text += st + "\n";
            }
        }
    }
}
