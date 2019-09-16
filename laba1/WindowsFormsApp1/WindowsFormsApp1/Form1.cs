using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        double first = 0, second = 0, endResult = 0;
        char oper = ' ';

        private void button10_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(textBox1.Text);
            if(second==0 && oper=='/')
            {
                try
                {
                    throw new Exception("Делить на нуль нельзя");
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            switch (oper)
            {
                case '+':endResult = first + second;break;
                case '-': endResult = first - second; break;
                case 'x': endResult = first * second; break;
                case '/': endResult = first / second; break;
            }

            textBox1.Text = endResult.ToString();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            first = 0;
            second = 0;
            endResult = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                if(textBox1.Text[0]=='-')
                {
                    textBox1.Text = textBox1.Text.Remove(0,1);
                }
                else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                try
                {
                    throw new Exception("Нет операторов");
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                textBox1.Text =  textBox1.Text.Remove(textBox1.Text.Length-1, 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            using (StreamWriter a = new StreamWriter("D:\\calc.txt"))
            {
                a.WriteLine(endResult);
                a.Close();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            using (StreamReader a = new StreamReader("D:\\calc.txt"))
            {
           
                endResult=Convert.ToDouble(a.ReadLine());
                a.Close();
                textBox1.Text = endResult.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            oper = (sender as Button).Text[0];
            textBox1.Clear();

        }

       
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

    }
}
