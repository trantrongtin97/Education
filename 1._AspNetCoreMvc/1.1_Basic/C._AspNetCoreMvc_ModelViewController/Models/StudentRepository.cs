using C._AspNetCoreMvc_ModelViewController.Models.Interfaces;

namespace C._AspNetCoreMvc_ModelViewController.Models
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() { Id = 101, Name = "Tín", Dob = new DateTime(1997,07,11), Gender = "Male" },
                new Student() { Id = 102, Name = "Huy", Dob = new DateTime(1997,07,12), Gender = "Male" },
                new Student() { Id = 103, Name = "Phúc", Dob = new DateTime(1997,07,11), Gender = "Male" },
                new Student() { Id = 104, Name = "Sara", Dob = new DateTime(1997,07,11), Gender = "Female" },
                new Student() { Id = 105, Name = "Pam", Dob = new DateTime(1997,07,11), Gender = "Female" }
            };
        }
        public Student GetStudentById(int StudentId)
        {
            return DataSource().FirstOrDefault(e => e.Id == StudentId) ?? new Student();
        }
    }
}
