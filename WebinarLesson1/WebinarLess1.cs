void Zadacha1()
{
    // 1. Напишите программу, которая на вход принимает два
    //числа и проверяет, является ли первое число квадратом второго.
    Console.WriteLine("Введите первое число: ");
    int numberfirst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numbersecond = Convert.ToInt32(Console.ReadLine());
    if (numberfirst * numberfirst == numbersecond)
    {
        Console.WriteLine($"Число {numbersecond} является квадратом {numberfirst}");
    }
    else Console.WriteLine($"Число {numbersecond} Не является квадратом {numberfirst}");
}
void Zadacha3()
{
    //Напишите программу, которая будет выдавать
    // название дня недели по заданному номеру.
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0 && number < 8)
    {
        if (number == 1) Console.WriteLine("Понедельник");
        if (number == 2) Console.WriteLine("Вторник");
        if (number == 3) Console.WriteLine("Среда");
        if (number == 4) Console.WriteLine("Четверг");
        if (number == 5) Console.WriteLine("Пятница");
        if (number == 6) Console.WriteLine("Суббота");
        if (number == 7) Console.WriteLine("Воскресенье");
    }
    else Console.WriteLine("Число не соответствует дню недели");
}
void Zadacha5()
{
    //     5. Напишите программу вычисления значения
    // функции возведения числа в квадрат
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Число {number} в квадрате равно {number * number}");
}
void Zadacha7()
{
    // 7. Напишите программу, которая на вход принимает одно число
    // (N), а на выходе показывает все целые числа в промежутке от -N до N.
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int N =-number;
    while (N<=number)
    {
        Console.Write(N+" ");
        N+=1;
    }

}
Zadacha7();