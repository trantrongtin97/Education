using System.Linq;

namespace ZZZZHomeWork.BT1
{
    public abstract class WareHouse : IWareHouse
    {

        public WareHouse(List<Milk> numMilk, List<Sausage> numSausage, List<Egg> numEgg)
        {
            this.numMilk = numMilk;
            this.numSausage = numSausage;
            this.numEgg = numEgg;
        }

        public List<Milk> numMilk {  get; set; }
        public List<Sausage> numSausage { get; set; }
        public List<Egg> numEgg { get; set; }

        public void Export(Person ps, Bill bill)
        {
            if (ps is IMen)
            {
                foreach (var p in bill.product)
                {
                    if (p is IProductForMen)
                    {
                        if (p is Milk)
                        {
                            numMilk.Remove(numMilk.SingleOrDefault(t=>t.exp == p.exp));
                            ps.store.numMilk.Add((Milk)p);
                        }
                    }
                }
            }
            if (ps is IGirl)
            {
                foreach (var p in bill.product)
                {
                    if (bill.product is IProductForGirl)
                    {
                        if (bill.product is Sausage)
                        {
                            numSausage.Remove(numSausage.SingleOrDefault(t => t.exp == p.exp));
                            ps.store.numSausage.Add((Sausage)p);
                        }
                        if (bill.product is Egg)
                        {
                            numEgg.Remove(numEgg.SingleOrDefault(t => t.exp == p.exp));
                            ps.store.numEgg.Add((Egg)p);
                        }
                    }
                }
            }
            Showinfo();
        }

        private void Showinfo()
        {
            Console.WriteLine(numMilk.Count);
            Console.WriteLine(numSausage.Count);
            Console.WriteLine(numEgg.Count);
        }
    }
}
