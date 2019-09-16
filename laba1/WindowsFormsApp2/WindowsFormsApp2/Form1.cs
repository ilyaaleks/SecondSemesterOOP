using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int sizeOfStud = 0;
        List<Student> stud;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sizeOfStud = Convert.ToInt32( textBox1.Text);
            textBox1.Enabled = false;
            button2.Enabled = false;
            stud = new List<Student>(sizeOfStud);
            RandString randString = new RandString();
            Random rand = new Random();
            for (int i=0;i<sizeOfStud;i++)
            {
                stud.Add(new Student(randString.RandomString(8),rand.Next(10)));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stud.Sort();

            listBox1.Items.Clear();
            for (int i = 0; i < sizeOfStud; i++)
            {
                listBox1.Items.Add("Имя "+stud[i].Name+" Оценка " +stud[i].Mark);
            }
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stud.Sort();

            listBox1.Items.Clear();
            for (int i = sizeOfStud-1; i >= 0; i--)
            {
                listBox1.Items.Add("Имя " + stud[i].Name + " Оценка " + stud[i].Mark);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int min = stud.Min(n => n.Mark);
            listBox2.Items.Clear();
            listBox2.Items.Add(min);
            listBox1.Items.Clear();
            var namesOfStud = stud.Where(n => n.Mark == min).Select(n => n.Name);
            foreach (string a in namesOfStud)
                listBox1.Items.Add(a);
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            int max = stud.Max(n => n.Mark);
            listBox2.Items.Clear();
            listBox2.Items.Add(max);
            listBox1.Items.Clear();
            var namesOfStud = stud.Where(n => n.Mark == max).Select(n => n.Name);
            foreach(string a in namesOfStud)
            listBox1.Items.Add(a);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var max = stud.Where(n => n.Mark >= 8 && n.Mark <= 9).Select(n => n);
            listBox2.Items.Clear();
            foreach (var a in max)
                listBox2.Items.Add(a.Mark);

            listBox1.Items.Clear();
      
            foreach (var a in max)
                listBox1.Items.Add(a.Name);
        }
    }
}
