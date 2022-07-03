/* напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 - нет
23432 - да
12821 - да */

Console.WriteLine("Введите пятизначное число: ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
if (fiveDigitNumber > 9999 && fiveDigitNumber < 100000)
{
    int firstNumber = fiveDigitNumber / 10000;
    int secondNumber = (fiveDigitNumber / 1000) % 10;
    int fourthNumber = (fiveDigitNumber % 100) / 10;
    int fifthNumber = fiveDigitNumber % 10;
    if (firstNumber == fifthNumber && secondNumber == fourthNumber)
    {
        Console.WriteLine($"Число {fiveDigitNumber} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {fiveDigitNumber} не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число.");
}