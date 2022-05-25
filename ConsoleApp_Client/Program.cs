using EmployeeService;
using System;

namespace ConsoleApp_Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmployeeServiceClient client = new EmployeeServiceClient();
            var employees = client.GetEmployees();
            foreach(var emp in employees)
            {
                Console.WriteLine($"employe: {emp.FirstName} - {emp.LastName}");
            }
            Console.WriteLine("press any key");
            Console.ReadLine();
        }
    }
}
