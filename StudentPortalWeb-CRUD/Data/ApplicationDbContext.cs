﻿using Microsoft.EntityFrameworkCore;
using StudentPortalWeb_CRUD.Models.Entities;

namespace StudentPortalWeb_CRUD.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
