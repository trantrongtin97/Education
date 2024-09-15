namespace EntityFrameworkCoreEducation.SimpleContext.Entities
{
    public class Student
    {
        public Student() { }
        public Student(int id, string? fname, DateTime? dob,string address)
        {
            Id = id;
            FullName = fname;
            Dob = dob;
            Address = address;
        }
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
   }
}
