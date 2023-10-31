// using System;
// using System.Collections.Generic;

// class Segmentation
// {
//     private Dictionary<int, byte[]> segments;

//     public Segmentation()
//     {
//         segments = new Dictionary<int, byte[]>();
//     }

//     public void AllocateSegment(int segmentId, int size)
//     {
//         byte[] segment = new byte[size];
//         segments[segmentId] = segment;
//     }

//     public byte[] AccessSegment(int segmentId)
//     {
//         if (segments.ContainsKey(segmentId))
//         {
//             return segments[segmentId];
//         }
//         else
//         {
//             throw new KeyNotFoundException("Segment not found.");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Segmentation segmentation = new Segmentation();
//         segmentation.AllocateSegment(1, 1024);
//         byte[] segmentData = segmentation.AccessSegment(1);
//     }
// }
