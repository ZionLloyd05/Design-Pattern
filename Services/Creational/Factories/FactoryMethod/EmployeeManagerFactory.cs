using Services.Creational.Factories.FactoryMethod.ConcreteFactories;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creational.Factories.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory (Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if(emp.Id == 1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if(emp.Id == 2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }

            return returnValue;
        }
    }
}
