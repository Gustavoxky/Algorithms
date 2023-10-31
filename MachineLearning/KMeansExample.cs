// using System;
// using Accord.MachineLearning;
// using Accord.MachineLearning.VectorMachines;
// using Accord.MachineLearning.VectorMachines.Learning;
// using Accord.MachineLearning.VectorMachines.SupportVector;
// using Accord.MachineLearning.VectorMachines.SupportVector.Machines;

// class KMeansExample
// {
//     public static void Main()
//     {
//         double[][] data =
//         {
//             new double[] { 1.0, 2.0 },
//             new double[] { 2.0, 3.0 },
//             new double[] { 3.0, 4.0 },
//             new double[] { 10.0, 11.0 },
//             new double[] { 11.0, 12.0 },
//             new double[] { 12.0, 13.0 },
//         };

//         int[] clustering = KMeansCluster(data, 2); // Agrupar em 2 clusters

//         for (int i = 0; i < data.Length; i++)
//         {
//             Console.WriteLine($"Data point [{data[i][0]}, {data[i][1]}] belongs to cluster {clustering[i]}");
//         }
//     }

//     private static int[] KMeansCluster(double[][] data, int clusters)
//     {
//         KMeans kmeans = new KMeans(clusters);
//         KMeansClusterCollection result = kmeans.Learn(data);
//         return result.Decide(data);
//     }
// }
