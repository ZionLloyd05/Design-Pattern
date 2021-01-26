
using Services.Creational.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creational.Factories.SimpleFactory.Concrete
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 500;
        }

        public decimal GetPay()
        {
            return 1000;
        }
    }
}
