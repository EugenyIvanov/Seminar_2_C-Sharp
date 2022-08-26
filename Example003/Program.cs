Console.Clear();

int a = new Random().Next(10, 100);
int b = new Random().Next(1, 10);
Console.WriteLine(a);
Console.WriteLine(b);

if (a % b == 0)
{
    Console.Write("Кратно");
}
else
{
    int x = a % b;
    Console.Write("Не кратно, остаток ");
    Console.Write(x);
}