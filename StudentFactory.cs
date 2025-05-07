using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class StudentFactory : IStudentFactory
    {
        private readonly InputHandler input;
        public StudentFactory(InputHandler input)
        {
            this.input = input;
        }

        public Student CreateStudent(int id)
        {
            return (new Student
            {
                Id = id,
                Name = input.NameChecker(),
                Age = input.AgeChecker(),
                Phone = input.PhoneChecker(),
                Standard = input.StandardChecker()
            });
        }
    }
}
