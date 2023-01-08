//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//  A (3,6,8); B (2,1,-7), -> 15.84
//  A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки А по x: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки А по y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки А по z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по х: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по у: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int chastnoe1 = x2 -x1;
int chastnoe2 = y2 - y1;
int chastnoe3 = z2 - z1;

double result1 = Math.Pow(chastnoe1, 2);
double result2 = Math.Pow(chastnoe2, 2);
double result3 = Math.Pow(chastnoe3, 2);

double sum = result1 + result2 + result3;

double sqrt = Math.Sqrt(sum);

Console.Write("Ответ: " + Math.Sqrt(sum));
