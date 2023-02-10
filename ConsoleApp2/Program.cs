using System;
class Program
{
    static bool PrimtalsUndersökarn(int tal)
    {
        for (int i = tal-1; 1 < i; i--)
        {
            if (tal % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        Console.WriteLine("Skriv ett tal så undersöker vi om det är ett primtal");
        int tal = int.Parse(Console.ReadLine());
        if (PrimtalsUndersökarn(tal))
        {
            Console.WriteLine(tal + " är ett primtal");
        } 
        else
        {
            Console.WriteLine(tal + " är inte ett primtal");
        }
    }
}