using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_In_Interfaces
{
    internal class Employee : ICloneable, IComparable 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }
        public Employee()
        {
            
        }
        public Employee(Employee employeeCopy)
        {
            this.Id = employeeCopy.Id;  
            this.Name = employeeCopy.Name;
            this.Salary = employeeCopy.Salary;
            this.Department =(Department?) employeeCopy?.Department?.Clone();
        }
        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary,
                Department = (Department?) this.Department?.Clone(),
            };
        }

        public override string ToString()
        {
            return $"ID: {Id} , Name: {Name} , Salary: {Salary:c}";
        }

        public int CompareTo(object? obj)
        {
            Employee? other = (Employee?) obj;
            return -this.Salary.CompareTo(other?.Salary);
            //if (other is null)
            //    return 1 ;   
            //if (this.Salary > other?.Salary)
            //    return 1 ;
            //else if(this.Salary < other?.Salary)
            //    return -1 ;
            //else 
            //    return 0 ;

        }
    }
}
