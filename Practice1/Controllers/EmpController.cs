using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice1.IService;

namespace Practice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpService _empService;

        public EmpController(IEmpService empService)
        {
            _empService = empService;
        }

        [Route("List")]
        public IActionResult GetAllEmps()
        {
            var list = _empService.GetAllEmp();
            return Ok(list);
        }

        [Route("{id:int}")]
        public IActionResult GetEmpById(int id)
        {
            var emp = _empService.GetEmpById(id);
            return Ok(emp);
        }
    }
}
