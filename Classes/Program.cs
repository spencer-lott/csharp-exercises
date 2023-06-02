using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company Guardians = new Company();
            Guardians.Name ="Guardians, Inc";

            // Create three employees
            Employee Gamorrah = new Employee();
            Gamorrah.FirstName = "Gamorrah";
            Gamorrah.LastName = "Thanos";
            Gamorrah.Title = "Outlaw";
            Gamorrah.StartDate = new DateTime(1988, 2, 18);

            Employee Groot = new Employee();
            Groot.FirstName = "Groot";
            Groot.LastName = "Tree";
            Groot.Title = "Pilot";
            Groot.StartDate = new DateTime(1989, 4, 23);

            Employee Rocket = new Employee();
            Rocket.FirstName = "Rocket";
            Rocket.LastName = "Raccoon";
            Rocket.Title = "Pet";
            Rocket.StartDate = new DateTime(1989, 3, 31);
            // Assign the employees to the company

            void ListEmployees()
            {
                Console.WriteLine($"{Gamorrah.FirstName}{Gamorrah.LastName} works for {Guardians.Name} as a {Gamorrah.Title} since {Gamorrah.StartDate}");
                Console.WriteLine($"{Groot.FirstName}{Groot.LastName} works for {Guardians.Name} as a {Groot.Title} since {Groot.StartDate}");
                Console.WriteLine($"{Rocket.FirstName}{Rocket.LastName} works for {Guardians.Name} as a {Rocket.Title} since {Rocket.StartDate}");
            }
            ListEmployees();
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            Guardians.AddEmployee(Gamorrah);
            Guardians.AddEmployee(Groot);
            Guardians.AddEmployee(Rocket);
            
        }
    }
}