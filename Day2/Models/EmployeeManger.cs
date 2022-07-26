namespace Task1.Models
{
    public class EmployeeManager
    {
         List<Emp> Employees = new List<Emp>();

        public EmployeeManager()
        {
            Employees = new List<Emp>()
            {
                new Emp(){Empid = 1, Ename = "Tim", Job = "Manager", Salary= 10000, Deptno = 30},
                new Emp(){Empid = 2, Ename = "Jim", Job = "Sales", Salary= 8000, Deptno = 20},
                new Emp(){Empid = 3, Ename = "Tom", Job = "IT", Salary= 9000, Deptno = 10}
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