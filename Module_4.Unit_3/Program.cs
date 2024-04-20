namespace Module_4.Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой любимый цвет на английском языке с маленькой буквы");
            string MyFavoriteColor;
            // Цикл For
            Console.WriteLine("Цикл For");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Iteration {0}", i);
                MyFavoriteColor = Console.ReadLine();
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
            // Цикл While со счетчиков k
            Console.WriteLine("Цикл While");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine("Iteration {0}", k);
                MyFavoriteColor = Console.ReadLine();
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
                k++;
            }
            // Цикл Do While сщ счетчиком t
            Console.WriteLine("Цикл do While");
            int t = 0;
            do
            {
                Console.WriteLine("Iteration {0}", t);
                MyFavoriteColor = Console.ReadLine();
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
                t++;
            } while (t < 3);

            //Подсчет суммы положительных цифр
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Введите число");
                var number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }
                sum += number;
            }
            Console.WriteLine($"Итоговая сумма {sum}");
        }
    }
}
