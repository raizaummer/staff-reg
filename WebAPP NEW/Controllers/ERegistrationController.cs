using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPP_NEW.Data;
using WebAPP_NEW.Models;

namespace WebAPP_NEW.Controllers
{
    [Authorize]
    public class ERegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ERegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var objERegistrationList = _context.registrations.ToList();
            return View(objERegistrationList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ERegistration registration)
        {
            if (ModelState.IsValid)
            {
                _context.registrations.Add(registration);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(registration);
        }
    }

        //[Authorize]
        //public class ERegistrationController : Controller
        //{
        //    public IActionResult Index()
        //    {
        //        return View();
        //    }
        //}
    }
