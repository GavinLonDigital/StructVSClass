using System;

namespace StructVSClass
{
    public struct Employee //replace 'struct' keyword with 'class' keyword to test app with employee object derived from a class
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public decimal AnnualSalary;
        public char Gender;
        public bool IsManager;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //This app was created to
            //show one of the key differences between a class and a struct,
            //that being, a struct is a value type and a
            //class is a reference type

            Employee employee; //= new Employee(); //new Employee() //Include new Employee() when creating object from a class

            employee.Id = 1;
            employee.FirstName = "Devin";
            employee.LastName = "Smith";
            employee.AnnualSalary = 80000;
            employee.Gender = 'm';
            employee.IsManager = false;

            Console.WriteLine($"Annual salary before update: {employee.AnnualSalary}");

            UpdateAnnualSalary(employee);

            Console.WriteLine($"Annual salary after update: {employee.AnnualSalary}");

            Console.ReadKey(); //press any key to end app
        }

        public static void UpdateAnnualSalary(Employee employee)
        {
            employee.AnnualSalary = 100000;
        }

    }
}
