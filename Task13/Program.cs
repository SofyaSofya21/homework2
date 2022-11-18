// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

long number = ReadInt("Введите любое число");

long count = NumeralDigit(number);

if (count >= 3)
{
    long thirdNumber = NumberReduction(number,count)%10;
    Console.WriteLine($"{number} -> {thirdNumber}");
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}


long NumeralDigit(long number1)
{
    long digit = 0;
    long number4 = number1;
    long number2 = 0;
    long number3 = 0;

    while (number4 > 0)
    {
        number2 = number4 % 10;
        number3 = number4 - number2;
        number4 = number3 / 10;
        digit++;
    }
    return digit;
}

long ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

long NumberReduction(long number1, long digit)
{
    long number4 = number1;
    long number2 = 0;
    long number3 = 0;

    while (digit > 3)
    {
        number2 = number4 % 10;
        number3 = number4 - number2;
        number4 = number3 / 10;
        digit--;
    }
    return number4;
}