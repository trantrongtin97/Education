namespace Education.OOP.Abstract_Virtual_Seal_Partial
{
    public sealed class Madara : FirstHokage
    {
        public sealed override void Chakra()
        {
            Console.WriteLine("1");
        }

        public sealed override void Attack()
        {
            Console.WriteLine("Madara Attack...");
        }

        public sealed override void Skill()
        {
            Console.WriteLine("Full Armor Susanoo...");
        }

        public sealed override void WoodArt()
        {
            Console.WriteLine("Wood Art: Basic");
        }
    }
}
