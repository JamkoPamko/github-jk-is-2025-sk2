using System.Diagnostics;
using System.Runtime.ExceptionServices;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jakub Kubový *****************");
    Console.WriteLine("************** 13.10.2025 ******************");
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
        for (int j = 0; j < first; j++)
        {
            if (i == 0 || j == 0 || i%2 == 0 || j%2 == 0)

            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }



        }
        
        
        
        
        Console.WriteLine();
    }




 Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}