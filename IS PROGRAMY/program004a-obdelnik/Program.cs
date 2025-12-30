string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Vykreslení obdélníku *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jakub Kubový *****************");
    Console.WriteLine("************** 23.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte šířku obdélníka: "); //šířka
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdélníka znovu: ");
    }

   
   
   
    Console.Write("Zadejte výšku obdélníka: "); //výška
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníka znovu: ");
    }

    Console.WriteLine();

    for (int i = 1; i <= height ; i++) { //i je řádek
        for (int j = 1; j <= width; j++)  //j je sloupec
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150)); //pauza 150 ms mezi vykreslením jednotlivých hvězdiček
            /*if (i == 1 || i == height || j == width) //podmínka pro vykreslení obdélníka
            {
                Console.Write("* ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150));
            }
            else
            {
                Console.Write("  ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150));*/
        }
        Console.WriteLine();
    }    
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
