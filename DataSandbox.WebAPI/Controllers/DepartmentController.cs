using DataSandbox.DataAccess.Dtos;
using DataSandbox.DataAccess.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DataSandbox.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _IDepartmentRepository;
        private readonly ILogger<DepartmentController> _logger;
        public DepartmentController(IDepartmentRepository IDepartmentRepository, 
            ILogger<DepartmentController> logger)
        {
            _logger = logger;
            _IDepartmentRepository = IDepartmentRepository;
        }

        [HttpPost("CreateDepartment")]
        public IActionResult CreateDepartment(DepartmentDto departmentDto)
        {
            try
            {
                var response = _IDepartmentRepository.CreateDepartment(departmentDto);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.InnerException == null ? "" : ex.InnerException.ToString());
                _logger.LogError(ex.StackTrace);

                return BadRequest("An error occurred");
            }
        }
    }
}