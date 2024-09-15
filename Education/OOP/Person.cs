namespace Education.OOP
{
    public class Person
    {
        public int Blood ;
        public virtual void Talk()
        {
            Console.WriteLine("Person - Talking");
        }

        public virtual void Fuck()
        {
            Console.WriteLine("Person - Fucking");
        }
    }
}
