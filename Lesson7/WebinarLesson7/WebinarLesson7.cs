void Zadacha46()
{
    //     Задача 46: Задайте двумерный массив размером m×n,
    // заполненный случайными целыми числами.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers);
    MyLib.ArrayMD.PrintArray(numbers);
}
void FillArray(int[,] arr)
{
    Random random = new Random();
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = random.Next(-10, 11);
        }
    }
}
void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void Zadacha47()
{
//     Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: A = m+n.
// Выведите полученный массив на экран.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray3(numbers);
    PrintArray(numbers);
}
void FillArray3(int[,] arr)
{
    Random random = new Random();
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = i + j;
        }
    }
}
void Zadacha49()
{
//     Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их квадраты
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 0; i < rows; i += 2)
    {
        for (int j = 0; j < columns; j += 2)
        {
            numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }
    Console.WriteLine("");
    PrintArray(numbers);
}
void Zadacha51()
{
//     Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами (0,0);
// (1;1) и т.д.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    int sum = 0;
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 0; i < rows; i += 1)
    {
        int j = i;
        sum = numbers[i, j] + sum;
    }
    Console.WriteLine("Сумма элементов главной диагонали равна " + sum);
}
Zadacha51();
