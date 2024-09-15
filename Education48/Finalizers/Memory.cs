using System;

namespace Education48.Finalizers
{
    public class Memory
    {
        ~Memory() 
        {
            System.Diagnostics.Trace.WriteLine("Memory finalizer");
            //Console.WriteLine("Memory finalizer");
        }
    }
}
