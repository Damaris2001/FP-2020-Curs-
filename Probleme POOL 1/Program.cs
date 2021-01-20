using System;

namespace Probleme_POOL_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ecuatiegrad_1();
            //Ecuatiegrad_2();
            // Divide();
            //An_bisect1();
            // Extragere_cifre();
            //Triunghi();
            //Swap();
            //Swap_restrictionat();
            //Divizori();
            //Test_de_primalitate();
            //Ordine_invarsa();
            //Numere_intregi_divizibile();
            //An_bisecti2();
            //Palindrom();
            //Ordine_crescatoare3();
            //Cmmdc_Cmmmc();
            //Descompunerefactori_primi();
            //cifre_care_se_pot_repeta();
            //Perioada();
            //Ghicitinr();
        }

        private static void Ghicitinr()
        {//Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?"

            int x, n;
            Random rnd = new Random();
            x = rnd.Next(1, 1024);
            do
            {
                Console.WriteLine("Introduceti un numar cuprins intre 1 si 1024");
                n = int.Parse(Console.ReadLine());
                if (n > x)
                    Console.WriteLine("Numarul introdus este prea mare");
                if (n < x)
                    Console.WriteLine("Numarul introdus este prea mic");
            }
            while (n != x);
            Console.WriteLine("Ati ghicit numarul!");
        }

        private static void Perioada()
        {//Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). 
            int m = 13; //int.Parse(Console.ReadLine());
            int n = 30; // int.Parse(Console.ReadLine()); 
            double d;
            d = (double)m / n;

            Console.WriteLine(d);
            double fract = d - Math.Truncate(d);

            int maxDecimal = 6;

            while (maxDecimal > 0 && fract != 0)
            {
                int cifraZecimala;

                cifraZecimala = (int)Math.Truncate(fract * 10);

                Console.WriteLine($"{cifraZecimala} ");
                fract = fract * 10 - Math.Truncate(fract * 10);
                maxDecimal--;
            }
        }

        private static void cifre_care_se_pot_repeta()
        {//Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
         //De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
            int n = int.Parse(Console.ReadLine());
            int  a, b, c, s, z, u;

            Console.WriteLine("Introduceti un numar de 6 cifre");
            a = n / 100000;

            b = (n / 10000) % 10;

            c = (n / 1000) % 10;

            s = (n / 100) % 10;

            z = (n / 10) % 10;

            u = n % 10;

            if ((a == b || a == c || a == s || a == z || a == u) && (b != a || c != a || s != a || z != a || u != a) && (b == c || b == s || b == z || b == u))
                Console.WriteLine("Numarul e format doar cu 2 cifre care se pot repeta");
            else
                Console.WriteLine("Numarul nu e format doar cu 2 cifre care se pot repeta");

        }

    
        private static void Descompunerefactori_primi()
        {//Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 
            int n = int.Parse(Console.ReadLine());
            int d=2, p;
            while(n>1)
            {
                if (n % d == 0)
                {
                    p = 0;
                    while (n % d == 0)
                    {
                        p++;
                        n = n / d;
                    }
                    if (p > 0)
                        Console.Write($" {d} ^ {p}x ");
                }
                d++;
            }
 
        }

        private static void Cmmdc_Cmmmc()
        {// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r= 0;
            int p = a * b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;

            }
            while(b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine($"Cel mai mare divizor comun este:{a}");
            Console.WriteLine($"Cel mai mic multiplu comun este:{p/a}");
        }

        private static void Ordine_crescatoare3()
        {//Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a < b)

            {
                if (a < c)
                {
                    Console.Write($"{a} ");
                    if (b < c)
                    {
                        Console.WriteLine($"{b} {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c} {b}");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
            }
            else
            {
                if (b < c)
                {
                    Console.Write($"{b} ");
                    if (a < c)
                    {
                        Console.WriteLine($"{a} {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c} {a}");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }

            }

        }
    

        private static void Palindrom()
        {//Determianti daca un numar n este palindrom. 
         //(un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
            int ogl=0, s;
            int n = int.Parse(Console.ReadLine());
            s = n;
            while(n!=0)
            {
                ogl = ogl* 10 + n % 10;
                n = n / 10;
            }
            n = s;
            if (n == ogl)

               Console.WriteLine("Numarul este palindrom");

            else
                Console.WriteLine("Numarul nu este palindrom");
        }

        private static void An_bisecti2()
        {//Determianti  cati ani bisecti sunt intre anii y1 si y2.                ;

            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int nr = 0;
        for (int i = y1; i <= y2; i++)
        {
            if (i % 4 == 0 && i % 100 != 0)
            {
                nr++;
            }
        }
        Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti");
            
        }

        private static void Numere_intregi_divizibile()
        {//Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
            int n, a, b, c = 0;
            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru a din intervalul [a, b]");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru b din intervalul [a, b]");
            b = int.Parse(Console.ReadLine());
           for (int i = a; i <= b; i++)
           {
               if (i % n == 0)
               {
                c++;
               }
           }
            Console.WriteLine($"In intervalul [{a}, {b}] se afla {c} numere intregi divizibile cu {n}");
        }

        private static void Ordine_invarsa()
        {//Afisati in ordine inversa cifrele unui numar n. 
            int n = int.Parse(Console.ReadLine());
            int oglindit = 0, cifra;
            while (n > 0)
            {
                cifra = n % 10;
                oglindit = oglindit * 10 + cifra;
                n = n / 10;
            }
            Console.WriteLine("Oglinditul este :" +oglindit);
        }
        private static void Test_de_primalitate()
        {//Test de primalitate: determinati daca un numar n este prim
            int n = int.Parse(Console.ReadLine());
            int nr=0, d;
            for (d = 2; d <= n / 2; d++)
            {
                if (n % d == 0)
                 nr ++;
            }
            if (nr == 0)
                Console.WriteLine("Numarul este prim"); 
            else
                Console.WriteLine("Numarul nu este prim");     
        }
        
        private static void Divizori()
        {
            // Afisati toti divizorii numarului n.
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n/2; i++)
                if (n % i == 0)
                Console.WriteLine($"Divizorii numarului sunt {i}");
        }

        private static void Swap_restrictionat()
        {
            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
            //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.   
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a} ; b={b}");
        }

        private static void Swap()
        {
            //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            //Se cere sa se inverseze valorile lor. 
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int aux;
               aux = a;
               a = b;
               b = aux;
            Console.WriteLine($"a={a} ; b={b}");
        }

        private static void Triunghi()
        {//Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
        }

        private static void Extragere_cifre()
        {//Extrageti si afisati a k-a cifra de la sfarsitul unui numar. 
         //Cifrele se numara de la dreapta la stanga.
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            n = n % 10;
            Console.WriteLine(n);
        }

        private static void An_bisect()
        {//Detreminati daca un an y este an bisect. 
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0)
                Console.WriteLine("DA");
            else
               if (y % 100 != 0)
                Console.WriteLine("NU");
            else
            if (y % 400 == 0)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");
        }
        private static void Divide()
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare.
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine("Se divide.");
            else
                Console.WriteLine(" Nu se divide .");
        }

        private static void Ecuatiegrad_2()
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
            // Tratati toate cazurile posibile. 
            float x, delta = 0;
            double x1, x2;
            Console.Write("Introduceti a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Introduceti c: ");
            float c = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine("Exista o infinitate de solutii!");
                    else
                        Console.WriteLine("Ecuatie imposibila!");
                else
                {
                    Console.WriteLine("Ecuatie de gr I cu solutia ");
                    x = -c / b;
                    Console.WriteLine(x);
                }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Ecuatia nu are solutii reale.");
                else
                {
                    if (delta == 0)
                    {
                        Console.WriteLine("Ecuatia  are solutii egale.");
                        x1 = x2 = (-b) / 2 * a;
                        Console.WriteLine($"x1=x2={0}", x1);
                    }
                    else
                    {
                        if (delta > 0)
                        {
                            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                            Console.WriteLine($"x1={x1} ", x1);
                            Console.WriteLine($"x2={x2} ", x2);
                        }
                    }
                }
            }
        }

        private static void Ecuatiegrad_1()
        {//Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
            Console.Write("Introduceti a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti b: ");
            int b = int.Parse(Console.ReadLine());
            int x=0;
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Exista o infinitate de solutii!");
                else
                    Console.WriteLine("Ecuatie imposibila!");
            else
            {
                x = -b / a;
            }
            Console.WriteLine($"Solutia ecuatiei este: x={x}");
        }
   }
}
