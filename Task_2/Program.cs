// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Count(int arg)
{
    int count = 0;
    while (arg >= 1)
    {
        arg = arg / 10;
        count++;
    }
    return count;
}

Console.WriteLine($"Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int i = 1;
while (num1 > 9)
{
    i = i + 1;
    num1 = num1 / 10;
}
Console.WriteLine($"Количество цифр в числе {num} равно {i}");
Console.WriteLine($"Альтернатива, через функцию, количество цифр в числе {num} равно {Count(num)}");



