Console.Clear();

int num = new Random().Next ( 10, 100 );
Console.WriteLine(num);

int a1 = num / 10;
int a2 = num % 10;

int max = a1;
if (a2 > max)
{
    max = a2;
}
Console.Write(max);