class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input First Number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input Second Number: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
}