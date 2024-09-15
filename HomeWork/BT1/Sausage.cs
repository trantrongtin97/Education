namespace ZZZZHomeWork.BT1
{
    public class Sausage : Product, IProductForGirl
    {
        public Sausage(DateTime e)
        {
            exp = e;
        }
        public string Name { get; set; }
        public override DateTime exp { get; set; }
    }
}
