namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("Hello, World!");


            //2.

            Console.BackgroundColor = ConsoleColor.Blue;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
                Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
                Console.WriteLine("────█░░█░░░░░█░░█────");
                Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
                Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
                Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
                Console.WriteLine("────█░░_░░░░░_░░█────");
                Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
                Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
                Thread.Sleep(1000);
                Console.Clear();

            }


            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
            Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
            Console.WriteLine("────█░░█░░░░░█░░█────");
            Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
            Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");

            //3.
            Console.WriteLine("Is bear sleeping? Press 'y' if he is");
            
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
                Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
                Console.WriteLine("────█░░_░░░░░_░░█────");
                Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
                Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
            }
            else
            {
                Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
                Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
                Console.WriteLine("────█░░█░░░░░█░░█────");
                Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
                Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
            }

            //4. 
            for(int i = 0; i < (int)Console.ReadLine(); i++)
            {
                Console.WriteLine($"Iteration #{i}");
            }

        }
    }
}