using Practice1.Entity;
using Practice1.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice1.Service
{
    public class EmpService : IEmpService
    {
        private readonly List<Employee> _employees = new List<Employee> {
            new Employee{EmpId = 1, Name = "Andy", Age=24},
            new Employee{EmpId = 2, Name = "Bndy", Age=24},
            new Employee{EmpId = 3, Name = "Cndy", Age=24}
        };
        public IEnumerable<Employee> GetAllEmp()
        {
            return _employees.ToList();
        }

        public Employee GetEmpById(int id)
        {
            var emp = _employees.Where(e => e.EmpId == id).FirstOrDefault();
            return emp;
        }
    }
}
