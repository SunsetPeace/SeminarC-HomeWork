// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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
    Console.WriteLine($"{GetEvenNumbers(arrayHandMade)} чётных чисел.");
}

int GetEvenNumbers(int[] arrayHandMade)
{
    int countEven = 0;
    for (int i = 0; i < arrayHandMade.Length; i++)
        if (arrayHandMade[i] % 2 == 0)
        {
            countEven++;
        }
    return countEven;
}


int sizeArray = GetInput("Введите размер массива: ");
GetArray(sizeArray);