using System.Diagnostics;
using System.Runtime.ExceptionServices;

string again = "a";
while (again == "a")
{
    //Console.Clear();
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

    for (int radek = 0; radek < first; radek++)
    {
        for (int sloupec = 0; sloupec < first; sloupec++)
        {
            int mezera = 2;         // velikost jedné buňky
            int krok = mezera + 1;  // perioda mřížky

            if ()





        }
        
        
        
        
        Console.WriteLine();
    }




 Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}