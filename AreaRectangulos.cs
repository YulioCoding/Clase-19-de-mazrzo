// Calcular el aerea de mil rectangulos

using System;

class AreaRectangulos
{
    static void Main()
    {
        int cantidad = 1000;
        double[] areas = new double[cantidad];
        
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Rectangulo #" + (i + 1));
            
            Console.Write("Base: ");
            double base1 = double.Parse(Console.ReadLine());
            
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine());
            
            areas[i] = base1 * altura;
            
            Console.WriteLine("Area: " +areas[i]);
        }
        
        Console.WriteLine("\n======AREAS DE LOS RECTANGULOS======");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Rectuangulo #" + (i+1) + " | Area: " + areas[i]);
        }
    }
}
