// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FindCube(int number)
{
    int count = number;
    while (count != 0)
    {
        count--;
        int newNumber = number - count;
        Console.Write($" {newNumber} x {newNumber} x {newNumber} = ");
        int sqr = newNumber * newNumber * newNumber;
        Console.WriteLine(sqr);
    }
}

int number = GetInput("Введите число: ");
FindCube(number);