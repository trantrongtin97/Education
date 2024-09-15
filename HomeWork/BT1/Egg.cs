namespace ZZZZHomeWork.BT1
{
    public class Egg : Product, IProductForGirl
    {
        public Egg(DateTime e)
        {
            exp = e;
        }
        public string Name { get; set; }
        public override DateTime exp { get; set; }
    }
}
