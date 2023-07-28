// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


void ShowDistance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance = distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine(distance);
}

double GetInput(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetInput("Введите координату x1: ");
double x2 = GetInput("Введите координату x2: ");
double y1 = GetInput("Введите координату y1: ");
double y2 = GetInput("Введите координату y2: ");
double z1 = GetInput("Введите координату z1: ");
double z2 = GetInput("Введите координату z2: ");
ShowDistance(x1, x2, y1, y2, z1, z2);