using System;

namespace Classes
{
    public class Company
    {

        public string Name { get; set;}
        public DateTime CreatedOn { get; set;}
        public List<Employee> AllEmployees = new List<Employee>();

        public void AddEmployee(Employee singleEmployee)  
        {
            AllEmployees.Add(singleEmployee);
        }


//public data = property
//private data = field

    }
}