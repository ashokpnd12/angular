using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EmployeeWebApiService.Models;

namespace EmployeeWebApiService.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeesContext _context;

        public EmployeesController(EmployeesContext context)
        {
            _context = context;

            if (_context.Employees.Count() == 0)
            {
                _context.Employees.Add(new Employees { name = "Item1" });
                _context.SaveChanges();
            }
        }       
    }
}