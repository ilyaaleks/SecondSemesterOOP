using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializeWrapper.Serialize(students, "student.xml");
            
        }

        private void textout_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime now = new DateTime();
            DateTime now1 = new DateTime();
            DateTime now2 = new DateTime();
            now = DateTime.Now;
            now1 = dateTime.Value;
            TimeSpan span = new TimeSpan();
            span = now - now1;
            string value1 = LastName.Text + " " + Name.Text + " " + SecondName.Text;
            string spec = "";
            spec = Specialist.SelectedItem.ToString();
            now2 = dateTime.Value;
            int kurs = Convert.ToInt32(Kurs.SelectedItem.ToString());
            int group = Convert.ToInt32(Group.Text);
            int bal = Convert.ToInt32(Bal.Text);
            string gender1 = gender.SelectedItem.ToString();
            Address adr1 = new Address(adr.Text);
            string dop1 = dop.Text;
            Student student = new Student(value1, span, spec, now2, kurs, group, bal, gender1, adr1, dop1);
            students.Add(student);
    foreach (Control ctrl in Controls)
            {
                if(ctrl is Button || ctrl is Label)
                {
                    continue;
                }
                ctrl.ResetText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deserializeUsers = XmlSerializeWrapper.Deserialize<List<Student>>("student.xml");
            foreach (Student a in deserializeUsers)
            {
                textout.Text += "ФИО: " + a.FIO + Environment.NewLine + "Дата рождения: " + a.DateOFBirthdat.ToLongDateString() + Environment.NewLine + "Курс " + a.course + Environment.NewLine + "Пол " + a.gender + Environment.NewLine + "Специальность " + a.Specialty + Environment.NewLine+"/////////////////"+Environment.NewLine; 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
