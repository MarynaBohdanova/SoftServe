namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Enter a sequence of positive integers(to the first negative).
            // Calculate the arithmetic average of the entered positive numbers.
            // 1,6,3,9,-8-> (1 + 6 + 3 + 9) / 4
            Console.WriteLine("4.Enter a sequence of positive integers(to the first negative).");
            List<int> listFromInput = new List<int>();

            int a = int.Parse(Console.ReadLine());
            int sumT1 = 0;
            while (a > 0)
            {
                sumT1 += a;
                listFromInput.Add(a);
                a = int.Parse(Console.ReadLine());
            }

            sumT1 = sumT1 / listFromInput.Count;
            Console.WriteLine(sumT1);
            Console.ReadLine();

            // -------------------------------------------------------------
            //  5.Check if the entered year is a leap
            //   taken from https://learn.microsoft.com/en-us/office/troubleshoot/excel/determine-a-leap-year
            Console.WriteLine("5.Check if the entered year is a leap");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine("year is a leap");
                }
                else
                {
                    Console.WriteLine("year is a leap");
                }

            }
            else
            {
                Console.WriteLine("year is not a leap");
            }

            //---------------------------------------------------------
            //6.Find the sum of digits of the entered integer number //(365 -> 3+6+5)
            Console.WriteLine("6.Find the sum of digits of the entered integer number //(365 -> 3+6+5)");
            string inputFromKeyBoard = Console.ReadLine();

            int summ = 0;
            for (int i = 0; i < inputFromKeyBoard.Length; i++)
            {
                summ += int.Parse(inputFromKeyBoard[i].ToString());
            }
            Console.WriteLine(summ);

            //7.Check if the entered integer number contains only odd digits.

            string inputFromKeyB = Console.ReadLine();
            for (int i = 0; i < inputFromKeyB.Length; i++)
            {
                int digit = int.Parse(inputFromKeyB[i].ToString());
                if (digit % 2 == 0)
                {
                    Console.WriteLine("Not Only Odds");
                }
            }

            //3.Enter the name of the drink(coffee, tea, juice, water).
            //Print the name and price of the drink.
            Console.WriteLine("3.Enter the name of the drink(coffee, tea, juice, water)");

            string inputDrinkName = Console.ReadLine();
            switch (inputDrinkName.ToLower())
            {
                case "coffee":
                    Console.WriteLine($"{inputDrinkName}, price 10");
                    break;
                case "tee":
                case "juse":
                case "water":
                    Console.WriteLine($"{inputDrinkName}, price 5");
                    break;
            }

            //2.Enter some string text from the console.Print each second character.
            Console.WriteLine("2.Enter some string text from the console.Print each second character.");
            string inputC = Console.ReadLine();
            foreach (char i in inputC)
            {
                Console.WriteLine(i);
            }

            //1.Enter two integer numbers a and b.
            //Calculate how many integers in the range [a..b] are divided by 3 without remainder.

            Console.WriteLine("1.Enter two integer numbers a and b.");
            int testVariable1 = int.Parse(Console.ReadLine());
            int testVariable2 = int.Parse(Console.ReadLine());

            List<int> interval = new List<int>();
            for (int i = testVariable1; i < testVariable2; i++)
            {
                interval.Add(i);
            }
            interval.Add(testVariable2);

            int commonSum = 0;
            foreach (int i in interval)
            {
                if (i % 3 == 0)
                {
                    commonSum++;
                }

            }
            Console.WriteLine(commonSum);
        }
    }
}