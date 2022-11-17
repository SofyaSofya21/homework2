// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

bool inputmode = false;

while (!inputmode)
{
    int number = ReadInt("Введите трехзначное число");

    if (number > 99 && number < 1000)
    {
        inputmode = true;
        int deleteNumber = number % 10;
        int outputNumber = (number - deleteNumber)/10;
        outputNumber = outputNumber%10;
        Console.WriteLine($"{number} -> {outputNumber}");
    }
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число. Введите еще раз.");
    }
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}