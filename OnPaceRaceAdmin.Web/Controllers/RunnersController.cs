using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models;
using OnPaceRaceAdmin.Repository;

namespace OnPaceRaceAdmin.Web.Controllers
{
    public class RunnersController : Controller
    {
        private readonly RunnerRepository _repo;

        public RunnersController(IRunnerRepository repo)
        {
            _repo = (RunnerRepository)repo;
        }

        // GET: Runners
        public async Task<IActionResult> Index()
        {
            try
            {
                var runners = await _repo.GetAllRunners();
                return View(runners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: Runners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runner = await _repo.GetRunnerById((int)id);
            if (runner == null)
            {
                return NotFound();
            }

            return View(runner);
        }

        // GET: Runners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Runners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,PhoneNumber")] Runner runner)
        {
            if (ModelState.IsValid)
            {
                await _repo.CreateRunner(runner);
                return RedirectToAction(nameof(Details),new { runner.Id});
            }
            return View(runner);
        }

        // GET: Runners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runner = await _repo.GetRunnerById((int)id);
            if (runner == null)
            {
                return NotFound();
            }
            return View(runner);
        }

        // POST: Runners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,PhoneNumber,StateId")] Runner runner)
        {
            if (id != runner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _repo.UpdateRunner(runner);                     
            }
            return View(runner);
        }

        // GET: Runners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var runner = await _repo.GetRunnerById((int)id);
        
            if (runner == null)
            {
                return NotFound();
               
            }
            return View(runner);
        }

        // POST: Runners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var runner = await _repo.GetRunnerById(id);
            if(runner != null)
            {
                await _repo.DeleteRunner(runner);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
