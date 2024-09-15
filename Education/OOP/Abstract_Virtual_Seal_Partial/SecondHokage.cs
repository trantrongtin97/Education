using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.OOP.Abstract_Virtual_Seal_Partial
{
    public class SecondHokage : FirstHokage
    {
        public override void Chakra()
        {
            Console.WriteLine("2");
        }
        public override void Attack()
        {
            Console.WriteLine("SecondHokage Attack...");
        }

        public override void Skill()
        {
            Console.WriteLine("Teleport Art...");
        }

        public override void WoodArt()
        {
            Console.WriteLine("Wood Art: Just see...");
        }

        public virtual void WaterArt()
        {
            Console.WriteLine("Water Art...");
        }


    }
}
