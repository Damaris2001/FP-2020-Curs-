using System;

namespace Probleme_POOL_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //NrPare();
            //NrNegZeroPoz();
            //SumasiProdus();
            // PozitieNr();
            //Nr_egale_cu_poz();
            //Ordine_crescatoare();
            //Min_Max();
            //Sir_Fibonacci();
            //Monotona();
            //Nr_consecutive();
            //Suma_inverselor();
            //Nr_consecutive_dif_de_zero();
            //Sec_cresc_rotita();
            //Sec_monotona_rotita();
            //Sec_bitonica();
            //Sec_bitonica_rotita();
            
        }


        private static void Sec_bitonica_rotita()
        { //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica
          //prin rotiri succesive (rotire = primul element devine ultimul).
          //Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
            int n, x, x1, x2;
            bool cresc = true;
            bool desc = true;
            bool rot = true;
            bool rotc = true;
            bool rotd = true;
            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti primul numar");
            x1 = int.Parse(Console.ReadLine());
            x2 = x1;
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());
                if (x1 > x)
                    cresc = false;
                if (x1 < x)
                    desc = false;
                if (!rotd && ((x1 < x) || (x2 > x)))
                    rot = false;
                if (!cresc && ((x1 < x) || (i == 1)))
                    rotc = false;
                if (!desc && x1 > x)
                    rotd = false;
                if (x2 < x && desc)
                    x2 = x;
                x1 = x;
            }
            if (rot || rotc || rotd)
                Console.WriteLine("Secventa este bitonica rotita");
            else
                Console.WriteLine("Secventa nu este bitonica rotita");
        }

        private static void Sec_bitonica()
        {//O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
         // De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
            int n, x, x1;
            bool cresc = true;
            bool bit = true;
            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti primul numar");
            x1 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());
                if (x1 > x)
                    cresc = false;
                if ((x1 < x || i == 1) && !cresc)
                    bit = false;
                x1 = x;
            }
            if (!cresc && bit)
                Console.WriteLine("Secventa este bitonica");
            else
                Console.WriteLine("Secventa nu este bitonica");
        }

        private static void Sec_monotona_rotita()
        {//O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.
         //Determinati daca o secventa de n numere este o secventa monotona rotita.
            int n, x, x1, x2, x3;
            bool cresc = true;
            bool desc = true;
            bool rotc = true;
            bool rotd = true;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti primul numar");
            x1 = int.Parse(Console.ReadLine());
            x2 = x1;
            x3 = x1;
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                x = int.Parse(Console.ReadLine());
                if (x1 > x)
                    cresc = false;
                if (x1 < x)
                    desc = false;
                if ((x1 > x || x2 < x) && !cresc)
                    rotc = false;
                if ((x1 < x || x3 > x) && !desc)
                    rotd = false;
                if (cresc && x2 > x)
                    x2 = x;
                if (desc && x3 < x)
                    x3 = x;
                    x1 = x;
            }
            if (cresc || desc || rotc || rotd)
                Console.WriteLine("Secventa este monotona rotita");
            else
                Console.WriteLine("Secventa nu este monoton rotita");
        }

        private static void Sec_cresc_rotita()
        {//O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata  intr-o secventa 
         //in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si 
         // primul element devine ultimul).Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int minim = a;
            bool crescatoare = true;
            int c = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    crescatoare = false;
                }
                if (a > b && minim > b)
                {
                    c++;
                }
                a = b;
            }
            if (crescatoare == true || c == 1)
                Console.WriteLine("Secventa este rotita crescatoare");
            else
                Console.WriteLine("Secventa nu este rotita crescatoare");
        }

        private static void Nr_consecutive_dif_de_zero()
        {//Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
         //Considerati fiecare astfel de grup ca fiind un cuvant, 
         //zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
            int n, a, g = 0, b = 0;
            Console.WriteLine("Cate numere are sirul?");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea numar");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                    b = 0;
                else
                {
                    if (b == 0)
                    {
                       g++;
                       b = 1;
                    }
                }
            }
            Console.WriteLine($"In aceasta secventa sunt {g} grupuri de numere diferite de 0");
        }

        private static void Suma_inverselor()
        {//Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int invers;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                invers = 0;
                while (a != 0)
                {
                    invers = invers * 10 + a % 10;
                    a = a / 10;
                }
                suma += invers;
            }
            Console.WriteLine(suma);
        }

        private static void Nr_consecutive()
        {//Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int ok = 1, maxim = 0; ;
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a == b)
                    ok++;
                else
                    ok = 1;
                if (ok >= maxim)
                    maxim = ok;
            }
            Console.WriteLine(maxim);
        }
            private static void Monotona()
            {//Sa se determine daca o secventa de n numere este monotona. 
             //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
                int n, a, b, d = 0, i = 1;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti numerele");
                a = int.Parse(Console.ReadLine());
                while (i < n)
                {
                    b = int.Parse(Console.ReadLine());
                    if (b > a)
                        if (d < 0)
                            d = 2;
                        else
                            d = 1;
                    else if (b < a)
                        if (d > 0)
                            d = 2;
                        else
                            d = -1;
                    a = b;
                    i++;
                }
                if (d < 2)
                    Console.WriteLine("Secventa este monotona.");
                else
                    Console.WriteLine("Secventa nu este monotona.");
            }

            private static void Sir_Fibonacci()
            {//Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).
             //Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
                int n, n1 = 1, n2 = 1, F = 0;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                for (int i = 2; i <= n; i++)
                {
                    F = n1 + n2;
                    n1 = n2;
                    n2 = F;
                }
                Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este {F}");
            }

            private static void Min_Max()
            {//Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
                int n, x, max, min;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                max = -int.MaxValue;
                min = Int32.MaxValue;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Introduceti al {i}-lea numar");
                    x = int.Parse(Console.ReadLine());
                    if (x > max)
                        max = x;
                    if (x < min)
                        min = x;
                }
                Console.WriteLine($"Cea mai mare valoare este {max} si cea mai mica este {min}");
            }

            private static void Ordine_crescatoare()
            {//Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
                int n, a, b, x = 1, cresc = 1;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti numerele");
                a = int.Parse(Console.ReadLine());
                while (x < n)
                {
                    b = int.Parse(Console.ReadLine());
                    if (b < a)
                        cresc = 0;
                    a = b;
                    x++;
                }
                if (cresc == 1)
                    Console.WriteLine("Numerele sunt in ordine crescatoare");
                else
                    Console.WriteLine("Numerele nu sunt in ordine crescatoare");
            }

            private static void Nr_egale_cu_poz()
            {//Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
             //Se considera ca primul element din secventa este pe pozitia 0.
                int n, x, contor = 0;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Introduceti al {i}-lea numar");
                    x = int.Parse(Console.ReadLine());
                    if (x == i)
                        contor++;
                }
                Console.WriteLine($"Sunt {contor} numere egale cu pozitia pe care apar in secventa");
            }

            private static void PozitieNr()
            {//Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
             //Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
                int n, y, x, i;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Introduceti numarul a carui pozitie vreti sa o aflati");
                y = int.Parse(Console.ReadLine());
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine($"Introduceti al {i}-lea numar");
                    x = int.Parse(Console.ReadLine());
                    y = x;
                    Console.WriteLine($"Numarul {x} se afla in pozitia {i}");
                    if (y != x)
                        Console.WriteLine("-1");
                }
            }

            private static void SumasiProdus()
            {//Calculati suma si produsul numerelor de la 1 la n. 
                int n, x, suma = 0, produs = 1;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Introduceti al {i}-lea numar");
                    x = int.Parse(Console.ReadLine());
                    suma = suma + x;
                    produs = produs * x;
                }
                Console.WriteLine($"Suma numerelor este {suma}");
                Console.WriteLine($"Produsul numerelor este {produs}");
            }

            private static void NrNegZeroPoz()
            {//Se da o secventa de n numere. Sa se determine cate sunt negative, cate sunt zero si cate sunt pozitive.
                int n, x, contor1 = 0, contor2 = 0, contor3 = 0;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Introduceti al {i}-lea numar");
                    x = int.Parse(Console.ReadLine());
                    if (x < 0)
                        contor1++;
                    if (x == 0)
                        contor2++;
                    if (x > 0)
                        contor3++;
                }
                Console.WriteLine($"Sunt {contor1} numere negative in aceasta secventa de numere");
                Console.WriteLine($"Sunt {contor2} zerouri in aceasta secventa de numere");
                Console.WriteLine($"Sunt {contor3} numere pozitive in aceasta secventa de numere");
            }

            private static void NrPare()
            {// Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
                int n, x, contor = 0;
                Console.WriteLine("Cate numere are sirul?");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Introduceti al {i}-lea numar");
                    x = int.Parse(Console.ReadLine());
                    if (x % 2 == 0)
                        contor++;
                }
                Console.WriteLine($"Sunt {contor} numere pare in aceasta secventa de numere");

            }
        }
    }
