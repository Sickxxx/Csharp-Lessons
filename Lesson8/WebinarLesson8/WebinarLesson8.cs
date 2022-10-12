void Zadacha53()
{
    //     Задача 53: Задайте двумерный массив. Напишите программу,
    // которая поменяет местами первую и последнюю строку
    // массива.
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers, 0, 10);
    MyLib.ArrayMD.PrintArray(numbers);
    int maxIndex = rows - 1;
    int i = 0;
    for (int j = 0; j < columns; j++)
    {
        (numbers[i, j], numbers[maxIndex, j]) = (numbers[maxIndex, j], numbers[i, j]);
    }
    Console.WriteLine(" ");
    MyLib.ArrayMD.PrintArray(numbers);
}
void Zadacha55()
{
    //     Задача 55: Задайте двумерный массив. Напишите программу,
    // которая заменяет строки на столбцы. В случае, если это
    // невозможно, программа должна вывести сообщение для
    // пользователя.
    int rows = new Random().Next(4, 9);
    int columns = new Random().Next(4, 9);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers);
    if (rows == columns)
    {
        MyLib.ArrayMD.PrintArray(numbers);
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < columns; j++)
            {
                (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]);
            }
        }
        Console.WriteLine("");
        MyLib.ArrayMD.PrintArray(numbers);
    }
    else Console.WriteLine("Действие невозможно");


}
void Zadacha57()
{
    //     Задача 57: Составить частотный словарь элементов
    // двумерного массива. Частотный словарь содержит
    // информацию о том, сколько раз встречается элемент
    // входных данных.
    int rows = new Random().Next(2, 6);
    int columns = new Random().Next(2, 6);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers, 0, 9);
    MyLib.ArrayMD.PrintArray(numbers);
    int[] lib = new int[10];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            lib[numbers[i, j]]++;
        }
    }
    for (int i = 0; i < lib.Length; i++)
    {
        if (lib[i] > 0)
        {
            Console.WriteLine($"{i} встречается {lib[i]} раз ");
        }
    }
}
void Zadacha59()
{
    //     Задача 59: Задайте двумерный массив из целых чисел.
    // Напишите программу, которая удалит строку и столбец, на
    // пересечении которых расположен наименьший элемент массива.
    int rows = new Random().Next(3, 8);
    int columns = new Random().Next(3, 8);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers, -9, 9);
    MyLib.ArrayMD.PrintArray(numbers);
    int min = numbers[0, 0];
    int min_i = 0;
    int min_j = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i, j] < min)
            {
                min = numbers[i, j];
                min_i = i;
                min_j = j;
            }
        }
    }
    Console.WriteLine($"Мимимальный элемент {min} ({min_i}, {min_j})");
    int rows2 = rows - 1;
    int columns2 = columns- 1;
    int[,] numbers2 = new int[rows2, columns2];
    int sdvig_i = 0;
    int sdvig_j = 0;
    for (int i = 0; i < rows2; i++)
    {
        if (i == min_i) sdvig_i++;
        sdvig_j = 0;
        for (int j = 0; j < columns2; j++)
        {
            if (j == min_j) sdvig_j++;
            numbers2[i, j] = numbers[i + sdvig_i, j + sdvig_j];
        }
    }
    MyLib.ArrayMD.PrintArray(numbers2);

}


Zadacha59();