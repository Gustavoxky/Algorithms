// using System;

// class Particle
// {
//     public double Position { get; set; }
//     public double Velocity { get; set; }
//     public double BestPosition { get; set; }
// }

// class ParticleSwarmOptimization
// {
//     private static Random random = new Random();

//     public static double Optimize(int numParticles, int iterations)
//     {
//         Particle[] particles = InitializeParticles(numParticles);
//         double globalBest = particles[0].Position;

//         for (int iteration = 0; iteration < iterations; iteration++)
//         {
//             foreach (Particle particle in particles)
//             {
//                 UpdateVelocity(particle, globalBest);
//                 UpdatePosition(particle);
//                 UpdateBestPosition(particle);
//             }

//             globalBest = particles[0].BestPosition;

//             foreach (Particle particle in particles)
//             {
//                 if (particle.BestPosition < globalBest)
//                     globalBest = particle.BestPosition;
//             }
//         }

//         return globalBest;
//     }

//     private static Particle[] InitializeParticles(int numParticles)
//     {
//         Particle[] particles = new Particle[numParticles];
//         for (int i = 0; i < numParticles; i++)
//         {
//             particles[i] = new Particle
//             {
//                 Position = random.NextDouble() * 10,
//                 Velocity = random.NextDouble() - 0.5,
//                 BestPosition = 0
//             };
//             particles[i].BestPosition = particles[i].Position;
//         }
//         return particles;
//     }

//     private static void UpdateVelocity(Particle particle, double globalBest)
//     {
//         double inertiaWeight = 0.4;
//         double cognitiveWeight = 1.5;
//         double socialWeight = 1.5;

//         double r1 = random.NextDouble();
//         double r2 = random.NextDouble();

//         double cognitiveComponent = cognitiveWeight * r1 * (particle.BestPosition - particle.Position);
//         double socialComponent = socialWeight * r2 * (globalBest - particle.Position);

//         particle.Velocity = inertiaWeight * particle.Velocity + cognitiveComponent + socialComponent;
//     }

//     private static void UpdatePosition(Particle particle)
//     {
//         particle.Position += particle.Velocity;
//     }

//     private static void UpdateBestPosition(Particle particle)
//     {
//         if (particle.Position < particle.BestPosition)
//             particle.BestPosition = particle.Position;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         int numParticles = 50;
//         int iterations = 100;
//         double result = ParticleSwarmOptimization.Optimize(numParticles, iterations);
//         Console.WriteLine($"Melhor solução encontrada: {result}");
//     }
// }
