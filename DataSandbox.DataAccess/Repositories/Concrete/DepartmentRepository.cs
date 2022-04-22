using DataSandbox.DataAccess.Dtos;
using DataSandbox.DataAccess.Repositories.Interface;
using DataSandbox.Domain.Context;
using DataSandbox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSandbox.DataAccess.Repositories.Concrete
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataSandboxContext _context;
        public DepartmentRepository(DataSandboxContext context)
        {
            _context = context;
        }
        public Department CreateDepartment(DepartmentDto DepartmentDto)
        {
            var department = new Department()
            {
                Name = DepartmentDto.Name,
                Occupation = DepartmentDto.Occupation,
                Address = DepartmentDto.Address,
                IsMarried = DepartmentDto.IsMarried
            };

            _context.Departments.Add(department);
            _context.SaveChanges();

            return department;
        }
    }
}