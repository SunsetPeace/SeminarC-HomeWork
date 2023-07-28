// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int example = number / 100;
if (example != 0)
{
    int thirdDigit = number % 10;
    Console.Write($"{number} -> {thirdDigit}");
}
else
{
    Console.Write("Введено не трёхзначное число");
}

