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
    public class apiTSiteController : Controller
    {
        private readonly dbSoundBetterContext _context;
        public apiTSiteController(dbSoundBetterContext context)
        {
            _context = context;
        }
        //===List===
        public IActionResult List()
        {
            var dbSoundBetterContext = _context.TSites;
            return Json(dbSoundBetterContext);
        }
        //===List_MemberID===
        public IActionResult QueryByMember(int? id)//MemberId
        {
            if (id == null || _context.TSites == null)
            {
                return NotFound();
            }

            var site = _context.TSites.Where(m => m.FMemberId == id);
            if (site == null)
            {
                return NotFound();
            }
            return Json(site);
        }
        //===搜尋===
        public IActionResult QueryById(int? id)
        {
            if (id == null || _context.TSites == null)
            {
                return NotFound();
            }

            var site = _context.TSites.FirstOrDefault(m => m.FSiteId == id);
            if (site == null)
            {
                return NotFound();
            }
            return Json(site);
        }
        //===新增===
        public IActionResult Create(TSite? site)
        {
            if (site != null)
            {
                _context.Add(site);
                _context.SaveChanges();
                return Content("新增成功");
            }
            return Content("錯誤");
        }
        //===修改===
        public IActionResult Edit(int id, TSite site)
        {
            if (site != null)
            {
                try
                {
                    _context.Update(site);
                    _context.SaveChanges();
                    return Content("修改成功");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TSiteExists(site.FSiteId))
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
        private bool TSiteExists(int id)
        {
            return (_context.TSites?.Any(e => e.FSiteId == id)).GetValueOrDefault();
        }
    }
}
