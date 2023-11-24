using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        //===List===
        public IActionResult List()
        {
            var dbSoundBetterContext = _context.TMembers;
            return Json(dbSoundBetterContext);
        }
        //===搜尋===
        public IActionResult QueryById(int? id)
        {          
            if (id == null || _context.TMembers == null)
            {
                return NotFound();
            }

            var tMember = _context.TMembers.Where((m => m.FMemberId == id)).FirstOrDefault();
            if (tMember == null)
            {
                return NotFound();
            }
            return Json(tMember);
        }
        //===新增===
        public IActionResult Create(TMember? tMember)
        {
            if (tMember != null)
            {
                _context.Add(tMember);
                _context.SaveChanges();
                return Content("新增成功");
            }
            return Content("錯誤");
        }
        //===修改===
        public IActionResult Edit(int id,TMember tMember)
        {
            if (tMember != null)
            {
                try
                {
                    _context.Update(tMember);
                    _context.SaveChanges();
                    return Content("修改成功");
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
            }
            return Content("錯誤");
        }
        //===刪除===
        public IActionResult Delete(int id)
        {
            if (_context.TMembers == null)
            {
                return Problem("連線錯誤");
            }
            var tMember = _context.TMembers.Where(c => c.FMemberId == id).FirstOrDefault();
            if (tMember != null)
            {
                _context.TMembers.Remove(tMember);
                _context.SaveChanges();
                return Content("刪除成功");
            }
            return Content("刪除失敗");
        }
        //===Check===
        public IActionResult checkUsername(string username)
        {
            if (username != null)
            {
                string feedback = "OK";
                foreach (var item in _context.TMembers)
                {
                    if (item.FUserame == username)
                    {
                        feedback = "已存在的使用者名稱";
                    }
                }
                return Content(feedback);               
            }
            return Content("請輸入使用名稱");
        }
        public IActionResult checkEmail(string email)
        {
            if (email != null)
            {
                string feedback = "OK";
                foreach (var item in _context.TMembers)
                {
                    if (item.FUserame == email)
                    {
                        feedback = "電子郵件已被註冊";
                    }
                }
                return Content(feedback);
            }
            return Content("請輸入電子郵件");
        }
        //// GET: apiTMembers1
        //public async Task<IActionResult> Index()
        //{
        //    var dbSoundBetterContext = _context.TMembers.Include(t => t.FPermission);
        //    return View(await dbSoundBetterContext.ToListAsync());
        //}


        //// GET: apiTMembers1/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.TMembers == null)
        //    {
        //        return NotFound();
        //    }

        //    var tMember = await _context.TMembers
        //        .Include(t => t.FPermission)
        //        .FirstOrDefaultAsync(m => m.FMemberId == id);
        //    if (tMember == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tMember);
        //}

        // GET: apiTMembers1/Create
        //public IActionResult Create()
        //{
        //    ViewData["FPermissionId"] = new SelectList(_context.TMemberPromissions, "FPromissionId", "FPromissionId");
        //    return View();
        //}

        // POST: apiTMembers1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("FMemberId,FUserame,FName,FPasswod,FPhone,FEmail,FGender,FBirthday,FCreationTime,FIntroduction,FPermissionId,FPhotoPath")] TMember tMember)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(tMember);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["FPermissionId"] = new SelectList(_context.TMemberPromissions, "FPromissionId", "FPromissionId", tMember.FPermissionId);
        //    return View(tMember);
        //}

        // GET: apiTMembers1/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.TMembers == null)
        //    {
        //        return NotFound();
        //    }

        //    var tMember = await _context.TMembers.FindAsync(id);
        //    if (tMember == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["FPermissionId"] = new SelectList(_context.TMemberPromissions, "FPromissionId", "FPromissionId", tMember.FPermissionId);
        //    return View(tMember);
        //}

        // POST: apiTMembers1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("FMemberId,FUserame,FName,FPasswod,FPhone,FEmail,FGender,FBirthday,FCreationTime,FIntroduction,FPermissionId,FPhotoPath")] TMember tMember)
        //{
        //    if (id != tMember.FMemberId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(tMember);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!TMemberExists(tMember.FMemberId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["FPermissionId"] = new SelectList(_context.TMemberPromissions, "FPromissionId", "FPromissionId", tMember.FPermissionId);
        //    return View(tMember);
        //}

        // GET: apiTMembers1/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.TMembers == null)
        //    {
        //        return NotFound();
        //    }

        //    var tMember = await _context.TMembers
        //        .Include(t => t.FPermission)
        //        .FirstOrDefaultAsync(m => m.FMemberId == id);
        //    if (tMember == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tMember);
        //}

        // POST: apiTMembers1/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.TMembers == null)
        //    {
        //        return Problem("Entity set 'dbSoundBetterContext.TMembers'  is null.");
        //    }
        //    var tMember = await _context.TMembers.FindAsync(id);
        //    if (tMember != null)
        //    {
        //        _context.TMembers.Remove(tMember);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool TMemberExists(int id)
        {
          return (_context.TMembers?.Any(e => e.FMemberId == id)).GetValueOrDefault();
        }
    }
}
