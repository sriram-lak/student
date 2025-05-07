using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student
    {
        private int _id;
        private string _name;
        private int _age;
        private string _phone;
        private string _standard;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Standard { get { return _standard; } set { _standard = value; } }

        public void Display()
        {
            Console.WriteLine($"Id - {Id}\tName - {Name}\tAge - {Age}\tPhone - {Phone}\tStandard - {Standard}");
        }
    }
}
