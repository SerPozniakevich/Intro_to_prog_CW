internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Введите первую строку:");
        string a = Console.ReadLine();
        Console.WriteLine("Введите вторую строку:");
        string b = Console.ReadLine();
        Console.WriteLine("Введите третью строку:");
        string c = Console.ReadLine();
        Console.WriteLine("Введите четвёртую строку:");
        string d = Console.ReadLine();
        string[] arrayString = { a, b, c, d };

        for (int i = 0; i < arrayString.Length; i++)
        {
            Console.Write($"{arrayString[i]} ");
        }
        Console.Write(" -> ");
        for (int i = 0; i < arrayString.Length; i++)
        {
            int m = 3;
            if (arrayString[i].Length <= m)
            {
                Console.Write($"{arrayString[i]} ");
            }
        }
    }
}