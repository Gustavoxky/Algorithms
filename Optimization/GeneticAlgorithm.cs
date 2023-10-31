using System;
using System.Linq;

namespace Generic;

class GeneticAlgorithm
{
    private static Random random = new Random();

    public static double Optimize(int populationSize, int generations)
    {
        double[] population = InitializePopulation(populationSize);
        double bestSolution = population[0];

        for (int generation = 0; generation < generations; generation++)
        {
            double[] newPopulation = new double[populationSize];

            for (int i = 0; i < populationSize; i++)
            {
                double parent1 = SelectParent(population);
                double parent2 = SelectParent(population);
                double child = Crossover(parent1, parent2);
                child = Mutate(child);
                newPopulation[i] = child;

                if (child < bestSolution)
                    bestSolution = child;
            }

            population = newPopulation;
        }

        return bestSolution;
    }

    private static double[] InitializePopulation(int populationSize)
    {
        double[] population = new double[populationSize];
        for (int i = 0; i < populationSize; i++)
        {
            population[i] = random.NextDouble() * 10; // Inicialização aleatória
        }
        return population;
    }

    private static double SelectParent(double[] population)
    {
        // Seleção de pais simples: escolha um indivíduo aleatório da população.
        return population[random.Next(population.Length)];
    }

    private static double Crossover(double parent1, double parent2)
    {
        // Crossover simples: média ponderada dos pais.
        return (parent1 + parent2) / 2;
    }

    private static double Mutate(double child)
    {
        // Mutação simples: adicione um valor aleatório pequeno.
        return child + (random.NextDouble() - 0.5);
    }
}

// class Program
// {
//     static void Main()
//     {
//         int populationSize = 50;
//         int generations = 100;
//         double result = GeneticAlgorithm.Optimize(populationSize, generations);
//         Console.WriteLine($"Melhor solução encontrada: {result}");
//     }
// }
