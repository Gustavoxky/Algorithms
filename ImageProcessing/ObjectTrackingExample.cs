// using System;
// using Accord.Video.FFMPEG;
// using Accord.Video.VFW;
// using Accord.Imaging.Filters;
// using Accord.Vision.Tracking;
// using Accord.Vision.Tracking.Multiple;

// class ObjectTrackingExample
// {
//     public static void Main()
//     {
//         // Inicializar o leitor de vídeo
//         var videoSource = new FileVideoSource("input_video.avi");
//         videoSource.Start();

//         // Criar o rastreador de objetos
//         var tracker = new BlobTracker();

//         while (videoSource.IsRunning)
//         {
//             // Capturar o próximo quadro de vídeo
//             var frame = videoSource.WaitForVideoFrame();

//             // Rastrear objetos no quadro
//             tracker.ProcessFrame(frame);

//             // Desenhar os objetos rastreados no quadro
//             var objects = tracker.TrackingObjects;
//             foreach (var trackingObject in objects)
//             {
//                 // Desenhar um retângulo ao redor do objeto
//                 var rectangle = trackingObject.Rectangle;
//                 frame.Draw(rectangle, new Bgr(System.Drawing.Color.Red), 2);
//             }

//             // Exibir o quadro com os objetos rastreados
//             frame.Show();
//         }

//         videoSource.SignalToStop();
//     }
// }
