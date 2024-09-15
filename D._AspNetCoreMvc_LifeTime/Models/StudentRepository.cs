using D._AspNetCoreMvc_DI_LifeTime.Models.Interfaces;

namespace D._AspNetCoreMvc_DI_LifeTime.Models
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository() 
        {
            string filePath = @"D:\Source\Repos\Education\Education\D._AspNetCoreMvc_LifeTime\Log.txt";
            string contentToWrite = $"StudentRepository Object Created: @{DateTime.Now.ToString()}";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(contentToWrite);
            }
        }

        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() { Id = 101, Name = "Tín"},
                new Student() {Id = 102, Name = "Huy"},
                new Student() {Id = 103, Name = "Phúc"},
                new Student() {Id = 104, Name = "Sara"},
                new Student() {Id = 105, Name = "Pam"}
            };
        }

        public List<Student> GetAllStudent()
        {
            return DataSource();
        }

        public Student GetStudent(int id)
        {
            return DataSource().FirstOrDefault(s=>s.Id == id) ?? new Student();
        }
    }
}
