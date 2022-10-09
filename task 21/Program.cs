// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ax, ay, az;
int bx, by, bz;
double result;

Console.WriteLine("Введите посследовательность координат первой точки: ");
Console.Write("x: ");
ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
ay = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите посследовательность координат второй точки: ");
Console.Write("x: ");
bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
by = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
bz = Convert.ToInt32(Console.ReadLine());

result = Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2);
result = Math.Sqrt(result);
result = Math.Round(result, 2);
Console.WriteLine(result);
