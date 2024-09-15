namespace ZZZZHomeWork.BT1
{
    public class Girl : Person, IGirl
    {
        public Girl(string name)
        {
            Name = name;
            store = new Store();
        }
        public string Name { get; set; }
    }
}
