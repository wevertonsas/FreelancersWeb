using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreelancersWeb.Models;

namespace FreelancersWeb.Controllers
{
    public class Type_userController : Controller
    {
        private readonly FreelancersWebContext _context;

        public Type_userController(FreelancersWebContext context)
        {
            _context = context;
        }

        // GET: Type_user
        public async Task<IActionResult> Index()
        {
            return View(await _context.Type_user.ToListAsync());
        }

        // GET: Type_user/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var type_user = await _context.Type_user
                .FirstOrDefaultAsync(m => m.Id == id);
            if (type_user == null)
            {
                return NotFound();
            }

            return View(type_user);
        }

        // GET: Type_user/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Type_user/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Type_user type_user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(type_user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(type_user);
        }

        // GET: Type_user/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var type_user = await _context.Type_user.FindAsync(id);
            if (type_user == null)
            {
                return NotFound();
            }
            return View(type_user);
        }

        // POST: Type_user/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Type_user type_user)
        {
            if (id != type_user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(type_user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Type_userExists(type_user.Id))
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
            return View(type_user);
        }

        // GET: Type_user/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var type_user = await _context.Type_user
                .FirstOrDefaultAsync(m => m.Id == id);
            if (type_user == null)
            {
                return NotFound();
            }

            return View(type_user);
        }

        // POST: Type_user/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var type_user = await _context.Type_user.FindAsync(id);
            _context.Type_user.Remove(type_user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Type_userExists(int id)
        {
            return _context.Type_user.Any(e => e.Id == id);
        }
    }
}
