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
void Task34()
{
    //Задайте массив заполненный случайными трёхзначными числами. Напишите
    //программу, которая покажет количество чётных чисел в массиве.
    Random random = new Random();
    int size = random.Next(4, 11);
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    CountEvenNumbers(numbers);
}
void CountEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}
void Task36()
{// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечетными индексами.
    Random random = new Random();
    int size = random.Next(5, 11);
    int[] numbers = new int[size];
    FillArray(numbers, -100, 101);
    PrintArray(numbers);
    SummUnevenIndex(numbers);
}
void SummUnevenIndex(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum = numbers[i] + sum;
    }
    Console.WriteLine($"Сумма элементов с нечетными индексами: {sum}");
}
void Task38()
{//Задача 38: Задайте массив вещественных чисел. Найдите разницу
 // между максимальным и минимальным элементов массива.
    Random random = new Random();
    int size = random.Next(5, 11);
    double[] numbers = new double[size];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
    FindMaxAndMinValue(numbers);
   
}
void FindMaxAndMinValue(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];
    for (int i =1; i < numbers.Length; i++)
    {
        if (numbers[i]>max)
        {
            max = numbers[i];
        }
        else if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    double diff = max - min;
    Console.WriteLine("Разность между максимальным и минимальным элементом"+"{0,6:F2}",diff);
}
void FillArrayDouble(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.NextDouble()*100;
    }
}
void PrintArrayDouble(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("{0,6:F2}", numbers[i]);
    }
    Console.WriteLine("");
}
Task34();
Task36();
Task38();