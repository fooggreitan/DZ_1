// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите любое число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int counter = -numbers;

while (counter <= numbers) 
{
    if(counter % 2 == 0 & counter > 0)
    {
        Console.Write($"{counter}");
    }
  
    counter = counter + 1;
}
