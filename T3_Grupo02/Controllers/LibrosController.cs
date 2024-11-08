using Microsoft.AspNetCore.Mvc;
using T3_Grupo02.Datos;
using T3_Grupo02.Models;

namespace T3_Grupo02.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LibrosController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.Libro;
            return View(lista);
        }
    }
}
