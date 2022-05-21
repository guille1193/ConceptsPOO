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

Console.WriteLine(employee1);
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

Console.WriteLine(employee2);


