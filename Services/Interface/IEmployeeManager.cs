using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creational.Interface
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
