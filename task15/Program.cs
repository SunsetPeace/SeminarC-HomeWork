// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] daysOfWeek = {
"Нулевого дня не бывает",
"Monday", "Tuesday", "Wednesday", 
"Thursday", "Friday", "Saturday", 
"Sunday"
};
if (number == 6 | number == 7)
{
    Console.Write($"{daysOfWeek[number]} Это выходной");
}
if (number > 7)
{
    Console.Write("В неделе 7 дней");
}
if (number < 0)
{
    Console.Write("В неделе 7 дней");
}
if (number > -1 & number < 6)
{
    Console.Write($"{daysOfWeek[number]} Не выходной");
}