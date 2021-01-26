using Services.Creational.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creational.Factories.FactoryMethod.Managers
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

        public decimal GetMedicalAllowance()
        {
            return 900;
        }
    }
}
