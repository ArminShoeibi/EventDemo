using System;

namespace EventDemo
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new();
            employee.BirthDate = DateTime.Now;
            var ea = employee.BirthDate;

            Console.ReadLine();
        }
    }
}
