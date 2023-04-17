// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// code .\src\ConsoleUI\Program.cs
double perimetro;
double area;
double volumen;

Console.WriteLine("Calculadora de Perímetro y Area del Cuadrado; y Volumen de un Prisma Cuadrangular");

Console.Write("Dame el lado 1 (base): ");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame el lado 2: ");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame el lado 3: ");
double lado3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la altura del prisma: ");
double altura_prisma = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la altura del prisma: ");
double lado4 = Convert.ToDouble(Console.ReadLine());

perimetro = Application.Paralelogramo.Perimetro(lado1,lado2,lado3,lado4);
area = Application.Paralelogramo.Area(lado1,altura);
volumen = Application.Paralelolipedo.Volumen(area, altura_prisma);

Console.WriteLine();
Console.WriteLine($"Perímetro: {perimetro}cm\nÁrea: {area}cm2\nVolumen {volumen}cm3");