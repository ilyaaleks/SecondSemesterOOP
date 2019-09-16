using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Student
    {
        public int id;
        public string FIO;
        public int age;
        public int Kurs;
        public int groups;
        public int aver_mark;
        public string pol;
        public string photo;
        public string city;
        public string CityIndex;
        public string Street;
        public int House;
        public string Apartment;

        public Student(int id, string fIO, int age, int kurs, int groups, int aver_mark, string pol, string photo, string city, string cityIndex, string street, int house, string apartment)
        {
            this.id = id;
            FIO = fIO;
            this.age = age;
            Kurs = kurs;
            this.groups = groups;
            this.aver_mark = aver_mark;
            this.pol = pol;
            this.photo = photo;
            this.city = city;
            CityIndex = cityIndex;
            Street = street;
            House = house;
            Apartment = apartment;
        }

    }
}
