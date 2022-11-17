// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day = ReadInt("Введите номер дня недели (цифру от 1 до 7).");

bool weekDay = false;

while (!weekDay)
{
    if (day < 1 || day > 7)
    {
        Console.WriteLine("Вы ввели некорректное число.");
        day = ReadInt("Введите номер дня недели (цифру от 1 до 7) еще раз.");
    }

    else
    {
        weekDay = true;
    }
}

if (day > 5)
{
    Console.WriteLine($"{day} -> выходной день");
}
else
{
    Console.WriteLine($"{day} -> НЕ выходной день");
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}