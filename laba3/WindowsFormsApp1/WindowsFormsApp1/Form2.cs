using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 first;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 a)
        {
            InitializeComponent();
            this.first = a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            first.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Не выбрано значение");
            }
            else
            {
                textBox1.Clear();
                var deserializeUsers = XmlSerializeWrapper.Deserialize<List<Student>>("student.xml");
                foreach(Student a in deserializeUsers)
                {
                    if(a.Specialty.ToUpper()==comboBox1.SelectedItem.ToString().ToUpper())
                    {
                        textBox1.Text+=Environment.NewLine+ "ФИО: " + a.FIO + Environment.NewLine + "Специальность: " + a.Specialty + Environment.NewLine + "Пол: " + a.gender + Environment.NewLine + " Группа" + a.group + Environment.NewLine;
                    }
                }
            }
        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Looking_Click(object sender, EventArgs e)
        {
            Regex patter = new Regex(@"\D*");
            if (patter.IsMatch(FIO.Text) == true)
            {
                FIO.BackColor = Color.White;
                var deserializeUsers = XmlSerializeWrapper.Deserialize<List<Student>>("student.xml");
                foreach (Student a in deserializeUsers)
                {
                    if(a.FIO.ToUpper()==FIO.Text.ToUpper())
                    {
                        textBox1.Text += "ФИО: " + a.FIO + Environment.NewLine + "Специальность: " + a.Specialty + Environment.NewLine + "Пол: " + a.gender + Environment.NewLine + " Группа" + a.group + Environment.NewLine;
                    }
                    else
                    {
                        int index=0;
                        int endOfName=0;
                        for(int i =0;i<FIO.Text.Length;i++)
                        {
                            if (endOfName == 1 && FIO.Text[i] == ' ')
                            {
                                endOfName = i - 1;
                                break;
                            }
                            if (FIO.Text[i] == ' ' && endOfName==0)
                            {
                                index = i+1;
                                endOfName++;
                            }
                            
                        }
                        int Length = endOfName - index;
                        Regex findWord = new Regex(@"^" + FIO.Text.Substring(0,2)+@"\D*", RegexOptions.IgnoreCase);
                        MatchCollection match = findWord.Matches(a.FIO);
                        if (findWord.IsMatch(a.FIO))
                        {
                            textBox1.Text += "Не удалось найти студента, но есть похожие варианты:" + Environment.NewLine;
                            foreach (Match stud in match)
                            {
                                textBox1.Text += stud.Value + Environment.NewLine;

                            }
                            textBox1.Text += "////////////////////////"+Environment.NewLine;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Не соотвествует формату ФИО");
                FIO.BackColor = Color.OrangeRed;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void поФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regex patter = new Regex(@"[1-9]");
            if (patter.IsMatch(textBox2.Text.ToString()))
            {
                textBox2.BackColor = Color.White;
                int value = Convert.ToInt32(textBox2.Text);
                var deserializeUsers = XmlSerializeWrapper.Deserialize<List<Student>>("student.xml");
                Regex parttern = new Regex($@"[{value}-9]");
                
                foreach(Student a in deserializeUsers)
                {

                    if(parttern.IsMatch(a.averageMark.ToString()))
                    {
                        textBox1.Text += Environment.NewLine+"ФИО: "+a.FIO+ Environment.NewLine+"Оценка: "+a.averageMark;
                         
                    }
                }
            }
            else
            {
                MessageBox.Show("Выход за пределы допустимого диапазона");
                textBox2.BackColor = Color.OrangeRed;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрано значение");
            }
            else
            {
                textBox1.Clear();
                var deserializeUsers = XmlSerializeWrapper.Deserialize<List<Student>>("student.xml");
                foreach (Student a in deserializeUsers)
                {
                    if (comboBox2.Text.ToString()==a.course.ToString())
                    {
                        textBox1.Text += Environment.NewLine + "ФИО: " + a.FIO + Environment.NewLine + "Специальность: " + a.Specialty + Environment.NewLine + "Пол: " + a.gender + Environment.NewLine + " Группа" + a.group + Environment.NewLine;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            XDocument xdoc = XDocument.Load("student.xml");
            var list = from elem in xdoc.Element("ArrayOfStudent").Elements("Student")
                       orderby Convert.ToInt32(elem.Element("age").Value)
                       select elem;

                       
            foreach (var elem in list)
            {
                textBox1.Text += elem.Element("FIO").Value + " " + elem.Element("Specialty").Value + " " + elem.Element("group").Value+" " + elem.Element("averagemark").Value+ Environment.NewLine;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            XDocument xdoc = XDocument.Load("student.xml");
            var list = from elem in xdoc.Element("ArrayOfStudent").Elements("Student")
                       orderby Convert.ToInt32(elem.Element("averagemark").Value)
                       select elem;


            foreach (var elem in list)
            {
                textBox1.Text += elem.Element("FIO").Value + " " + elem.Element("Specialty").Value + " " + elem.Element("group").Value +" "+ elem.Element("averagemark").Value+Environment.NewLine;
            }
            if(sender is Button)
            {
                Button button6 = (Button)sender;
                if(button6.Name=="button6")
                {
                    foreach (var elem in list)
                    {
                        XmlSerializeWrapper.Serialize<XElement>(elem, "sortstud.xml");
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
