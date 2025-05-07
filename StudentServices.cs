using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class StudentServices : IStudentServices
    {
        private static readonly List<Student> list = new List<Student>(); 
        private static int idGenerator = 0;
        public void AddNewStudent(Student student)
        {
            list.Add(student);
        }
        public int GetStudentId()
        {
            return idGenerator++;
        }
        public void GetAllStudent()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No Student record Found");
            }
            else
            {
                foreach (Student student in list)
                {
                    student.Display();
                }
            }
        }
        public void EditStudentDetail(int id)
        {

        }
        public void DeleteStudent(int id)
        {
            if()
        }
    }
}
