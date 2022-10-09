void Zadacha39()
{
    //     Задача 39: Напишите программу, которая перевернёт
    // одномерный массив (последний элемент будет на первом
    // месте, а первый - на последнем и т.д.)
    int size = 5;
    int[] numbers = new int[size];
    MyLib.Array.FillArray(numbers, -10, 10);
    MyLib.Array.PrintArray(numbers);
    ReverseArray(numbers);
    MyLib.Array.PrintArray(numbers);

}
void ReverseArray(int[] numbers)
{
    int maxIndex = numbers.Length - 1;
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
}
void Zadacha40()
{
    //     Задача 40: Напишите программу, которая принимает на вход три
    // числа и проверяет, может ли существовать треугольник со
    // сторонами такой длины.  
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int number3 = Convert.ToInt32(Console.ReadLine());
    if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
    {
        Console.WriteLine($"Треугольник со сторонами {number1}, {number2}, {number3} может существовать");
    }
    else
    {
        Console.WriteLine($"Треугольник со сторонами {number1}, {number2}, {number3} НЕ может существовать");
    }

}
void Zadacha42()
{
    //     Задача 42: Напишите программу, которая будет преобразовывать
    // десятичное число в двоичное.
    int number = 43;
    string result = "";
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    Console.WriteLine(result);

}
void Zadacha44()
{
    //     Задача 44: Не используя рекурсию, выведите первые N чисел
    // Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int[] result = new int[number]; Console.Write("0 1 ");
    for (int i = 2; i < number; i++)
    {
        result[0] = 0;
        result[1] = 1; result[i] = result[i - 1] + result[i - 2]; Console.Write(result[i] + " ");
    }
}
void Zadacha45()
{
    //     Задача 45: Напишите программу, которая будет создавать
    // копию заданного массива с помощью поэлементного
    // копирования.
    Random random = new Random();
    int size = random.Next(4, 10);
    int[] numbers = new int[size];
    MyLib.Array.FillArray(numbers, -10, 10);
    MyLib.Array.PrintArray(numbers);
    int[] numberssecond = new int[size];
    for (int i = 0; i < size; i++)
    {
        numberssecond[i] = numbers[i];
    }
    MyLib.Array.PrintArray(numberssecond);
}





