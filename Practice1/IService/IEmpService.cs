using Practice1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice1.IService
{
    public interface IEmpService
    {
        IEnumerable<Employee> GetAllEmp();
        Employee GetEmpById(int id);
    }
}
