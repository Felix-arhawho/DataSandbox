using DataSandbox.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSandbox.Domain.Context
{
    public class DataSandboxContext : DbContext
    {
        public DataSandboxContext(DbContextOptions<DataSandboxContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
    }
}