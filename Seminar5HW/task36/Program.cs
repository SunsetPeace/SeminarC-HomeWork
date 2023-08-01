// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(int sizeArray)
{
    int[] arrayHandMade = new int[sizeArray];
    Random rand = new Random();
    for (int i = 0; i < arrayHandMade.Length; i++)
        arrayHandMade[i] = rand.Next(100, 1000);
    Console.WriteLine($"В массиве [{string.Join(", ", arrayHandMade)}]");
    Console.WriteLine($"Сумма чисел на нечётных позициях равна {GetUnEvenNumbers(arrayHandMade)}");
}

int GetUnEvenNumbers(int[] arrayHandMade)
{
    int unEvenSum = arrayHandMade[0];
    for (int i = 1; i < arrayHandMade.Length; i++)
        if (i % 2 == 0)
        {
            unEvenSum += arrayHandMade[i];
        }
    return unEvenSum;
}

int sizeArray = GetInput("Введите размер массива: ");
GetArray(sizeArray);