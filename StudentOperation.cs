using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class StudentOperation
    {
        private readonly IStudentFactory studentFactory;
        private readonly IStudentServices studentServices;

        public StudentOperation(IStudentServices studentServices, IStudentFactory studentFactory)
        {
            this.studentServices = studentServices;
            this.studentFactory = studentFactory;
        }
        public void Start() {
            bool isContinue = true;

            while(isContinue)
            {
                Console.WriteLine("\nPress 1 : Create Student\nPress 2 : List the Student\nPress 3 : Edit\nPress 4 : Delete\nPress 5 : Exit\n");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        var newStudent = studentFactory.CreateStudent(studentServices.GetStudentId());
                        studentServices.AddNewStudent(newStudent);
                        break;

                }
            }
        }
    }
}
