using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xaero.DataLayer.Entities;
using Xaero.DataLayer.UnitOfWork;

namespace Xaero.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IUnitOfWork unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return unitOfWork.StudentRepository.Get();
        }
    }
}
