using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZZZHomeWork.BT1
{
    public class ExamBT1
    {
        static void Main()
        {
            Men huy = new Men("Huy");
            Girl tram = new Girl("Tram");
            Girl le = new Girl("Le");

            List<Milk> ms = new List<Milk>
            {
                new Milk(new DateTime(2024,07,26)),
                new Milk(new DateTime(2024,07,28)),
                new Milk(new DateTime(2024,07,29)),
                new Milk(new DateTime(2024,07,30)),
            };
            List<Sausage> sa = new List<Sausage>
            {
                new Sausage(new DateTime(2024,07,26)),
                new Sausage(new DateTime(2024,07,28)),
                new Sausage(new DateTime(2024,07,29)),
                new Sausage(new DateTime(2024,07,30)),
            };
            List<Egg> e = new List<Egg>
            {
                new Egg(new DateTime(2024,07,26)),
                new Egg(new DateTime(2024,07,28)),
                new Egg(new DateTime(2024,07,29)),
                new Egg(new DateTime(2024,07,30)),
            };

            IWareHouse proxy = new ProxyWareHouse(ms, sa, e);
            proxy.Export(huy, new Bill { product = new List<Product>() { new Milk(new DateTime(2024, 07, 26)) }});
        }
    }
}
