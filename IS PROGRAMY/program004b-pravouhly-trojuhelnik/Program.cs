using System.Diagnostics;
using System.Runtime.ExceptionServices;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** pravoúhlý trojuhelník *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jakub Kubový *****************");
    Console.WriteLine("**************  ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {        
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    for (int i = 0; i < first; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("* ");
        }   
               
        
        Console.WriteLine();
    }





 Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}