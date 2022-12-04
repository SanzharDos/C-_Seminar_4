// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine($"Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int ff = 1;
for (int i = 1; i <= num; i++)
{
    ff = ff * i;
}
Console.WriteLine($"Произведение чисел от 1 до {num} равна {ff}");
Console.WriteLine($"Альтернатива через функцию, произведение чисел от 1 до {num} равна {Count(num)}");

int Count(int arr)
{
    int f = 1;
    for (int i = 1; i <= arr; i++)
    {
        f = f * i;
    }
    return f;
}