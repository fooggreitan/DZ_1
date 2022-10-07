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
