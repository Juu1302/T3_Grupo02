
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using T3_Grupo02.Models;

namespace T3_Grupo02.Datos
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
            
        }
        public DbSet<Libro> Libro { get; set; }
    }
}
