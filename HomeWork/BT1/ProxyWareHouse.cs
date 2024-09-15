namespace ZZZZHomeWork.BT1
{
    public class ProxyWareHouse : IWareHouse
    {
        private IWareHouse warehouse;
        public ProxyWareHouse(List<Milk> numMilk, List<Sausage> numSausage, List<Egg> numEgg)
        {

            warehouse = new WareHouse(numMilk, numSausage, numEgg);
        }
        public void Export(Person ps, Bill bill)
        {
            bill.product = bill.product.Where(p => p.exp > DateTime.Now).ToList();
            warehouse.Export(ps, bill);
        }
    }
}
