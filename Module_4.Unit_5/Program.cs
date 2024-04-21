namespace Module_4.Unit_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var anketa = (name: "Jane", age: 27);

            Console.WriteLine("Ваше имя: " + anketa.name);
            Console.WriteLine("Ваш возраст: " + anketa.age);

            // Задание 4.4.2
            (string name, int age) anketaUser;
            Console.Write("Введите Ваше имя: ");
            anketaUser.name = Console.ReadLine();
            Console.Write("введите ваш возраст цифрами: ");
            anketaUser.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: " + anketaUser.name);
            Console.WriteLine("Ваш возраст: " + anketaUser.age);

            //Задание 4.4.5
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            Console.Write("Введите тип питомца: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Введите возраст питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
        }
    }
}
