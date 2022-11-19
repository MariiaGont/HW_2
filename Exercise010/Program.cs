// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("На вход принимается трёхзначное число и выводится вторая цифра этого числа.");
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int length = number.ToString().Length;
int result = ((number / 10) % 10);

if (length == 3) 
{
    Console.WriteLine($"{result} - вторая цифра введённого числа.");
}
else
{
    Console.WriteLine("Введённое число не является трёхзначным.");
}