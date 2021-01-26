using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public decimal Bonus { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal HouseAllowance { get; set; }
        public decimal MedicalAllowance { get; set; }
    }

}