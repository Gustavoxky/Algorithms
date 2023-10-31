// using System;
// using Accord.MachineLearning;
// using Accord.MachineLearning.VectorMachines;
// using Accord.MachineLearning.VectorMachines.Learning;
// using Accord.MachineLearning.VectorMachines.SupportVector;
// using Accord.MachineLearning.VectorMachines.SupportVector.Machines;
// using Accord.Statistics.Kernels;

// class LinearRegressionExample
// {
//     public static void Main()
//     {
//         double[][] inputs = 
//         {
//             new double[] { 1.0, 2.0 },
//             new double[] { 2.0, 3.0 },
//             new double[] { 3.0, 4.0 },
//             new double[] { 4.0, 5.0 },
//         };

//         double[] outputs = { 3.0, 4.0, 5.0, 6.0 };

//         var machine = new SupportVectorMachine<Gaussian>(inputs: 2);

//         var teacher = new SequentialMinimalOptimization<Gaussian>()
//         {
//             Complexity = 100 // Controla a complexidade do modelo
//         };

//         double error = teacher.Run(machine, inputs, outputs);

//         double[] prediction = machine.Decide(inputs[0]);
//         Console.WriteLine("Predicted output for [1.0, 2.0]: " + prediction[0]);
//     }
// }
