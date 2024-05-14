﻿namespace SOLID.OCPGood
{
    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }
    public class LowSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }
    public class MiddleSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }
    public class HighSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }
    public class ManagerSalaryCalculate : ISalaryCalculate{
        public decimal Calculate(decimal salary)
        {
            return salary * 10;
        }

    }

    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary, ISalaryCalculate salaryCalculate)
        {
            return salaryCalculate.Calculate(salary);
        }
    }
}
