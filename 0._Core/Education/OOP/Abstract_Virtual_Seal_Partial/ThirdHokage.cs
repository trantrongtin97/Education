namespace Education.OOP.Abstract_Virtual_Seal_Partial
{
    public class ThirdHokage : SecondHokage
    {
        public override void Chakra()
        {
            Console.WriteLine("3");
        }
        public override void Attack()
        {
            Console.WriteLine("ThirdHokage Attack...");
        }
        public override void Skill()
        {
            Console.WriteLine("Business man...");
        }
        public override void WaterArt()
        {
            Console.WriteLine("Fake Water Art...");
        }
        public override void WoodArt()
        {
            Console.WriteLine("Wood Art: Fucking Knowless");
        }
    }
}
