using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education48.Finalizers
{
    //Finalizer//https://learn.microsoft.com/vi-vn/dotnet/csharp/programming-guide/classes-and-structs/finalizers
    //GC Collect//https://learn.microsoft.com/vi-vn/dotnet/standard/garbage-collection/
    public class EducationFinalizer
    {
        //Finalizer call when an application terminates. Using GC.Collect() to call in run time
        static void Main()
        {
            Run();
            //DemoGenerationGC();
            //GC.Collect();
            Console.ReadLine();
        }
        private static void Run() 
        {
            Person ps = new Person();
            ps = null;
        }
        private static void DemoGenerationGC()
        {
            GenerationGC myGCCol = new GenerationGC();

            // Determine the maximum number of generations the system
            // garbage collector currently supports.
            Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);

            myGCCol.MakeSomeGarbage();

            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            // Determine the best available approximation of the number
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            // Perform a collection of generation 0 only.
            GC.Collect(0);

            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            // Perform a collection of all generations up to and including 2.
            GC.Collect(2);

            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
            Console.Read();
        }
    }
}
