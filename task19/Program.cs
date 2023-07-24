// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void ShowPalindrom(int number)
{
    int firstNumber = number / 10000;
    Console.WriteLine(firstNumber);
    int lastNumber = number % 10;
    Console.WriteLine(lastNumber);
    int secondNumber = (number / 1000) % 10;
    Console.WriteLine(secondNumber);
    int preLastNumber = (number % 100) / 10;
    Console.WriteLine(preLastNumber);
    if (firstNumber == lastNumber & secondNumber == preLastNumber)
    {
        Console.WriteLine($"{number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} не является палиндромом");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите пятизначное число: ");

ShowPalindrom(number);