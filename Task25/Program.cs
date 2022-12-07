Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("В какую степень вы хотите его возвести: ");
double degree = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{num} в степени {degree} = {Math.Pow(num, degree)} ");