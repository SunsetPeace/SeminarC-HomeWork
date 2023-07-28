// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// int GetInput(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] arrayHandMade = new int[8];
// Random rand = new Random();
// for (int i = 0; i < arrayHandMade.Length; i++)
//     arrayHandMade[i] = rand.Next(0, 100);
// Console.WriteLine("[{0}]", string.Join(", ", arrayHandMade));

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(int quantity)
{
    int count = 1;
    int GetInput(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    int[] arrayHandMade = new int[quantity];
    for (int i = 0; i < arrayHandMade.Length; i++)
        arrayHandMade[i] = GetInput($"Введите {count++} число: ");
    Console.WriteLine("[{0}]", string.Join(", ", arrayHandMade));
}

int quantity = GetInput("Введите размер массива: ");
GetArray(quantity);
