using System;

class Program
{
     static void Main(string[] args)
    {
        Console.ForegroundColor= ConsoleColor.Cyan;
        Console.WriteLine ("===PERIMETRO DE UN CUADRADO===");
        Console.ResetColor();
         
        Console.Write("Ingresa el lado de un cuadrado:");
        double lado = double.Parse(Console.ReadLine());
        double perimetro = lado * 4;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"El perímetro es: {perimetro}\n");
        Console.ResetColor();
       
       
         Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== Área de un Rectángulo ===");
        Console.ResetColor();

        Console.Write("Ingresa la base: ");
        double baseRect = double.Parse(Console.ReadLine());
        Console.Write("Ingresa la altura: ");
        double alturaRect = double.Parse(Console.ReadLine());
        double area = baseRect * alturaRect;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"El área es: {area}");
       
        Console.ResetColor();
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
       
    }
}
