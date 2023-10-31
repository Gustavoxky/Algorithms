// using System;
// using Accord.MachineLearning;
// using Accord.MachineLearning.DecisionTrees;
// using Accord.MachineLearning.VectorMachines;
// using Accord.MachineLearning.VectorMachines.Learning;
// using Accord.MachineLearning.VectorMachines.SupportVector;
// using Accord.MachineLearning.VectorMachines.SupportVector.Machines;

// class DecisionTreeExample
// {
//     private static void Main()
//     {
//         double[][] inputs = 
//         {
//             new double[] { 1.0, 2.0 },
//             new double[] { 2.0, 3.0 },
//             new double[] { 3.0, 4.0 },
//             new double[] { 4.0, 5.0 },
//         };

//         int[] outputs = { 0, 1, 1, 0 }; // 0 indica uma classe, 1 indica outra

//         DecisionVariable[] variables =
//         {
//             new DecisionVariable("Feature 1", DecisionVariableKind.Continuous),
//             new DecisionVariable("Feature 2", DecisionVariableKind.Continuous),
//         };

//         var tree = new DecisionTree(variables);
//         var id3learning = new C45Learning(tree);

//         id3learning.Run(inputs, outputs);

//         int prediction = tree.Decide(inputs[0]);
//         Console.WriteLine("Predicted class for [1.0, 2.0]: " + prediction);
//     }
// }
