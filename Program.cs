using System;
 namespace StudentManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            InputHandler input = new InputHandler();
            IStudentFactory studentFactory = new StudentFactory(input);
            IStudentServices services = new StudentServices();

            StudentOperation operation = new StudentOperation(services,studentFactory);
            operation.Start();
        }
    }
}