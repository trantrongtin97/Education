using System;

namespace Education48.Finalizers
{
    public class Person
    {
        private Memory memory;
        public Person() 
        {
            memory = new Memory();
        }

        ~Person() 
        {
            memory = null;
            System.Diagnostics.Trace.WriteLine("Person finalizer");
            //Console.WriteLine("Person finalizer");
        }
    }
}
