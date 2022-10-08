void Zadacha17()
{
    //     17. Напишите программу, которая принимает на вход
    // координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
    // номер четверти плоскости, в которой находится эта
    // точка.
    Console.WriteLine("Введите Х: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x > 0 & y > 0) Console.WriteLine("1");
    else if (x < 0 & y > 0) Console.WriteLine("2");
    else if (x < 0 & y < 0) Console.WriteLine("3");
    else Console.WriteLine("4");
}
void Zadacha18()
{
    //     Задача 18: Напишите программу, которая по
    // заданному номеру четверти, показывает диапазон
    // возможных координат точек в этой четверти (x и y).
    Console.WriteLine("Введите номер четверти");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1) Console.WriteLine("X(0,+inf) Y(0,+inf)");
    else if (num == 2) Console.WriteLine("X(-inf;0) Y(0,+inf)");
    else if (num == 3) Console.WriteLine("X(-inf;0) Y(-inf;0)");
    else Console.WriteLine("X(0,+inf) Y(-inf;0)");
}
int InputNumber()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}
void Zadacha21()
{
    //     Задача 21: Напишите программу, которая
    // принимает на вход координаты двух точек и
    // находит расстояние между ними в 2D
    // пространстве.
    Console.WriteLine("Введите координаты точки A:");
    Console.Write("x1: ");
    int x1 = InputNumber();
    Console.Write("y1: ");
    int y1 = InputNumber();
    Console.WriteLine("Введите координаты точки B:");
    Console.Write("x2: ");
    int x2 = InputNumber();
    Console.Write("y2: ");
    int y2 = InputNumber();
    Console.WriteLine($"Точки:A({x1},{y1}), B({x2},{y2})");
    Console.WriteLine($"Расстояние между точками A и B: {Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2))}");
}
void Zadacha22()
{
    //     Задача 22: Напишите программу, которая
    // принимает на вход число (N) и выдаёт таблицу
    // квадратов чисел от 1 до N.
    int num = InputNumber();
    int k = 1;
    double qube;
    Console.WriteLine("Таблица квадратов для числа " + num);
    if (num > 0)
    {
        while (k <= num)
        {
            qube = Math.Pow(k, 2);
            Console.WriteLine($"{k}\t{qube}");
            k++;
        }
    }
    else if (num < 0)
    {
        while (k >= num)
        {
            qube = Math.Pow(k, 2);
            Console.WriteLine($"{k}\t{qube}");
            k--;
        }
    }
    else Console.WriteLine(num);

}
Zadacha22();