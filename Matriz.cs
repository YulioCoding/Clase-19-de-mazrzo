class Program
{
    static void Main()
    {
        int filas = 2, cols = 2;
        int[,] matrizA = { { 1, 2 }, { 3, 4 } };
        int[,] matrizB = { { 5, 6 }, { 7, 8 } };
        int[,] resultado = new int[filas, cols];
       
        // --- Matrices Originales (Color Blanco/Gris) ---
        Console.WriteLine("--- Matriz A ---");
        ImprimirMatriz(matrizA, ConsoleColor.White);

        Console.WriteLine("--- Matriz B ---");
        ImprimirMatriz(matrizB, ConsoleColor.White);

        // 2. Suma (Resultado en Verde)
        Console.WriteLine("\n--- Suma (A + B) ---");
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < cols; j++)
                resultado[i, j] = matrizA[i, j] + matrizB[i, j];

        ImprimirMatriz(resultado, ConsoleColor.Green);
       
        // 3. Resta (Resultado en Rojo)
        Console.WriteLine("\n--- Resta (A - B) ---");
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < cols; j++)
                resultado[i, j] = matrizA[i, j] - matrizB[i, j];

        ImprimirMatriz(resultado, ConsoleColor.Red);
               
        // 4. Multiplicación (Resultado en Amarillo)
        int[,] prod = new int[2, 2];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    prod[i, j] += matrizA[i, k] * matrizB[k, j];
       
        Console.WriteLine("\n--- Multiplicación de Matrices ---");
        ImprimirMatriz(prod, ConsoleColor.Yellow);

        // Volver al color normal al final
        Console.ResetColor();
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    // Método actualizado con parámetro de color
    static void ImprimirMatriz(int[,] matriz, ConsoleColor color)
    {
        Console.ForegroundColor = color; // Cambia el color antes de imprimir los números
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ResetColor(); // Restablece el color para que los títulos no se pinten igual
    }
}
