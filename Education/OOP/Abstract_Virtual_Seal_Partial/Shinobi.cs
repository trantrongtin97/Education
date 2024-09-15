namespace Education.OOP.Abstract_Virtual_Seal_Partial
{
    public abstract class Shinobi : IHuman
    {
        public int Blood { get; set; }
        public abstract void Chakra();
        public abstract void Attack();
        public abstract void Skill();
    }
}
