<<<<<<< HEAD
﻿using System;
namespace T3_Grupo02.Datos
{
    public class ApplicationDbContext
    {
=======
﻿
using Microsoft.EntityFrameworkCore;
using T3_Grupo02.Models;

namespace T3_Grupo02.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
            
        }
        public DbSet<Libro> Libro { get; set; }
>>>>>>> 6b4b674ef72cdf3ab104b2377911328b89ce38aa
    }
}
