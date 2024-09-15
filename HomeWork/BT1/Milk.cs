
using System.Xml.Linq;

namespace ZZZZHomeWork.BT1
{
    public class Milk : Product, IProductForMen
    {
        public Milk(DateTime e)
        {
            exp = e;
        }
        public string Name { get; set; }
        public override DateTime exp { get; set; }
    }
}
