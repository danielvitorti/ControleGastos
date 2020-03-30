using ControleGastos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ControleGastos.Controllers
{
    public class CompetenciaController : Controller
    {
        private readonly Contexto _context;

        public CompetenciaController(Contexto context)
        {
            _context = context;
        }

        // GET: Competencia
        public async Task<IActionResult> Index()
        {
            return View(await _context.Competencia.ToListAsync());
        }

        // GET: Competencia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competencia = await _context.Competencia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (competencia == null)
            {
                return NotFound();
            }

            return View(competencia);
        }

        // GET: Competencia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Competencia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,PeriodoInicial,PeriodoFinal,DataCadastro")] Competencia competencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(competencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(competencia);
        }

        // GET: Competencia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competencia = await _context.Competencia.FindAsync(id);
            if (competencia == null)
            {
                return NotFound();
            }
            return View(competencia);
        }

        // POST: Competencia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,PeriodoInicial,PeriodoFinal,DataCadastro")] Competencia competencia)
        {
            if (id != competencia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(competencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompetenciaExists(competencia.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(competencia);
        }

        // GET: Competencia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competencia = await _context.Competencia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (competencia == null)
            {
                return NotFound();
            }

            return View(competencia);
        }

        // POST: Competencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var competencia = await _context.Competencia.FindAsync(id);
            _context.Competencia.Remove(competencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompetenciaExists(int id)
        {
            return _context.Competencia.Any(e => e.Id == id);
        }
    }
}
