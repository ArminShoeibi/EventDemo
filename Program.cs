using System;

namespace EventDemo
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new();
            employee.OnBirthDay += Employee_OnBirthDay;
            employee.BirthDate = DateTime.Now;

            Console.ReadLine();
        }

        private static void Employee_OnBirthDay(object sender, EventArgs e)
        {
            Console.WriteLine("Happy Birthday!");
        }
    }
}
