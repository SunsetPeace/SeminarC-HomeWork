// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int max = 0;
if (number1 > number2)
{
    max = number1;
    if (max > number3)
    {
        Console.Write($"{max} больше {number2} и {number3}");
    }
}
if (number2 > number1)
{
    max = number2;
    if (max > number3)
    {
        Console.Write($"{max} больше {number1} и {number3}");
    }
}
if (number3 > number1)
{
    max = number3;
    if (max > number2)
    {
        Console.Write($"{max} больше {number1} и {number2}");
    }
}
if ((number1 == number2) && (number2 == number3))
{
    Console.Write("Числа равны");
}
if ((number1 == number2) || (number2 > number3))
{
    Console.Write($"Первое число: {number1} равно второму: {number2} и больше третьего: {number3}");
}
if ((number1 == number3) || (number3 > number2))
{
    Console.Write($"Первое число: {number1} равно третьему: {number3} и больше второго: {number2}");
}
if ((number2 == number3) || (number3 > number1))
{
    Console.Write($"Второе число: {number2} равно третьему: {number3} и больше первого: {number1}");
}