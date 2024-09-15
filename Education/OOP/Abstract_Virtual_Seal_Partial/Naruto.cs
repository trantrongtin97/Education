using Education.OOP.Abstract_Virtual_Seal_Partial;

namespace Education.OOP.Abstract_Virtual_Seal
{
    public partial class Naruto : Shinobi
    {
        public override void Chakra()
        {
            Console.WriteLine("5");
        }
        public override void Attack()
        {
            Console.WriteLine("Naruto Attack...");
        }
        public override void Skill()
        {
            Console.WriteLine("Shadow Clone...");
        }
    }
}
