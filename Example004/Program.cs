Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

if(x % 7 ==0 && x % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}