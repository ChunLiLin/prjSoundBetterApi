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
    public class apiTWorksController : Controller
    {
        private readonly dbSoundBetterContext _context;
        public apiTWorksController(dbSoundBetterContext context)
        {
            _context = context;
        }
        //===List===
        public IActionResult List()
        {
            var dbSoundBetterContext = _context.TWorks;
            return Json(dbSoundBetterContext);
        }
        //===List_MemberID===
        public IActionResult QueryByMember(int? id)//MemberId
        {
            if (id == null || _context.TWorks == null)
            {
                return NotFound();
            }

            var work = _context.TWorks.Where(m => m.FMemberId == id);
            if (work == null)
            {
                return NotFound();
            }
            return Json(work);
        }
        //===List_StyleID===
        public IActionResult QueryByStyle(int? id)//StyleID
        {
            if (id == null || _context.TWorks == null)
            {
                return NotFound();
            }

            var work = _context.TWorks.Where(m => m.FStyleId == id);
            if (work == null)
            {
                return NotFound();
            }
            return Json(work);
        }
        //===搜尋===
        public IActionResult QueryById(int? id)
        {
            if (id == null || _context.TWorks == null)
            {
                return NotFound();
            }

            var work = _context.TWorks.FirstOrDefault(m => m.FWorkId == id);
            if (work == null)
            {
                return NotFound();
            }
            return Json(work);
        }
        //===新增===
        public IActionResult Create(TWork? work)
        {
            if (work != null)
            {
                _context.Add(work);
                _context.SaveChanges();
                return Content("新增成功");
            }
            return Content("錯誤");
        }
        //===修改===
        public IActionResult Edit(int id, TWork work)
        {
            if (work != null)
            {
                try
                {
                    _context.Update(work);
                    _context.SaveChanges();
                    return Content("修改成功");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TWorkExists(work.FWorkId))
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
        //========
        private bool TWorkExists(int id)
        {
            return (_context.TWorks?.Any(e => e.FWorkId == id)).GetValueOrDefault();
        }
    }
}
