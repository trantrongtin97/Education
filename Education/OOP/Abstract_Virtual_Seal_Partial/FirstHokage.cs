namespace Education.OOP.Abstract_Virtual_Seal_Partial
{
    public class FirstHokage : Shinobi
    {
        public override void Chakra()
        {
            Console.WriteLine("1");
        }

        public override void Attack()
        {
            Console.WriteLine("FirstHokage Attack...");
        }

        public override void Skill()
        {
            Console.WriteLine("Sage Mode...");
        }

        public virtual void WoodArt()
        {
            Console.WriteLine("Sage Wood Art...");
        }
    }
}
