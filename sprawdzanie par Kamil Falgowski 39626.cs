using System;

namespace IloczynPary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kolekcja = { 2, 2, 3, 3, 9, 18 };
            int[] powtórka = PodajPowtórkęPary(kolekcja);

            if (powtórka[0] == -1)
                Console.WriteLine("Nie ma powtórki");
            else
                Console.WriteLine("Powtórka znaleziona na pozycjach: " + powtórka[0] + ", " + powtórka[1]);

            Console.ReadKey();
        }

        static int[] PodajPowtórkęPary(int[] kolekcja)
        {
            var słownik = new System.Collections.Generic.Dictionary<int, int>();
            int[] powtórka = { -1, -1 };

            for (int i = 0; i < kolekcja.Length - 1; i++)
            {
                int lewy = kolekcja[i];
                int prawy = kolekcja[i + 1];
                int iloczyn = lewy * prawy;

                if (słownik.ContainsKey(iloczyn))
                {
                    powtórka[0] = słownik[iloczyn];
                    powtórka[1] = i;
                    break;
                }
                else
                    słownik[iloczyn] = i;
            }
            return powtórka;
        }
    }
}
