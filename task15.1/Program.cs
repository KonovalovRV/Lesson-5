// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int len, int minLimit, int maxLimit)
{
    int[] collection = new int[len];
    Random rnd = new Random();
    for (int index = 0; index < len; index++)
    {
        collection[index] = rnd.Next(minLimit, maxLimit + 1);
    }
    return collection;
}

void PrintArray(int[] col)
{
    for (int index = 0; index < col.Length; index++)
    {
        System.Console.WriteLine($"{col[index]}");
    }
    System.Console.WriteLine();
}

int EvenNumbers(int[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if ((col[i] % 2) == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arr = FillArray(10, 300, 600);

PrintArray(arr);

int coun = EvenNumbers(arr);

System.Console.WriteLine($"{coun}");
