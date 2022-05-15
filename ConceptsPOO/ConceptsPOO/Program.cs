// See https://aka.ms/new-console-template for more information



using ConceptsPOO;

Console.WriteLine("CONCEPTS POO");
Console.WriteLine("============");
try
{
    Console.WriteLine(new Date(2022, 5, 1));
    Console.WriteLine(new Date(2005, 12, 31));
    Console.WriteLine(new Date(1970, 12, 14));
}
catch (Exception Error)
{
    Console.WriteLine(Error.Message);
}


