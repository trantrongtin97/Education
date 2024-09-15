using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.OOP
{
    public class Men : Person
    {
        public int Money; 
        public void SetMoney(int amount)
        {
            Money = amount;
        }
        public override void Talk()
        {
            Console.WriteLine("Men - Talking");
        }
        public new void Fuck()
        {
            Console.WriteLine("Men - Fucking");
        }
        public void PrintMoney() 
        {
            Console.WriteLine($"Moeny: {Money}");
        }
    }
}
