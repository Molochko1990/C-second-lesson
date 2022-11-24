Console.WriteLine("Input First Number");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Second Number");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    Console.WriteLine($"{A} is bigger than {B}");
}
else
{
    Console.WriteLine($"{B} is bigger than {A}");
}