namespace Task1.Models
{
    public class EmployeeManager
    {
         List<Employee> list1; 

        public EmployeeManager()
        {
            list1 = new List<Empployee>()
            {
                new Emp(){Empid = 1, Ename = "Krishav", Job = "IT Trainee", Salary= 10000, Deptno = 70},
                new Emp(){Empid = 2, Ename = "Sharma", Job = "Manager", Salary= 8000, Deptno = 2},
                new Emp(){Empid = 3, Ename = "Aditi", Job = "SAP", Salary= 9000, Deptno = 10}
            };
        }

        public List<Employee> GetAllEmployee()
        {
            return list1;
        }
        public Emp GetEmployeeById(int id)
        {
            Employee EmployeeObj = empList.SingleOrDefault(item => item.EId == id);
            return EmployeeObj;
            
        }
        public void AddEmployee(Employee obj)
        {
            list1.Add(obj);
        }
        public void DeleteEmployee(int id)
        {
            Empployee obj = list1.Find(item => item.Empid == id);
            list1.Remove(obj);
        }
        public void UpdateEmp(Employee updated_Obj)
        {
            Employee obj = list1.Find(item => item.Empid == updated_Obj.Empid);
            list1.Remove(obj);
            list1.Add(updated_Obj);
        }


    }
}
