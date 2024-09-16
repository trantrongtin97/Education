namespace EntityFrameworkCoreEducation.ContextBase.Entities
{
    public class Dog
    {
        public Dog(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
