﻿// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int newNumber = number / 10;
int secondDigit = newNumber % 10;
Console.Write($"{number} -> {secondDigit}");
