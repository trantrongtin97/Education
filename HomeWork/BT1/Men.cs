
namespace ZZZZHomeWork.BT1
{
    public class Men : Person, IMen
    {
        public Men(string name)
        {
            Name = name;
            store = new Store();
        }
        public string Name { get; set; }
    }
}
