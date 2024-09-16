namespace Education.OOP.Abstract_Virtual_Seal_Partial
{
    public class Obito : FirstHokageCell
    {
        public override void Chakra()
        {
            Console.WriteLine("4");
        }

        public override void Attack()
        {
            Console.WriteLine("Obito Attack...");
        }

        public override void Skill()
        {
            Console.WriteLine("Obito Hole...");
        }
        public override void WoodArt()
        {
            //base.WoodArt(); //can not call method in class grand parent, must be new override
            Console.WriteLine("Replace Body");
        }
    }
}
