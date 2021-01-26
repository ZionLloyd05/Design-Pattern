using Services.Creational.Factories.FactoryMethod.Managers;
using Services.Creational.Interface;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creational.Factories.FactoryMethod.ConcreteFactories
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
