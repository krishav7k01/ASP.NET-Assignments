using Day3.Models;

namespace Day3.Repositries
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee obj);
        void UpdateEmployee(Employee obj);
        void DeleteEmployee(int id);

        public List<Employee> GetByNo(int Depno);

        public List<Employee> GetByJob(String Job);

        
    }
}