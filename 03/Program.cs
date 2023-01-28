Console.Clear();
Console.WriteLine("3. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.");

Console.Write("Введите длину массива: ");
int sizeArray = int.Parse(Console.ReadLine());

PrintDiffMinMax(FillSourceArray(sizeArray));

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Номер {i} в массиве с числом: {arr[i]}.");
    }
    double difference = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
}