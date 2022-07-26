namespace Task1.Models
{
    public class EmployeeManager
    {
         List<Emp> Employees = new List<Emp>();

        public EmployeeManager()
        {
            Employees = new List<Emp>()
            {
                new Emp(){Empid = 1, Ename = "Krishav", Job = "IT Trainee", Salary= 10000, Deptno = 70},
                new Emp(){Empid = 2, Ename = "Sharma", Job = "Manager", Salary= 8000, Deptno = 2},
                new Emp(){Empid = 3, Ename = "Aditi", Job = "SAP", Salary= 9000, Deptno = 10}
            };
        }

        public List<Emp> GetAllEmp()
        {
            return Employees;
        }
        public Emp GetEmpById(int id)
        {
            return Employees.Find(item => item.Empid == id);
        }
        public void AddEmp(Emp obj)
        {
            Employees.Add(obj);
        }
        public void DeleteEmp(int id)
        {
            Emp obj = Employees.Find(item => item.Empid == id);
            Employees.Remove(obj);
        }
        public void UpdateEmp(Emp updated_Obj)
        {
            Emp obj = Employees.Find(item => item.Empid == updated_Obj.Empid);
            Employees.Remove(obj);
            Employees.Add(updated_Obj);
        }


    }
}
