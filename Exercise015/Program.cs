// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void Task1()
{
    Console.WriteLine("Проверка дня недели на выходной по его порядковому номеру.");
    Console.Write("Введите порядковый номер от одного до семи включительно: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if ((number > 0 && number < 8) && (number == 6 || number == 7))
    {
        Console.WriteLine("Ура! Выходной!");
    }
    else if (number > 0 && number < 6)
    {
        Console.WriteLine("Пока работаем :(");
    }
    else
    {
        Console.WriteLine("Введённому номеру не соответствует ни один день недели.");
    }
}
// Task1();

void Task2()
{
    Console.WriteLine("Проверка дня недели на выходной по его порядковому номеру.");
    Console.Write("Введите порядковый номер от одного до семи включительно: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 1 || number > 7)
    {
        Console.WriteLine("Введённому номеру не соответствует ни один день недели.");
    }
    else if (number == 6 || number == 7)
    {
       Console.WriteLine("Ура! Выходной!"); 
    }
    else if (number > 0 && number < 6)
    {
        Console.WriteLine("Пока работаем :(");
    }
}
Task2();

void Task3()
{
    Console.WriteLine("Проверка дня недели на выходной по его порядковому номеру.");
    Console.Write("Введите порядковый номер от одного до семи включительно: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 1 || number > 7)
    {
        Console.WriteLine("Введённому номеру не соответствует ни один день недели.");
    }
    else if (number == 7)
    {
        Console.WriteLine("Воскресень! Аккуратно отдыхаем! Скоро работаем...");
    }
    else if (number == 6)
    {
        Console.WriteLine("Суббота! Ура, выходной!");
    }
    else if (number == 5)
    {
        Console.WriteLine("Пятница. Последний день работаем :)");
    }
    else if (number == 4)
    {
        Console.WriteLine("Четверг. Ещё немного работаем, и скоро выходной...");
    }
    else if (number == 3)
    {
        Console.WriteLine("Среда. Пока работаем.");
    }
    else if (number == 2)
    {
        Console.WriteLine("Вторник. Рано отдыхать -_-, пока работаем!");
    }
    else if (number == 1)
    {
        Console.WriteLine("Понедельник. Какой выходной? Только начнём работать!");
    }
}
//Task3();