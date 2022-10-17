void Zadacha1()
{// Задача 1. Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число.
 // Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая 
 //с введённым числом.
    int[] numbers = new int[15];
    MyLib.Array.FillArray(numbers, 0, 9);
    MyLib.Array.PrintArray(numbers);
    Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < 15; i++)
    {
        if (numbers[i] == num / 100)
        {
            if (numbers[i + 1] == num / 10 % 10 && numbers[i + 2] == num % 10)
            {
                Console.WriteLine("В массиве есть последовательность из цифр " + num);
                i = 15;
            }
        }
        else if (i == 12)
        {
            Console.WriteLine("Последовательности нет");
        }

    }

}
void Zadacha2()
{
    // Задача 2. На вход подаются два числа случайной длины. Найдите произведение каждого разряда 
    // первого числа на каждый разряд второго. Ответ запишите в массив.
    // 24, 132 -> {2, 6, 4, 4, 12, 8}
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int size = CountSize(number1, number2);
    int a = 0;
    int b = 0;
    int[] numbers = new int[size];
    a = number1;
    while (a != 0)
    {
        b = number2;
        while (b != 0)
        {
            numbers[size - 1] = (a % 10) * (b % 10);
            b = b / 10;
            size = size - 1;
        }
        a = a / 10;
    }


    MyLib.Array.PrintArray(numbers);

}
int CountSize(int number1, int number2, int size = 0)
{
    int count1 = 0;
    int count2 = 0;
    while (number1 != 0)
    {
        number1 = number1 / 10;
        count1++;
    }
    while (number2 != 0)
    {
        number2 = number2 / 10;
        count2++;
    }
    return size = count1 * count2;
}
void Zadacha3()
{
    // Задача 3. Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. 
    //Подсчитайте их количество.
    int size = 1000000;
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = i + 1;
    }
    int sum = 0;
    int pow = 1;
    int count = 0;
    int num = 0;
    for (int j = 0; j < size; j++)
    {
        sum = 0;
        pow = 1;
        num = numbers[j];
        while (num > 0)
        {
            sum = sum + (num % 10);
            pow = pow * (num % 10);
            num = num / 10;
        }
        if (sum * 3 == pow)
        {
            count++;
            
            //Console.WriteLine(numbers[j]);
        }
    }
    Console.WriteLine(count);
}

// Задача 1*. Дан массив массивов, состоящих из натуральных чисел, размер которого 5.
// Для каждого элемента-массива требуется найти сумму его элементов и вывести массив с наибольшей суммой.
// Если таких массивов несколько, вывести массив с наименьшим индексом.

// https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/arrays/jagged-arrays
Zadacha3();