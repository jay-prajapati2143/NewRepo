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
    public class DrugAllotmentsController : Controller
    {
        private HospitalDBEntities db = new HospitalDBEntities();

        // GET: DrugAllotments
        public async Task<ActionResult> Index()
        {
            var drugAllotments = db.DrugAllotments.Include(d => d.Patient);
            return View(await drugAllotments.ToListAsync());
        }

        // GET: DrugAllotments/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugAllotment drugAllotment = await db.DrugAllotments.FindAsync(id);
            if (drugAllotment == null)
            {
                return HttpNotFound();
            }
            return View(drugAllotment);
        }

        // GET: DrugAllotments/Create
        public ActionResult Create()
        {
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "Name");
            return View();
        }

        // POST: DrugAllotments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,PatientID,DrugName,Morning,Afternoon,Evenning,Night")] DrugAllotment drugAllotment)
        {
            if (ModelState.IsValid)
            {
                db.DrugAllotments.Add(drugAllotment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PatientID = new SelectList(db.Patients, "ID", "Name", drugAllotment.PatientID);
            return View(drugAllotment);
        }

        // GET: DrugAllotments/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugAllotment drugAllotment = await db.DrugAllotments.FindAsync(id);
            if (drugAllotment == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "Name", drugAllotment.PatientID);
            return View(drugAllotment);
        }

        // POST: DrugAllotments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,PatientID,DrugName,Morning,Afternoon,Evenning,Night")] DrugAllotment drugAllotment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drugAllotment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "Name", drugAllotment.PatientID);
            return View(drugAllotment);
        }

        // GET: DrugAllotments/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugAllotment drugAllotment = await db.DrugAllotments.FindAsync(id);
            if (drugAllotment == null)
            {
                return HttpNotFound();
            }
            return View(drugAllotment);
        }

        // POST: DrugAllotments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DrugAllotment drugAllotment = await db.DrugAllotments.FindAsync(id);
            db.DrugAllotments.Remove(drugAllotment);
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
