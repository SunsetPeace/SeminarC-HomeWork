// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int res = 0;
int divider = 0;
int half = 0;
Console.Write("Чётные числа: ");
if (number%2 != 0)
{
    number = number -1;
    half = number / 2;
    while (count < half)
    {
        res = number - divider;
        Console.Write($"{res} | " );
        divider += 2;
        count++;
    }
}
if (number%2 == 0)
    {
        half = number / 2;
        while (count < half)
        {
            res = number - divider;
            Console.Write($"{res} | " );
            divider += 2;
            count++;
        }
    }

