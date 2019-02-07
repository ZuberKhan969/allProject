using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int empid { get; set; }
        public string empName { get; set; }
        public string empAddress { get; set; }


    }
}