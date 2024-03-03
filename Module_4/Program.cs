namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myApples = 5;
            var hisApples = 6;
            var hisSpeares = 7;

            var result = (myApples != hisSpeares) & (myApples < hisApples);
            Console.WriteLine(result);
        }
    }
}
