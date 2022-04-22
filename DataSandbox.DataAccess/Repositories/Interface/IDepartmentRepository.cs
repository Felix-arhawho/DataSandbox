using DataSandbox.DataAccess.Dtos;
using DataSandbox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSandbox.DataAccess.Repositories.Interface
{
    public interface IDepartmentRepository
    {
        Department CreateDepartment(DepartmentDto DepartmentDto);
    }
}
