using Services.Creational.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creational.Factories.SimpleFactory.Concrete
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 600;
        }

        public decimal GetPay()
        {
            return 1400;
        }
    }
}
