using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------ 1. Uzdevums - Sasveicināšanās konsoles aplikācija ------------------");
            Console.WriteLine("Kā tevi sauc?");
            Console.WriteLine("Sveiks, " + Console.ReadLine());

            Console.WriteLine("------------ 2. uzdevums - int.Parse ------------------");
            Console.WriteLine("Kāds ir tavs vecums?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nākamgad tev paliks " + (age++) + ", Tu esi pilngadīgs.");

            Console.WriteLine("------------ 3. uzdevums - Math.Max salidzinājums------------------");
            Console.WriteLine("Ievadiet pirmo skaitli ?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli ?");
            Console.WriteLine("lielākais skaitlis : " + Math.Max(num1, int.Parse(Console.ReadLine())) );

            Console.WriteLine("------------ 4. uzdevums - Math.Min salidzinājums------------------");
            Console.WriteLine("Ievadiet pirmo skaitli ?");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli ?");
            Console.WriteLine("lielākais skaitlis : " + Math.Min(num2, int.Parse(Console.ReadLine())));
            
            Console.WriteLine("------------  5.uzdevums - % ------------------");
            Console.WriteLine("Ievadiet pirmo skaitli ?");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli ?");
            Console.WriteLine("dalījuma atlikums : " + (num3 % int.Parse(Console.ReadLine())));

            Console.WriteLine("------------  6. uzdevums - Odd or Even ------------------");
            Console.WriteLine("Ievadiet skaitli ?");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Jūs ievadījat " + ( num4 %2==0 ? "pāra" : "nepāra") + " skaitli");

            Console.WriteLine("------------  7. uzdevums - Taisnstūra laukuma aprēķināšana ------------------");
            Console.WriteLine("Ievadiet sānu garumu :");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadiet sānu platumu :");
            int num6 = int.Parse(Console.ReadLine());
            double result1 = (num5 * num6);
            Console.WriteLine("G: {0}, P: {1}, Taisnstūra laukums: {2}", num5, num6, Math.Round(result1, 2));

            Console.WriteLine("------------  8.uzdevums - Trijstūra laukuma aprēķināšana ------------------");
            Console.WriteLine("Ievadiet skaitli (a):");
            int num7 = int.Parse(Console.ReadLine());
            double p = (num7*3 ) / 2;
            Console.WriteLine("Trijstūra laukuma aprēķināšans ar sānu (а): {0}", Math.Sqrt(p * (p - num7) * (p - num7) * (p - num7)));

            Console.WriteLine("------------  9. uzdevums - Interpolācija ------------------");
            Console.WriteLine("Kāds ir tavs vārds?");
            string name = Console.ReadLine();
            Console.WriteLine("Kāds ir tavs vecums?");
            Console.WriteLine("Sveiks " + name + ", tavs vecums ir " +  Console.ReadLine());

            Console.WriteLine("------------  EOF ------------------");

        }
    }
}
