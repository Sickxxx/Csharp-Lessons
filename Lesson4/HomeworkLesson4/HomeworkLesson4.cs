void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(-100, 101);
    }
}
void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
}
void Task1()
{
    // Используя определение степени числа, напишите цикл, который
    // принимает на вход два числа и возводит число А в степень В.
    Console.WriteLine("Введте число А: ");
    int number_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введте число B: ");
    int number_b = Convert.ToInt32(Console.ReadLine());
    int degree = 1;
    for (int i = 1; i <= number_b; i++)
    {
        degree = degree * number_a;
    }
    Console.WriteLine($"Число {number_a} в степени {number_b}: {degree}");
}
void Task2()
{
    //Напишите программу, которая принимает на вход число
    // и выдает сумму цифр в числе
    Console.WriteLine("Введте число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int number2 = number;
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр в числе {number2}: {sum}");
}
void Task3()
{
    // Напишите программу, которая задает массив из 8 случайных целых чисел и выводит 
    // отсортированный по модулю массив
    Console.WriteLine("Введите длину массива: ");
    int array_size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[array_size];
    FillArray(numbers);
    PrintArray(numbers);
    while (array_size > 1)
    {
        int max = Math.Abs(numbers[0]);
        int i = 0;
        int max_index = 0;
        while (i < array_size)
        {
            if (Math.Abs(numbers[i]) >= max)
            {
                max = Math.Abs(numbers[i]);
                max_index = i;

            }
            i = i + 1;
        }
        int current_number = numbers[array_size - 1];
        numbers[array_size - 1] = numbers[max_index];
        numbers[max_index] = current_number;
        array_size = array_size - 1;
    }
    Console.WriteLine("");
    Console.WriteLine("Отсортированный массив:");
    PrintArray(numbers);
}
Task1();
Task2();
Task3();