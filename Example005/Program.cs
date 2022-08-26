Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int max = a;
int min = b;

if(a < b)
{
    max = b;
    min = a;
}
if(min * min == max)
{
    Console.WriteLine("Yes");
}
else
{
    {Console.WriteLine("No");
    }
}