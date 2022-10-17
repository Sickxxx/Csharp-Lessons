void Zadacha1()
{// Задача 1. На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.
    Console.WriteLine("Введите число от 1 до 9");
    int number = Convert.ToInt32(Console.ReadLine());
    string result = "";
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    Console.WriteLine(result);
    int result1 = Convert.ToInt32(result);
    if (result1 > 1 && result1 < 100)
    {
        if (result1 / 10 == result1 % 10) Console.WriteLine($"число {number} в двоичной системе {result1} является палиндромом");
        else Console.WriteLine($"число {number} в двоичной системе {result1} не является палиндромом");
    }
    if (result1 >= 100 && result1 < 1000)
    {
        if (result1 / 100 == result1 % 10) Console.WriteLine($"число {number} в двоичной системе {result1} является палиндромом");
        else Console.WriteLine($"число {number} в двоичной системе {result1} не является палиндромом");
    }
    if (result1 >= 1000 && result1 < 10000)
    {
        if (result1 / 1000 == result1 % 10 && result1 / 100 % 10 == result1 / 10 % 10) Console.WriteLine($"число {number} в двоичной системе {result1} является палиндромом");
        else Console.WriteLine($"число {number} в двоичной системе {result1} не является палиндромом");
    }

}
void Zadacha2()
{
    // Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. 
    //Размер массива должен совпадать с квадратом количества единиц в нём.
    Console.WriteLine("Введите количество единиц от 1 до 10: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[numb * numb];
    //MyLib.Array.FillArray(numbers, 0, 1);
    for (int i = 0; i < numbers.Length; i+=numb)
    {
        numbers[i]= 1;
    }
    MyLib.Array.PrintArray(numbers);
}
void Zadacha3()
{
    // Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. 
    //Определите самый часто встречающийся элемент в массиве. Если таких элементов несколько, вывести их все.
    int size = 50;
    int[] numbers = new int[size];
    MyLib.Array.FillArray(numbers, 1, 20);
    MyLib.Array.PrintArray(numbers);
    int max = 0;
    int maxind = 0;
    bool flag = false;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] == numbers[i = 1])
        {
            flag = true;
            maxind = numbers[i];
        }

    }
    Console.WriteLine($"Самый часто встречающийся элемент {maxind}");

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


    // Создание игры: 

    // Задача 1*. С помощью команд очистки консоли и печати реализовать игру-бродилку в консоли.
    // https://docs.microsoft.com/ru-ru/dotnet/api/system.console.clear?view=net-6.0
    // https://docs.microsoft.com/ru-ru/dotnet/api/system.console.setcursorposition?view=net-6.0
    // https://docs.microsoft.com/ru-ru/dotnet/api/system.console.readkey?view=net-6.0
    // https://docs.microsoft.com/ru-ru/dotnet/api/system.consolekey?view=net-6.0

    // Задача 2*. Создать игру лабиринт.
    Zadacha2();