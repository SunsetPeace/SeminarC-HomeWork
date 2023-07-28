﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int FindDegreeOfNumber(int numberA, int numberB)
{
    int degree = 1;
    int result = numberA;
    while (degree < numberB)
    {
        degree++;
        result *= numberA;
        Console.WriteLine($"{numberA}^{degree} = {result}");
    }
    return result;
}

int numberA = GetInput("Введите число A: ");
int numberB = GetInput("Введите степень числа A: ");
FindDegreeOfNumber(numberA, numberB);