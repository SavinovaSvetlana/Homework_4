//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int n = 8;
int[] array = new int[n];
Random rand = new Random();
int[] GetNewArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, n);

        Console.Write(array[i] + ", ");

    }
    return array;
}
GetNewArr(array);