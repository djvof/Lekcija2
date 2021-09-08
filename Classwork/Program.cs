using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 15;
            char myFavoritLetter = 'A';
            bool isCar = true;
            double myConstant = 4.58; //decimalskairlis
            float myChangingNum = 2.46f; //mazaks decimalskaitlis 
            string name = "Bla blja bla";


            Console.WriteLine(myNumber);
            Console.WriteLine(myFavoritLetter);
            Console.WriteLine($"{myNumber}.{myFavoritLetter}.{isCar}.{myConstant}.{myChangingNum}.{name}");


            Console.WriteLine("------------------------------");
            int myNumber1 = 4;
            int myNumber2 = 6;
            int sum1 = myNumber1 + myNumber2;
            Console.WriteLine(sum1);

            string name1 = "Hello ";
            string name2 = "World !";
            string namesTogether = name1 + name2;
            Console.WriteLine(namesTogether);


            int withPluses = 4;
            ++withPluses;
            Console.WriteLine(withPluses);

            int devisionReminder1 = 5;
            int devisionReminder2 = 2;
            int devisionReminderResult = devisionReminder1 % devisionReminder2;
            Console.WriteLine(devisionReminderResult);


            Console.WriteLine("------------------------------");

            bool isEqualNumber = devisionReminder1 == devisionReminder2;
            Console.WriteLine(isEqualNumber);

            bool isEqualText = name1 == name2;
            Console.WriteLine(isEqualText);


            Console.WriteLine(devisionReminder1 != devisionReminder2);


            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine("------------------------------");
            Console.WriteLine("and:    " + (isFalse && isTrue));
            Console.WriteLine("or:     " + (isFalse || isTrue));
            Console.WriteLine("reverse:" + !(isFalse && isTrue));



            Console.WriteLine("------------------------------");

            int myNumber9 = 14;
            Console.WriteLine("+= : " + (myNumber9 += 10));
            Console.WriteLine("-= : " + (myNumber9 -= 10));

            Console.WriteLine("------ Console ReadLine: ----------------");
              
            Console.WriteLine("Kāds ir tavs Vārds?");
            //string answer = Console.ReadLine();
            //Console.WriteLine("Answer: " + answer );
            Console.WriteLine("Answer: " + Console.ReadLine());

            Console.WriteLine("Kāds ir tavs Vecums?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("iepriekšaja gada tev bija : " + (--age));

            Console.WriteLine("------ Math klase: ----------------");
        }
    }
}
