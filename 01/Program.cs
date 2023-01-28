Console.Clear();
Console.WriteLine("1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());

PrintResult(FillArray(sizeArray));

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}.");
    Console.WriteLine();
}