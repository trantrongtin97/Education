namespace EntityFrameworkCoreEducation.ContextBase.Entities
{
    public class Cat
    {
        public Cat(int id , string name) 
        { 
            Id = id ;
            Name = name ;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
