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
    public class apiTAppliRecordController : Controller
    {
        private readonly dbSoundBetterContext _context;
        public apiTAppliRecordController(dbSoundBetterContext context)
        {
            _context = context;
        }
        //===List===
        public IActionResult List()
        {
            var dbSoundBetterContext = _context.TApplicationRecords;
            return Json(dbSoundBetterContext);
        }
        //===List_MemberID===
        public IActionResult QueryByMember(int? id)//MemberId
        {
            if (id == null || _context.TApplicationRecords == null)
            {
                return NotFound();
            }

            var appli = _context.TApplicationRecords.Where(m => m.FMemberId == id);
            if (appli == null)
            {
                return NotFound();
            }
            return Json(appli);
        }
        //===List_ProjectID===
        public IActionResult QueryByProject(int? id)//ProjectId
        {
            if (id == null || _context.TApplicationRecords == null)
            {
                return NotFound();
            }

            var appli = _context.TApplicationRecords.Where(m => m.FProjectId == id);
            if (appli == null)
            {
                return NotFound();
            }
            return Json(appli);
        }
        //===搜尋===
        public IActionResult QueryById(int? id)
        {
            if (id == null || _context.TApplicationRecords == null)
            {
                return NotFound();
            }

            var site = _context.TApplicationRecords.FirstOrDefault(m => m.FApplicationRecordId == id);
            if (site == null)
            {
                return NotFound();
            }
            return Json(site);
        }
        //===新增===
        public IActionResult Create(TApplicationRecord? appli)
        {
            if (appli != null)
            {
                _context.Add(appli);
                _context.SaveChanges();
                return Content("新增成功");
            }
            return Content("錯誤");
        }
        //===修改===
        public IActionResult Edit(int id, TApplicationRecord appli)
        {
            if (appli != null)
            {
                try
                {
                    _context.Update(appli);
                    _context.SaveChanges();
                    return Content("修改成功");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TAppliRecordExists(appli.FApplicationRecordId))
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
        //===========
        private bool TAppliRecordExists(int id)
        {
            return (_context.TApplicationRecords?.Any(e => e.FApplicationRecordId == id)).GetValueOrDefault();
        }
    }
}
