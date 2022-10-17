void Zadacha54()
{
    //     Задача 54: Задайте двумерный массив. Напишите программу, которая
    // упорядочит по убыванию элементы каждой строки двумерного массива.
    int rows = new Random().Next(4, 9);
    int columns = new Random().Next(4, 9);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers);
    MyLib.ArrayMD.PrintArray(numbers);
    Console.WriteLine("");
    RowsSort(numbers);
    Console.WriteLine("Упорядоченный по строкам массив");
    MyLib.ArrayMD.PrintArray(numbers);
}
void RowsSort(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int temp = 0;
    for (int k = 0; k < rows; k++)
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = i + 1; j < columns; j++)
            {
                if (arr[k, i] < arr[k, j])
                {
                    temp = arr[k, i];
                    arr[k, i] = arr[k, j];
                    arr[k, j] = temp;
                }
            }
        }
    }
}
void Zadacha56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите
    // программу, которая будет находить строку с наименьшей суммой элементов.
    int rows = new Random().Next(5, 9);
    int columns = new Random().Next(4, 6);
    int[,] numbers = new int[rows, columns];
    MyLib.ArrayMD.FillArray(numbers);
    MyLib.ArrayMD.PrintArray(numbers);
    Console.WriteLine("");
    int sum = 0;
    int min_sum = 10000;
    int row_index = 0;
    for (int i = 0; i < rows; i++)
    {
        sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < min_sum)
        {
            min_sum = sum;
            row_index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {row_index + 1}, сумма в ней {min_sum}");
}
void Zadacha58()
{
    // Задача 58: Заполните спирально массив 4 на 4 числами
    // от 1 до 16.
    int n = 4;
    int rows = n;
    int columns = n;
    int[,] numbers = new int[rows, columns];
    int num = 1;
    int i = 0;
    int j = -1;
    int direct_row = 0;
    int direct_columns = 1;
    while (num <= n * n)
    {
        if (i + direct_row >= 0 && i + direct_row < rows
            && j + direct_columns >= 0 && j + direct_columns < columns
            && numbers[i + direct_row, j + direct_columns] == 0)
        {
            i += direct_row;
            j += direct_columns;
            numbers[i, j] = num;
            num += 1;
        }
        else
        {
            if (direct_columns == 1)
            {
                direct_columns = 0;
                direct_row = 1;
            }
            else if (direct_row == 1)
            {
                direct_row = 0;
                direct_columns = -1;
            }
            else if (direct_columns == -1)
            {
                direct_columns = 0;
                direct_row = -1;
            }
            else if (direct_row == -1)
            {
                direct_row = 0;
                direct_columns = 1;
            }
        }
    }
    MyLib.ArrayMD.PrintArray(numbers);
}
void Zadacha59()
{
    // Задача 58: Заполните спирально массив 4 на 4 числами
    // от 1 до 16.
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    int index = 0;
    int current_row = 0;
    int current_column = 0;
    int change_index_row = 0;
    int change_index_column = 1;
    int steps = columns;
    int turn = 0;
    while (index < numbers.Length)
    {
        numbers[current_row, current_column] = index + 1;
        index += 1;
        steps -= 1;
        if (steps == 0)
        {
            steps = rows * ((turn + 1) % 2) + columns * (turn % 2) - 1 - turn / 2;
            int temp = change_index_row;
            change_index_row = change_index_column;
            change_index_column = -temp;
            turn++;
        }
        current_row += change_index_row;
        current_column += change_index_column;

    }
    MyLib.ArrayMD.PrintArray(numbers);
}
void Zadacha61()
{
    // Задача 61: Задайте две матрицы. Напишите
    // программу, которая будет находить произведение
    // двух матриц.
    int rows_a = new Random().Next(3, 6);
    int columns_a = new Random().Next(3, 6);
    int[,] numbers_a = new int[rows_a, columns_a];
    MyLib.ArrayMD.FillArray(numbers_a, 2, 5);
    Console.WriteLine("Первая матрица");
    MyLib.ArrayMD.PrintArray(numbers_a);
    Console.WriteLine("");
    int rows_b = new Random().Next(3, 6);
    int columns_b = new Random().Next(3, 6);
    int[,] numbers_b = new int[rows_b, columns_b];
    MyLib.ArrayMD.FillArray(numbers_b, 2, 5);
    Console.WriteLine("Вторая матрица");
    MyLib.ArrayMD.PrintArray(numbers_b);
    Console.WriteLine("");
    MatrixMultiplication(numbers_a, numbers_b);

}
void MatrixMultiplication(int[,] numbers_a, int[,] numbers_b)
{
    int rows_c = numbers_a.GetLength(0);
    int columns_c = numbers_b.GetLength(1);
    int length_a = numbers_a.GetLength(1);
    int length_b = numbers_b.GetLength(0);
    int[,] numbers_c = new int[rows_c, columns_c];
    if (length_a == length_b)
    {
        for (int i = 0; i < rows_c; i++)
        {
            for (int j = 0; j < columns_c; j++)
            {
                for (int k = 0; k < length_a; k++)
                {
                    numbers_c[i, j] += numbers_a[i, k] * numbers_b[k, j];
                }
            }
        }
        Console.WriteLine("Результат умножения матриц");
        MyLib.ArrayMD.PrintArray(numbers_c);
    }
    else Console.WriteLine($"Умножение матриц невозможно, столбцы {length_a} и строки {length_b} у матрицы не равны");
}
Zadacha61();
