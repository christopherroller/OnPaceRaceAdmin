using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models;
using OnPaceRaceAdmin.ViewModels;

namespace OnPaceRaceAdmin.Web.Controllers
{
    [Authorize]
    public class RaceController : Controller
    {
        private ApplicationContext DbContext { get; set; }

        public RaceController(ApplicationContext context)
        {
            DbContext = context;
        }
        // GET: Race
        public IActionResult Index()
        {
            var races = DbContext.Races.Include(i => i.RaceStatus).Include(i => i.State).Select(s => new RaceDTO
            {
                Id = s.Id,
                RaceCity = s.RaceCity,
                RaceDate = s.RaceDate,
                RaceName = s.RaceName,
                RaceStateId = s.RaceStateId,
                StateName = s.State.Name,
                RaceStatusId = s.RaceStatusId,
                RaceStatusName = s.RaceStatus.Name

            }).AsEnumerable();
            return View(races);
        }

        // GET: Race/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Race/Create
        public ActionResult Create()
        {
            var rvm = new CreateRaceViewModel(DbContext);
            rvm.InitModel();
            return View(rvm);
        }

        // POST: Race/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRaceViewModel crvm)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Race/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Race/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Race/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Race/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}