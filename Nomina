// Desarrollar un programa que permita calcular la nomina de 50 empleados, guarde los datos en una matriz y muestra el salario neto en un vector 
using System;

class Nomina
{
    static void Main()
        {
            string nombre;
            int empleados = 50;
            string[,] datos = new string [empleados , 3];
            
            double [] salarioNeto = new double [empleados];
            
            for (int i = 0; i < empleados; i++)
            {
                Console.WriteLine("Empleado #" + (i + 1));
                
                Console.Write("Nombre :");
                datos[i, 0] = Console.ReadLine();
                
                Console.Write("Cargo: ");
                datos[i, 1] = Console.ReadLine();
                
                Console.Write("Salario bruto: ");
                double salarioBruto = double.Parse(Console.ReadLine());
                datos[i, 2] = salarioBruto.ToString();
                
                double descuentos = salarioBruto * 0.08;
                salarioNeto[i] = salarioBruto - descuentos;
            }
            
            Console.WriteLine("\n======NOMINA DE EMPLEADOS======");
            for (int i = 0; i < empleados; i++)
            {
                if (salarioNeto[i] < 2000000 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                
                Console.WriteLine("Empleado: " + datos[i, 0] + " | Cargo: " + datos[i,1] + " | Salario Neto: " + salarioNeto[i]);
                
                Console.ResetColor();
            }
        }
}    
