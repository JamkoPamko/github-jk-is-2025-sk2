using System.Diagnostics;
using System.Runtime.ExceptionServices;

string again = "a";
while (again == "a")
{
    Console.Clear();
    //metoda pro výpis hlavičky razítka
    razitko();
    ulong a = nactiCislo("Zadejte číslo a: ");
    ulong b = nactiCislo("Zadejte číslo b: ");

    ulong nsd = vypocitatNSD(a, b);
    
    zobrazitvysledek(a, b, nsd);



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}



static void razitko()
{
    Console.WriteLine("********************************************");
    Console.WriteLine("**************** NSD a NSN *****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jakub Kubový *****************");
    Console.WriteLine("************** 11.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


}


static ulong nactiCislo(string zprava) {
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte vstup znovu: ");
    }

    return cislo;

}

static ulong vypocitatNSD(ulong a, ulong b)
{
    while(a != b)
    {
        if (a > b)
            a = a - b;
        else
            b = b - a;

    }




    return a;
}

static void zobrazitvysledek(ulong a, ulong b, ulong nsd, ulong nsn)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine();
    Console.WriteLine("========================");
    Console.WriteLine($"NSD čísel {a} a {b} je {nsd}");
    Console.WriteLine("========================");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
     Console.WriteLine($"NSD čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.White;
}

static ulong vypocitatNSD(ulong a, ulong b, ulong nsd)
{
    return(a*b/nsd)
}