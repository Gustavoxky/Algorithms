// using System;
// using System.Collections.Generic;

// class Paging
// {
//     private int pageSize;
//     private List<Page> memory;

//     public Paging(int pageSize, int memorySize)
//     {
//         this.pageSize = pageSize;
//         memory = new List<Page>(memorySize);
//     }

//     public void LoadPage(int pageIndex, byte[] data)
//     {
//         if (pageIndex < memory.Count)
//             memory[pageIndex].Data = data;
//         else
//             memory.Add(new Page(data));
//     }

//     public byte[] AccessMemory(int pageIndex, int offset)
//     {
//         if (pageIndex < memory.Count && offset < pageSize)
//         {
//             return memory[pageIndex].Data[offset];
//         }
//         else
//         {
//             throw new IndexOutOfRangeException("Page or offset not found.");
//         }
//     }
// }

// class Page
// {
//     public byte[] Data { get; set; }

//     public Page(byte[] data)
//     {
//         Data = data;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Paging paging = new Paging(pageSize: 4096, memorySize: 1024);
//         byte[] data = new byte[4096];

//         paging.LoadPage(0, data);
//         byte[] accessedData = paging.AccessMemory(0, 1024);
//     }
// }
