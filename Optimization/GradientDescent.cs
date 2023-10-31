// using System;

// class GradientDescent
// {
//     public static double Optimize(Func<double, double> gradient, double learningRate, int iterations)
//     {
//         double x = 0; // Valor inicial
//         for (int i = 0; i < iterations; i++)
//         {
//             double gradientValue = gradient(x);
//             x -= learningRate * gradientValue; // Atualização usando o gradiente
//         }
//         return x;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Exemplo de otimização de função simples: f(x) = x^2
//         Func<double, double> gradient = x => 2 * x;
//         double learningRate = 0.1;
//         int iterations = 100;
//         double result = GradientDescent.Optimize(gradient, learningRate, iterations);
//         Console.WriteLine($"Melhor solução encontrada: {result}");
//     }
// }
