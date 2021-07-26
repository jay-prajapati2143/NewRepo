using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCStackOverFlow.Models;
using MVCStackOverFlow.Code;

namespace MVCStackOverFlow.Controllers
{
    
    public class QuestionController : Controller
    {
        private StackOverFlowContext db = new StackOverFlowContext();

        // GET: Question
        public async Task<ActionResult> Index()
        {
            var questions = db.Questions.Include(q => q.User);
            return View(await questions.ToListAsync());
        }

        // GET: Question/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = await db.Questions.FindAsync(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // GET: Question/Create
        [CustomAuthenticationFilter]
        public ActionResult Create()
        {
           ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName");
            return View();
        }

        // POST: Question/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[CustomAuthenticationFilter]
        public async Task<ActionResult> Create([Bind(Include = "QuestionID,UserID,QuestionTitle,QuestionBody,TotalViews,Vote,TimeOfAsk")] Question question)
        {
            if (ModelState.IsValid)
            {
                var userName = Session["UserName"];
                var user = db.Users.Where(u => u.UserName == userName).FirstOrDefault();
                if (user != null)
                {
                    
                    Question que = new Question();
                    que.QuestionTitle = question.QuestionTitle;
                    que.QuestionBody = question.QuestionBody;
                    que.Tags = question.Tags;
                    que.TimeOfAsk = DateTime.Now;
                    que.TotalViews = 0;
                    que.Vote = 0;
                    que.UserID = user.UserID;

                    db.Questions.Add(que);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", question.UserID);
            return View(question);
        }

        // GET: Question/Edit/5
        [CustomAuthenticationFilter]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = await db.Questions.FindAsync(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", question.UserID);
            return View(question);
        }

        // POST: Question/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "QuestionID,UserID,QuestionTitle,QuestionBody,TotalViews,Vote,TimeOfAsk")] Question question)
        {
            if (ModelState.IsValid)
            {
                db.Entry(question).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", question.UserID);
            return View(question);
        }

        // GET: Question/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = await db.Questions.FindAsync(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: Question/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Question question = await db.Questions.FindAsync(id);
            db.Questions.Remove(question);
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
