
Console.Write("Введите число первое: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число второе: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a < b) 
{
    Console.WriteLine($"Max число: {b}");
    Console.WriteLine($"Min число: {a}");
}

else
{
    Console.WriteLine($"Max число: {a}");
    Console.WriteLine($"Min число: {b}");
}
    
