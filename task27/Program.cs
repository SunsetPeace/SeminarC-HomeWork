// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumInNumber(int number)
{
int result = 0;
    while (number > 0)
    {
        int variable_num = number % 10;
        result += variable_num;
        number /= 10;
    }
    return result;
}

int number = GetInput("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {number} = {GetSumInNumber(number)}");