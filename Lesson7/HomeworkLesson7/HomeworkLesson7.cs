void Zadacha47()
{
    //     Задача 47: Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами,
    // округлёнными до одного знака.
    int rows = new Random().Next(4, 11);
    int columns = new Random().Next(4, 11);
    double[,] numbers = new double[rows, columns];
    MyLib.ArrayMD.FillArray(numbers);
    MyLib.ArrayMD.PrintArray(numbers);
}
void Zadacha50()
{
    //     Задача 50: Напишите программу, которая на вход
    // принимает индексы элемента в двумерном массиве, и
    // возвращает значение этого элемента или же указание,
    // что такого элемента нет.
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers, -10, 10);
    MyLib.ArrayMD.PrintArray(numbers);
    Console.WriteLine("Введите через запятую индексы элемента для поиска:");
    int[] indexes = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
    if (indexes[0] <= rows && indexes[0] >= 0
        && indexes[1] <= columns && indexes[1] >= 0)
    {
        Console.WriteLine($"Искомый элемент равен: {numbers[indexes[0], indexes[1]]}");
    }
    else Console.WriteLine("Искомого элемента нет в массиве");
}
void Zadacha52()
{
    //     Задача 52: Задайте двумерный массив из целых чисел.
    // Найдите среднее арифметическое элементов в каждом
    // столбце.
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers, -10, 10);
    MyLib.ArrayMD.PrintArray(numbers);
    MyLib.ArrayMD.AverageColumns(numbers);
    
}
Zadacha52();