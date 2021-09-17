using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        void employeeEkle()
        {
            EmployeeProcessor e = new EmployeeProcessor();
            e.InsertEmployee(new Employee
                {
                    Id = 5,
                    FirstName = "Ali",
                    LastName = "Veli",
                    BirthDate = DateTime.Now
                }
            );
        }
    }
}
