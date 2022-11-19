// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

void Task1()
{
    Console.WriteLine("На вход принимается число и выводится третья цифра этого числа.");
    Console.Write("Введите число, состоящее из трёх чисел и более: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int length = number.ToString().Length;

    if (length < 3)
    {
        Console.WriteLine("Введённое число состоит меньше, чем из трёх чисел.");
    }
    else
    {
        Console.WriteLine(Convert.ToString(number)[2]);
    }
}
//Task1();

void Task2()
{
    Console.WriteLine("На вход принимается число и выводится третья цифра этого числа.");
    Console.Write("Введите число, состоящее из трёх чисел и более: ");
    int number = Convert.ToInt32(Console.ReadLine());

    while (number > 1000)
    {
        number /= 10;
        Console.WriteLine(number);
    }
    Console.WriteLine($"Третья цифра числа = {number % 10}.");
}
Task2();

void Task3()
{
    Console.WriteLine("На вход принимается число и выводится третья цифра этого числа.");
    Console.Write("Введите число, состоящее из трёх чисел и более: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    if (number < 100)
    {
        Console.WriteLine("Введённое число состоит меньше, чем из трёх чисел.");
    }
    else if (number > 99 && number < 1000)
    {
        Console.WriteLine($"Третья цифра числа = {number % 10}.");
    }
    while (number > 1000)
    {
        number /= 10;
        Console.WriteLine(number);
        if (number > 99 && number < 1000)
        {
            Console.WriteLine($"Третья цифра числа = {number % 10}.");
        }
    }
}
//Task3();