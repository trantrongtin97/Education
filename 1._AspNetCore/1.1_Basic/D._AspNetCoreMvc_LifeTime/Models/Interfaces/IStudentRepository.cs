namespace D._AspNetCoreMvc_DI_LifeTime.Models.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudent();
        public Student GetStudent(int id);
    }
}
