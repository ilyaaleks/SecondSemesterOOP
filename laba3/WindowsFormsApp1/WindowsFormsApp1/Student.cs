using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    [Serializable]
   public class Student
    {
        public Student()
        {

        }
        [XmlElement(ElementName = "FIO")]
        public string FIO;
        [XmlElement(ElementName = "age")]
        public int age;
        [XmlElement(ElementName = "Specialty")]
        public string Specialty;
        [XmlElement(ElementName = "DateofBirthday")]
        public DateTime DateOFBirthdat;
        [XmlElement(ElementName = "course")]
        public int course;
        [XmlElement(ElementName = "group")]
        public int group;
        [XmlElement(ElementName = "averagemark")]
        public int averageMark;
        [XmlElement(ElementName = "gender")]
        public string gender;
        [XmlElement(ElementName = "adress")]
        public Address address;
        [XmlElement(ElementName = "dopinfo")]
        public string dopinfo;
       

        public Student(
        string FIO,
        TimeSpan age,
        string Specialty,
        DateTime DateOFBirthdat,
        int course,
        int group,
        int averageMark,
        string gender,
        
        Address address,
        string dopinfo)
        {
            
            this.FIO = FIO;
            this.age = age.Days;
            this.Specialty = Specialty;
            this.DateOFBirthdat = DateOFBirthdat;
            this.course = course;
            this.group = group;
            this.averageMark = averageMark;
            this.gender = gender;
            this.address = address;
            this.dopinfo = dopinfo;
        }
    }
}
