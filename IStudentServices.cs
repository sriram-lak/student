using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal interface IStudentServices
    {
        void AddNewStudent(Student student);
        void EditStudentDetail(int id);
        void DeleteStudentDetail(int id);
        List<Student> GetAllStudents();
        int GetStudentId();
        
    }
}
