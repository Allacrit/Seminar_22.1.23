Console.Clear();
Console.WriteLine("2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

Console.Write("Введите длинну массива: ");
int sizeArray = int.Parse(Console.ReadLine());

PrintArray(FillArray(sizeArray));

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции массива, соcтаваляет {sum}.");
    Console.WriteLine();
}