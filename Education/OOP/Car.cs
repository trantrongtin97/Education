using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.OOP
{
    public class Car
    {
        public void ShowInfo()
        {
            Console.WriteLine("Car - Show Info");
            OriginFrom();
        }
        public virtual void OriginFrom()
        {
            Console.WriteLine("Original Car");
        }
    }
}
