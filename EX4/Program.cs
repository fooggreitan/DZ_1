// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

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
