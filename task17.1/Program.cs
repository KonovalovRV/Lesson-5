// Задача 3: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] collection = {2.5, 100.6, 78.6, 3.5, 6.9, 52, 4};

double FindMax(double[] coll)
{
    double max = coll[0];
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] > max)
        {
            max = coll[i];
        }
    }
    return max;
}

double FindMin(double[] col)
{
    double min = col[0];
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] < min)
        {
            min = col[i];
        }
    }
    return min;
}

double a = FindMax(collection);
double b = FindMin(collection);

double DiffMinMax(double maxNumber,double minNumber)
{

    double a= 0;
    a=maxNumber - minNumber;
    return Math.Round (a,2);
}

double c=DiffMinMax(a,b);

Console.WriteLine($"разница между max {a} и min {b} значениями {c}");

