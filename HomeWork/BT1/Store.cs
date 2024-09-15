namespace ZZZZHomeWork.BT1
{
    public class Store : IStore
    {
        public Store() {
            numMilk = new List<Milk>();
            numSausage = new List<Sausage>();
            numEgg = new List<Egg>();
        }
        public List<Milk> numMilk { get; set; }
        public List<Sausage> numSausage { get; set; }
        public List<Egg> numEgg { get; set; }
        public List<Egg> numEgg2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
