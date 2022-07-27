using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;




namespace Day3.Models
{
    public class Employee
    {
        [Key]
        public int EmpNo { get; set; }
        public string Name { get; set; }

        public string Job { get; set; }

        
        public int Salary { get; set; }

        public int Depno { get; set; }
    }

    
}
