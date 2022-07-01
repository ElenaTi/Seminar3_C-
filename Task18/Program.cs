 // Напишите программу, которая по заданному номеру четверти, 
 //показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int QuarterNumber = Convert.ToInt32(Console.ReadLine());
if (QuarterNumber > 0 && QuarterNumber < 5)
{
    if (QuarterNumber == 1)
    {
        Console.WriteLine($"В {QuarterNumber} четверти  X > 0 и Y > 0 .");
    }
    else if (QuarterNumber == 2)
    {
        Console.WriteLine($"В {QuarterNumber} четверти  X < 0 и Y > 0 .");
    }
    else if (QuarterNumber == 3)
    {
        Console.WriteLine($"В {QuarterNumber} четверти  X < 0 и Y < 0 .");
    }
     else if (QuarterNumber == 4)
    {
        Console.WriteLine($"В {QuarterNumber} четверти  X > 0 и Y < 0 .");
    }

}
else
{
    Console.WriteLine("Число должно быть в диапазоне от 1 до 4");
}