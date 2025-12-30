using System.Diagnostics;
using System.Net;
using System.Runtime.ExceptionServices;
using Microsoft.VisualBasic;

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
            
            //příkaz pro udělání X ve čtverci
            if (radek == first - 1 || radek == 0 || sloupec == 0 || sloupec == first -1 ||
            radek + sloupec == first -1 || radek == sloupec)
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