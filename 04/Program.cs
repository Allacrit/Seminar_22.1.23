Console.Clear();
Console.WriteLine("4. Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200.");

List<int> Ints = new List<int>();

Console.Write("Введите длинну списка: ");
int sizeList = int.Parse(Console.ReadLine());
string end = string.Empty;
for (int i = 0; i < sizeList; i++)
{
    Ints.Add(new Random().Next(20, 30));
}

Console.WriteLine();
Console.WriteLine($"Создан список случайных целых чисел: {String.Join(", ", Ints)}.");
Console.WriteLine();

if (sizeList % 10 == 1) end = "";
else if (sizeList % 10 == 2 || sizeList % 10 == 3 || sizeList % 10 == 4) end = "а";
else end = "ов";

Console.WriteLine($"Созданный список соодержит {sizeList} элемент{end}.");
Console.WriteLine();

int indexOf1st20 = Ints.FindIndex(x => x == 20);

if (indexOf1st20 == -1)
{
    Console.WriteLine("Число 20 не найденно в данном списке.");
}
else
{
    Ints[indexOf1st20] = 200;
    Console.WriteLine($"Первое число 20 найдено на позиции № {indexOf1st20}.");
    Console.WriteLine("Cписок становится таким: " + String.Join(", ", Ints) + ".");
    Console.WriteLine();
}


