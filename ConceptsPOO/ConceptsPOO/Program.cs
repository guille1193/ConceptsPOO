// See https://aka.ms/new-console-template for more information



using ConceptsPOO;

Console.WriteLine("CONCEPTS POO");
Console.WriteLine("============");
Employee employee1 = new SalaryEmployee()
{
    Id = 2345,
    FirtName = "Guillermo",
    LastName = "Delgado",
    BirthDate = new Date(1993, 11, 11),
    HiringDate = new Date(2019, 03, 14),
    IsActive = true,
    Salary = 34025.15m
};

//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2346,
    FirtName = "Yesenia",
    LastName = "Contreras",
    BirthDate = new Date(1998, 11, 10),
    HiringDate = new Date(2020, 12, 14),
    IsActive = true,
    Sales = 25850m,
    CommissionPercentaje=0.05f
    
};

//Console.WriteLine(employee2);
Employee employee3 = new HourlyEmployee()
{
    Id = 2347,
    FirtName = "Juana",
    LastName = "Jorge",
    BirthDate = new Date(1978, 3, 5),
    HiringDate = new Date(2012, 12, 4),
    IsActive = true,
    HourValue = 12856.25m,
    Hour = 123.5f

};

//Console.WriteLine(employee3);
Employee employee4 = new BaseCommissionEmployee()
{
    Id = 2348,
    FirtName = "Nelson",
    LastName = "Dominguez",
    BirthDate = new Date(1978, 3, 5),
    HiringDate = new Date(2012, 12, 4),
    IsActive = true,
    Base = 8650m,
    Sales =7658.98m,
    CommissionPercentaje = 0.015f,


};

//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll+=employee.GetValueToPay();
}

Console.WriteLine("                                =================");
Console.WriteLine($"TOTAL                          {$"{payroll:c2}", 18}");

Invoice Invoice1 = new Invoice()
{
    Description = "I Phone 13",
    Id = 1,
    Price = 80000M,
    Quantity = 6
};
Invoice Invoice2 = new Invoice()
{
    Description = "Arena Gruesa",
    Id = 2,
    Price = 1050M,
    Quantity = 20
};
Console.WriteLine(Invoice1);
Console.WriteLine(Invoice2);





