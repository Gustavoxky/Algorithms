// using System;
// using Accord.Imaging;
// using Accord.Imaging.Filters;

// class FourierTransformExample
// {
//     public static void Main()
//     {
//         // Carregar a imagem
//         var image = new Grayscale(Grayscale.CommonAlgorithms.BT709.Apply(new Bitmap("input_image.png")));

//         // Aplicar a Transformada de Fourier
//         var fourierTransform = new FourierTransform(image);

//         // Obter a magnitude do espectro
//         var magnitude = fourierTransform.ToBitmap();

//         magnitude.Save("fourier_magnitude.png");
//     }
// }
