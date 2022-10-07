Console.Write("Введите число первое: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число второе: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число третье: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > b && a > c)
    Console.WriteLine($"Max число: {a}");
else if (b > c) 
    Console.WriteLine($"Max число: {b}");
else
    Console.WriteLine($"Max число: {c}");