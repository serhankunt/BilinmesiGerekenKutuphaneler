using SOLID.OCPGood;
//Bad Way
//SalaryCalculator salaryCalculator = new SalaryCalculator();
//Console.WriteLine($"Low Salary: { salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Middle Salary: { salaryCalculator.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"High Salary: { salaryCalculator.Calculate(1000, SalaryType.High)}");

//Good Way

SalaryCalculator salaryCalculator = new SalaryCalculator();
Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(10000, new LowSalaryCalculate())}");
Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(10000, new MiddleSalaryCalculate())}");
Console.WriteLine($"High Salary: {salaryCalculator.Calculate(10000, new HighSalaryCalculate())}");
