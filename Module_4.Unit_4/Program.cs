namespace Module_4.Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine($"Введите любимый цвет номер {i + 1}");
                favcolors[i] = Console.ReadLine();
            }

            foreach (var color in favcolors)
            {
                switch (color)
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

            // Размерность массива
            var array = new int[] { 1, 2, 3, 4 };
            var l = array.Length;

            // Разные виды инициализации массива
            int[] array1 = new int[4] { 1, 2, 3, 4 };
            int[] array2 = new int[] { 1, 2, 3, 4 };
            int[] array3 = new[] { 1, 2, 3, 4 };
            int[] array4 = { 1, 2, 3, 4 };

            Console.WriteLine("Введите свое имя");
            string MyName = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            foreach (var item in MyName)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Последняя буква Вашего имени: " + MyName[MyName.Length - 1]);

            // Задание 4.3.7
            for (int i = MyName.Length - 1; i >= 0; i--)
            {
                Console.Write(MyName[i] + " ");
            }
            Console.WriteLine();
            // Двумерный массив
            int[,] array5 = { { 1, 2, 3 }, { 5, 6, 7 } };
            foreach (var item in array5)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n" + array5.Length);

            Console.Write("Количество строк: ");
            Console.WriteLine(array5.GetUpperBound(0) + 1 + "");

            Console.Write("Количество колонок: ");
            Console.WriteLine(array5.GetUpperBound(1) + 1 + " ");

            // Отображение двумерного массива

            for (int i = 0; i < array5.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array5.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(array5[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] array6 = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            for (int i = 0; i < array6.GetUpperBound(1) + 1; i++)
            {
                for (int j = 0; j < array6.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(array6[j, i] + " ");
                }
                Console.WriteLine();
            }

            // Задание 4.3.12 Сортировка одномерного массива

            var array7 = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;
            for (int i = 0; i < array7.Length; i++)
            {
                for (int j = i + 1; j < array7.Length; j++)
                {
                    if (array7[i] > array7[j])
                    {
                        temp = array7[i];
                        array7[i] = array7[j];
                        array7[j] = temp;
                    }
                }
            }
            foreach (var item in array7)
            {
                Console.Write(item + " ");
            }

            // Задание 4.3.13
            int sum = 0;
            foreach (var item in array7)
            {
                sum += item;
            }
            Console.WriteLine("\nСумма элементов массива равна {0}", sum);

            // Зубчатый массив

            int[][] array8 = new int[3][];

            array8[0] = new int[2] { 1, 2 };
            array8[1] = new int[3] { 1, 2, 3 };
            array8[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var item1 in array8)
            {
                foreach (var item2 in item1)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }

            int[] array9 = { -1, 2, 3, 4, -5, 0 };
            int count = 0;
            foreach (var item in array9)
            {
                if (item > 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество положительных чисел: " + count);

            // Задание 4.3.16
            int[,] array10 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int numbers = 0;
            for (int i = 0; i < array10.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array10.GetUpperBound(1) + 1; j++)
                {
                    if (array10[i, j] > 0)
                    {
                        numbers++;
                    }
                }
            }
            Console.WriteLine("Количество положительных чисел: " + numbers);

            // Задание 4.3.17 Сортировка двумерного массива (по строкам)
            for (int i = 0; i < array10.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array10.GetUpperBound(1) + 1; j++)
                {
                    for (int k = j + 1; k < array10.GetUpperBound(1) + 1; k++)
                    {
                        if (array10[i,j] > array10[i,k])
                        {
                            temp = array10[i,j];
                            array10[i,j] = array10[i,k];
                            array10[i,k] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < array10.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array10.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(array10[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
