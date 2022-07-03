/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в трехмерном пространстве
A (3, 6, 8) ; B (2, 1, -7) - 15.84
A (7, -5, 0); B (1, -1, 9) - 11.53 */

Console.WriteLine("Введите координату X первой точки: ");
int userX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int userY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int userZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки: ");
int userX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int userY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int userZ2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(userX1 - userX2,2) + Math.Pow(userY1 - userY2,2) + Math.Pow(userZ1 - userZ2,2));
Console.WriteLine($"Расстояние между двумя точками [{userX1}, {userY1}, {userZ1}]:[{userX2},{userY2}, {userZ2}] равно {Math.Round(distance,2)} ");