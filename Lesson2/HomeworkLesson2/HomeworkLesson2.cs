void Task10()
{
    //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
    //на выходе показывает вторую цифру этого числа.
    Console.WriteLine("Введите трехзначное число:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вторая цифра в числе:" + (num / 10) % 10);


}
void Task13()
{
    //Задача 13: Напишите программу, которая с помощью деления выводит третью цифру
    // заданного числа или сообщает, что третьей цифры нет.
    Console.WriteLine("");
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int num = Math.Abs(number);
    if (num % 100 == num) Console.WriteLine("Третьей цифры нет");
    else
    {
        while (num / 10 > 100)
        {
            num = num / 10;

        }
        Console.WriteLine("Третья цифра в числе: " + num % 10);
    }
}

void Task15()
{
    //Задача 15: Напишите программу, которая принимает на вход цифру, 
    //обозначающую день недели, и проверяет, является ли этот день выходным.
    Console.WriteLine("");
    Console.WriteLine("Введите число от 1 до 7 ми:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 6 || num == 7) Console.WriteLine("Выходной");
    else Console.WriteLine("НЕ выходной");
}

//Task10();
Task13();
//Task15();