using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPP_NEW.Data;
using WebAPP_NEW.Models;

namespace WebAPP_NEW.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var objReportList = _context.registrations.ToList();
            return View(objReportList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Report report)
        {
            if (ModelState.IsValid)
            {
                _context.reports.Add(report);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(report);
        }
    }
}
