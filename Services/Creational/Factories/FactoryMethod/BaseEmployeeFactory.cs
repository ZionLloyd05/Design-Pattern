using Services.Creational.Interface;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creational.Factories.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp) =>
            _emp = emp;

        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
            return _emp;
        }

        public abstract IEmployeeManager Create();
    }
}
