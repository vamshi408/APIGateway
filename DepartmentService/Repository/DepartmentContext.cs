﻿using DepartmentService.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentService.Repository
{
    public class DepartmentContext :DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options):base(options) { }
        public DbSet<Department> Departments { get; set; }
    }
}
