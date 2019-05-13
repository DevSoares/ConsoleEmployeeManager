using System;
using System.Collections.Generic;
using ConsoleEmployeeManager.Entities;

namespace ConsoleEmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            byte trava = 1;
            while (trava != 0){

                List<Employee> employees = new List<Employee>();
                Console.Write("Enter the number of employees: ");
                int n = int.Parse(Console.ReadLine());
                                               
                

                for(int i = 1; i<=n; i++)
                {
                    Console.WriteLine($"Employee #{i} data:");
                    Console.Write("Outsourced (y/n): ");
                    string answer = Console.ReadLine();
                    answer.ToLower();

                    if(answer == "y")
                    {                        
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = int.Parse(Console.ReadLine());
                        Console.Write("Valeu per hour: ");
                        double valuePerHour = double.Parse(Console.ReadLine());
                        Console.Write("Additional charge: ");
                        double  additionalCharge = double.Parse(Console.ReadLine());
                        employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                    }
                    else
                    {
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = int.Parse(Console.ReadLine());
                        Console.Write("Valeu per hour: ");
                        double valuePerHour = double.Parse(Console.ReadLine());
                        employees.Add(new Employee(name, hours, valuePerHour));
                    }              
                }

                Console.WriteLine("\nPAYMENTS:");
                foreach(Employee employee in employees)
                {
                    Console.WriteLine(employee);
                }


                Console.WriteLine("\nType 0 to quit program...");
                trava = byte.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
