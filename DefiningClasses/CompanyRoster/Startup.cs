using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class Startup
    {
        public static void Main()
        {
            var employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var position = input[2];
                var depatment = input[3];

                Employee employee = new Employee(name, salary, position, depatment);

                if (input.Length == 5)
                {
                    if (int.TryParse(input[4], out int result))
                    {
                        employee.Age = result;
                    }
                    else
                    {
                        employee.Email = input[4];
                    }
                }
                else if (input.Length == 6)
                {
                    if (int.TryParse(input[4], out int result))
                    {
                        employee.Age = result;
                        employee.Email = input[5];
                    }
                    else
                    {
                        employee.Age = int.Parse(input[5]);
                        employee.Email = input[4];
                    }
                }

                employees.Add(employee);
            }

            var topDepartment = employees
                .GroupBy(x => x.Department)
                .ToDictionary(y => y.Key, s => s.Select(f => f))
                .OrderByDescending(x => x.Value.Average(y => y.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (var item in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2} {item.Email} {item.Age}");
            }
        }
    }
}
