/ Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumUnevenNumbers(int[] col)
{
    int su = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] < 0)
        {
            col[i] = -col[i];
        }
        if ((col[i] % 2) != 0)
        {
            su += col[i];
        }
    }
    return su;
}

int[] arr = FillArray(10, -10, 4);

PrintArray(FillArray(10, -10, 4));


System.Console.WriteLine($"{SumUnevenNumbers(arr)}");


