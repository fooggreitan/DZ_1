// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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
    
