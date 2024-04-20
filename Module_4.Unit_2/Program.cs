namespace Module_4.Unit_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 4.1.4
            string A = "Денис";
            string B = "Петя";
            var С = A != B;
            // Задание 4.1.5
            int A1 = 1;
            int B1 = 2;
            double x = 1.0;
            double y = 2.0;
            bool C1 = A1 < B1 | x > y;

            var a = 6;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else 
            {
                Console.WriteLine("Условие ложно");
                if (b < 10)
                {
                    Console.WriteLine("Значение b = {0}", b);
                }
            }

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else if (b < 10)
            {
                Console.WriteLine($"Значение b = {b} меньше 10");
            }
            else
            {
                Console.WriteLine("Значение b = {0} больше 10", b);
            }

            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }
            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }

            var c = a != b ? a + b : b;
            Console.WriteLine(c);


            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            //Задание 4.1.18

            Console.WriteLine("Введите свой любимый цвет на английском языке с маленькой буквы");
            var MyFavoriteColor = Console.ReadLine();
            switch (MyFavoriteColor)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!"); 
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
    }
}
