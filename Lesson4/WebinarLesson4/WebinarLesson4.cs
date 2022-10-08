void Zadacha24()
{
    // Задача 24: Напишите программу, которая
    // принимает на вход число (А) и выдаёт сумму чисел
    // от 1 до А.
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine(sum);
}

void Zadacha26()
{
    //     Решение в группах задач:
    // Задача 26: Напишите программу, которая принимает
    // на вход число и выдаёт количество цифр в числе.
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (num != 0)
    {
        num = num / 10;
        sum += 1;
    }
    Console.WriteLine(sum);
}
void Zadacha28()
{
    // Задача 28: Напишите программу, которая
    // принимает на вход число N и выдаёт
    // произведение чисел от 1 до N.
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 1;
    for (int i = 2; i <= num; i++)
    {
        sum = sum * i;
    }
    Console.WriteLine(sum);
}
void Zadacha30()
{
    //     Задача 30: Напишите программу, которая
    // выводит массив из 8 элементов, заполненный
    // нулями и единицами в случайном порядке.
    int size = 8;
    int[] numb = new int[size];
    FillArray(numb, 0, 1);
    PrintArray(numb);
}
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
Zadacha30();