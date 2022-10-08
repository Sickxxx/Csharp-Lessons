void FillArray(int[] numbers, int minValue = 0, int maxValue = 100)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine("");
}
void Zadacha31()
{
    //     Задача 31: Задайте массив из 12 элементов, заполненный
    // случайными числами из промежутка [-9, 9]. Найдите сумму
    // отрицательных и положительных элементов массива.
    // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
    // положительных чисел равна 29, сумма отрицательных равна -20.
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 10);
    PrintArray(numbers);
    SumNegative(numbers);
    SumPositive(numbers);

}
void SumPositive(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum += numbers[i];
        }
    }
    Console.WriteLine($"Сумма положительных элементов: {sum}");
}
void SumNegative(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            sum += numbers[i];
        }
    }
    Console.WriteLine($"Сумма отрицательных элементов: {sum}");
}
void Zadacha32()
{
    //     Задача 32: Напишите программу замены элементов
    // массива: положительные элементы замените на
    // соответствующие отрицательные, и наоборот.
    Random random = new Random();
    int size = random.Next(3, 10);
    int[] numbers = new int[size];
    FillArray(numbers, -10, 11);
    PrintArray(numbers);
    ChangeElement(numbers);
    PrintArray(numbers);
}
void ChangeElement(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = -numbers[i];
    }

}
void Zadacha33()
{
    //     Задача 33: Задайте массив. Напишите программу, которая
    // определяет, присутствует ли заданное число в массиве
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    Console.WriteLine("Введите число для поиска: ");
    int value = Convert.ToInt32(Console.ReadLine());
    FindValue(numbers, value);
}
void FindValue(int[] numbers, int value)
{
    bool flag = false;
    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     if (numbers[i] == value)
    //     {
    //         flag = !flag;
    //     }
    // }
    int i = 0;
    while (!flag && i < numbers.Length)
    {
        if (value == numbers[i])
        {
            flag = true;
        }
        i++;
    }

    if (flag)
    {
        Console.WriteLine($"Число {value}  находится в массиве");
    }
    else
    {
        Console.WriteLine($"Число {value} Не находится в массиве");
    }
}
void Zadacha35()
{
    //     Задача 35: Задайте одномерный массив из 10 случайных чисел.
    // Найдите количество элементов массива, значения которых лежат в
    // отрезке [10,99].
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -100, 200);
    PrintArray(numbers);
    int j = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] <= 99)
        {
            j++;
        }
    }
    Console.WriteLine($"Колличество искомых элементов {j}");
}
void Zadacha37()
{
    //     Найдите произведение пар чисел в одномерном массиве.
    // Парой считаем первый и последний элемент, второй и предпоследний
    // и т.д. Результат запишите в новом массиве.
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 11);
    PrintArray(numbers);
    int MaxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        Console.WriteLine($"{numbers[i]} * {numbers[MaxIndex - i]} = {numbers[i] * numbers[MaxIndex - i]}");
    }
    if (size % 2 == 1)
    {
        Console.WriteLine(numbers[size / 2]);
    }
    Console.WriteLine("");
}
Zadacha37();