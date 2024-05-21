namespace Jeneric_part_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictAng = new Dictionary<string, string>()
        {
            {"Russia", "Россия"},
            {"USA","США"},
            {"France", "Франция"}
        };
            Dictionary<string, string> dictRus = new Dictionary<string, string>()
        {
            {"Россия", "Russia"},
            {"США","USA"},
            {"Франция", "France"}
        };

            Console.WriteLine("Выберите направление перевода:");
            Console.WriteLine("1.Английский -> Русский");
            Console.WriteLine("2.Русский -> Английский");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Введите слово на английском ->");
                string word = Console.ReadLine();
                if (dictAng.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод на русский: {dictAng[word]}");
                }
                else { Console.WriteLine("Перевод не найден!"); }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите слово на русском ->");
                string word = Console.ReadLine();
                if (dictRus.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод на английский: {dictRus[word]}");
                }
                else { Console.WriteLine("Перевод не найден!"); }
            }
            else Console.WriteLine("НЕТ ТАКОЙ КОМАНДЫ!!!!!!");


        }
    }
}
