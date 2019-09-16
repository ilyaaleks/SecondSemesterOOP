using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Student:IComparable
    {
        public int CompareTo(object second)
        {
            int secondmark = ((Student)second).Mark;
            return this.mark.CompareTo(secondmark);
        }
        string name;
        int mark;
        public Student(string name,int mark)
        {
            this.name = name;
            this.mark = mark;
        }
        public int Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
