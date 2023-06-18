// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Enter_coordinate(string name_coordinate)
{
    Console.Write($"Введите {name_coordinate}: ");
    int coordinate = int.Parse(Console.ReadLine());
    return coordinate;
}

double Find_lenght (int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double Lenght = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
    return Lenght;
}

int x1 = Enter_coordinate("x1");
int y1 = Enter_coordinate("y1");
int z1 = Enter_coordinate("z1");
int x2 = Enter_coordinate("x2");
int y2 = Enter_coordinate("y2");
int z2 = Enter_coordinate("z2");

double lenght = Math.Round(Find_lenght(x1, y1, z1, x2, y2, z2), 2);
Console.Write($"Длина отрезка: {lenght}");