using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospitalApp.Models;

namespace HospitalApp.Controllers
{
    public class TreatmentsController : Controller
    {
        private HospitalDBEntities db = new HospitalDBEntities();

        // GET: Treatments
        public async Task<ActionResult> Index()
        {
            var treatments = db.Treatments.Include(t => t.Patient).Include(t => t.Staff);
            return View(await treatments.ToListAsync());
        }

        // GET: Treatments/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = await db.Treatments.FindAsync(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // GET: Treatments/Create
        public ActionResult Create()
        {
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "Name");
            ViewBag.StaffID = new SelectList(db.Staffs, "ID", "Name");
            return View();
        }

        // POST: Treatments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,PatientID,StaffID,TreatmentName")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Treatments.Add(treatment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PatientID = new SelectList(db.Patients, "ID", "Name", treatment.PatientID);
            ViewBag.StaffID = new SelectList(db.Staffs, "ID", "Name", treatment.StaffID);
            return View(treatment);
        }

        // GET: Treatments/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = await db.Treatments.FindAsync(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "Name", treatment.PatientID);
            ViewBag.StaffID = new SelectList(db.Staffs, "ID", "Name", treatment.StaffID);
            return View(treatment);
        }

        // POST: Treatments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,PatientID,StaffID,TreatmentName")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treatment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "Name", treatment.PatientID);
            ViewBag.StaffID = new SelectList(db.Staffs, "ID", "Name", treatment.StaffID);
            return View(treatment);
        }

        // GET: Treatments/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = await db.Treatments.FindAsync(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // POST: Treatments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Treatment treatment = await db.Treatments.FindAsync(id);
            db.Treatments.Remove(treatment);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
