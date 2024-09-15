using D._AspNetCoreMvc_DI_LifeTime.Models.Interfaces;

namespace C._AspNetCoreMvc_DI_ModelViewController.Services
{
    public class TestingService
    {
        private readonly IStudentRepository? _repository = null;
        public TestingService(IStudentRepository repository)
        {
            _repository = repository;
        }
        public void SomeMethod()
        {
        }
    }
}
