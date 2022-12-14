// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр = {GetSumNum(num)}");

int GetSumNum(int number)

{
    int sum = 0;
    while (num > 0)
    {
        int a = num % 10;
        num /= 10;
        sum += a;
    }
    return sum;
}
