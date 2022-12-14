// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Рузультат = {GetNumPow(a, b)}");


int GetNumPow(int a, int b)
{
    int pow = (int)Math.Pow(a, b);
    return pow;
}