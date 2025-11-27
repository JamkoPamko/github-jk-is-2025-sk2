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
    Console.WriteLine("************** 27. 11.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte desítkové číslo (přirozené číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte desítkové číslo (přirozené číslo) znovu: ");
    }

    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;
    uint zbytek;

    int i
    for(i = 0; number10 > 0;i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek)/2;
    
        myArray[i] = zbytek;

        Console.WriteLine("Celá část: {0}; Zbytek: {1}", number10, zbytek)
    }

    Console.WriteLine("Desítkové číslo {0} ve dvojkové soustavě = ", backupNumber10);
    for (uint j = i - 1; j>=0; j--)
    {
        Console.WriteLine("{0}")
    }






    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}