using Day3.Models;

namespace Day3.Repositries
{
    public class EmployeeRepo : IEmployeeRepo
    {
        ApplicationDbContext _context;

        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
           Employee obj = _context.Employees.Find(id);
            _context.Employees.Remove(obj);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> stList = _context.Employees.ToList();
            return stList;
        }

        public List<Employee> GetByNo(int Depno)
        {
            List<Employee> sublist = _context.Employees.Where(item => item.Depno == Depno).ToList();
            return sublist;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee obj = _context.Employees.Find(id);
            return obj;
        }

      

        public List<Employee> GetByJob(String Job)
        {
            List<Employee> sublist = _context.Employees.Where(item => item.Job == Job).ToList();
            return sublist;
        }




        public void UpdateEmployee(Employee obj)
        {
            _context.Employees.Update(obj);
            _context.SaveChanges();
        }
    }
}

