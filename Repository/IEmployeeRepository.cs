using RepositoryPatternInMVC.Models;

namespace RepositoryPatternInMVC.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeTbl> GetAll();
        EmployeeTbl GetById(int id);
        void Create(EmployeeTbl employee);
        void Edit(EmployeeTbl employee);
        void Delete(int id);
        void Save();
    }
}
