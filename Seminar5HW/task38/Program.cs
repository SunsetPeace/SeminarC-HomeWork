// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(int sizeArray)
{
    float[] arrayHandMade = new float[sizeArray];
    Random rand = new Random();
    for (int i = 0; i < arrayHandMade.Length; i++)
        arrayHandMade[i] = rand.Next();
    Console.WriteLine($"В массиве [{string.Join(", ", arrayHandMade)}]");
    Console.WriteLine($"Разница между максимальным и минимальным {GetMax(arrayHandMade) - GetMin(arrayHandMade)}");
}

float GetMax(float[] arrayHandMade)
{
    float max = arrayHandMade[0];
    for (int i = 1; i < arrayHandMade.Length; i++)
        if (arrayHandMade[i] > max)
        {
            max = arrayHandMade[i];
        }
    return max;
}
float GetMin(float[] arrayHandMade)
{
    float min = arrayHandMade[0];
    for (int i = 1; i < arrayHandMade.Length; i++)
        if (arrayHandMade[i] < min)
        {
            min = arrayHandMade[i];
        }
return min;
}

int sizeArray = GetInput("Введите размер массива: ");
GetArray(sizeArray);