using System;
namespace inl_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool körprogram = true;

            while (körprogram)
            {
                Console.WriteLine("välj ett av följande alternativ:");
                Console.WriteLine("1. subtrahera ett tal med ett annat");
                Console.WriteLine("2. dividera ett tal med ett annat");
                Console.WriteLine("3. avsluta programet");

                int val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        Console.WriteLine("skriv in första talet:");
                        double tal1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("skriv in andra talet");
                        double tal2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"resultat: {tal1 - tal2}");
                        break;
                        
                    case 2:
                        Console.WriteLine("skriv in första talet:");
                        tal1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("skirv in andra talet");
                        tal2 = double.Parse(Console.ReadLine());

                        if (tal2 != 0)
                        {
                            Console.WriteLine($"resulat: {tal1/tal2}");
                        }
                        else
                        {
                            Console.WriteLine("division med noll är inte tillåten.");
                        }
                        break;

                    case 3:
                        körprogram = false;
                        break;

                    default:
                        Console.WriteLine("ogiltigt val, försök igen.");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}