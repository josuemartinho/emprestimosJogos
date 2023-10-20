using emprestimosJogos.Data;
using emprestimosJogos.Models;
using Microsoft.AspNetCore.Mvc;

namespace emprestimosJogos.Controllers
{
    public class EmprestimosController : Controller
    {
        readonly private ApplicationDBContext _db;
        public EmprestimosController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimoModel> emprestimos= _db.Emprestimos;
            return View(emprestimos);
        }
        [HttpGet]
        public IActionResult NovoRegisto()
        {
            return View();
        }
		[HttpPost]
		public IActionResult NovoRegisto(EmprestimoModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimos);
                _db.SaveChanges();
                return RedirectToAction("Index");
                
            }
            return View();
        }
    }
}
