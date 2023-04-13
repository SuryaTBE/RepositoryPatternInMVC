using Microsoft.EntityFrameworkCore;
using RepositoryPatternInMVC.Models;

namespace RepositoryPatternInMVC.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _db;
        public EmployeeRepository(EmployeeDbContext db)
        {
            _db = db;
        }
        public void Create(EmployeeTbl employee)
        {
            _db.EmployeeTbls.Add(employee);
        }

        public void Delete(int id)
        {
            EmployeeTbl emp=_db.EmployeeTbls.Find(id);
            _db.EmployeeTbls.Remove(emp);
        }

        public void Edit(EmployeeTbl employee)
        {
            _db.Entry(employee).State=EntityState.Modified;
        }

        public IEnumerable<EmployeeTbl> GetAll()
        {
            return _db.EmployeeTbls.ToList();
        }

        public EmployeeTbl GetById(int id)
        {
            return _db.EmployeeTbls.Find(id);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
