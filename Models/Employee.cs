using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace azureDbSalary.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public string PayBand { get; set; }
        public double BasicSalary { get; set; }
    }
}
