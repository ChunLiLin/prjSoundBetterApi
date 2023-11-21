using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjSoundBetterApi.Models;

namespace prjSoundBetterApi.Controllers
{
    public class apiTMembersController : Controller
    {
        private readonly dbSoundBetterContext _context;

        public apiTMembersController(dbSoundBetterContext context)
        {
            _context = context;
        }

        // GET: apiTMembers
        public async Task<IActionResult> Index()
        {
            var dbSoundBetterContext = _context.TMembers.Include(t => t.FPermission);
            return View(await dbSoundBetterContext.ToListAsync());
        }

        // GET: apiTMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TMembers == null)
            {
                return NotFound();
            }

            var tMember = await _context.TMembers
                .Include(t => t.FPermission)
                .FirstOrDefaultAsync(m => m.FMemberId == id);
            if (tMember == null)
            {
                return NotFound();
            }

            return View(tMember);
        }

        // GET: apiTMembers/Create
        public IActionResult Create()
        {
            ViewData["FPermissionId"] = new SelectList(_context.TMemberPromissions, "FPromissionId", "FPromissionId");
            return View();
        }

        // POST: apiTMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FMemberId,FUserame,FName,FPasswod,FPhone,FEmail,FGender,FBirthday,FCreationTime,FIntroduction,FPermissionId,FPhotoPath")] TMember tMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FPermissionId"] = new SelectList(_context.TMemberPromissions, "FPromissionId", "FPromissionId", tMember.FPermissionId);
            return View(tMember);
        }

        // GET: apiTMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TMembers == null)
            {
                return NotFound();
            }

            var tMember = await _context.TMembers.FindAsync(id);
            if (tMember == null)
            {
                return NotFound();
            }
            ViewData["FPermissionId"] = new SelectList(_context.TMemberPromissions, "FPromissionId", "FPromissionId", tMember.FPermissionId);
            return View(tMember);
        }

        // POST: apiTMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FMemberId,FUserame,FName,FPasswod,FPhone,FEmail,FGender,FBirthday,FCreationTime,FIntroduction,FPermissionId,FPhotoPath")] TMember tMember)
        {
            if (id != tMember.FMemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TMemberExists(tMember.FMemberId))
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
            ViewData["FPermissionId"] = new SelectList(_context.TMemberPromissions, "FPromissionId", "FPromissionId", tMember.FPermissionId);
            return View(tMember);
        }

        // GET: apiTMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TMembers == null)
            {
                return NotFound();
            }

            var tMember = await _context.TMembers
                .Include(t => t.FPermission)
                .FirstOrDefaultAsync(m => m.FMemberId == id);
            if (tMember == null)
            {
                return NotFound();
            }

            return View(tMember);
        }

        // POST: apiTMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TMembers == null)
            {
                return Problem("Entity set 'dbSoundBetterContext.TMembers'  is null.");
            }
            var tMember = await _context.TMembers.FindAsync(id);
            if (tMember != null)
            {
                _context.TMembers.Remove(tMember);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TMemberExists(int id)
        {
          return (_context.TMembers?.Any(e => e.FMemberId == id)).GetValueOrDefault();
        }
    }
}
