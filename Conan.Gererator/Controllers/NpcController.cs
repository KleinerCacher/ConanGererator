using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Conan.Generator.Models;
using Conan.Generator.ViewModels;

namespace Conan.Generator.Controllers
{
    public class NpcController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Npc
        public ActionResult Index()
        {
            return View(db.Npcs.ToList());
        }

        // GET: Npc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbstractNpc npc = db.Npcs.Find(id);
            if (npc == null)
            {
                return HttpNotFound();
            }
            return View(npc);
        }

        // GET: Npc/Create
        public ActionResult Create()
        {
            var npc = new AbstractNpc
            {
                Agility = 9,
                Awareness = 9,
                Brawn = 9,
                Coordination = 9,
                Personality = 9,
                Willpower = 9,
                Intelligence = 9,
                Type = NpcType.Toughend,
                Combat = 0,
                Fortitude = 0,
                Movement = 0,
                Knowledge = 0,
                Senses = 0,
                Social = 0,
                Name = "Next Victim"
            };

            return View(new NpcViewModel( npc));
        }

        // POST: Npc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NpcViewModel npc)
        {
            var anpc = new AbstractNpc(npc);
            if (npc.IsMinion)
                anpc.Type = NpcType.Minion;
            else if (npc.IsToughend)
                anpc.Type = NpcType.Toughend;
            else
                anpc.Type = NpcType.Nemesis;


            if (ModelState.IsValid)
            {
                db.Npcs.Add(npc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(npc);
        }

        // GET: Npc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbstractNpc npc = db.Npcs.Find(id);
            if (npc == null)
            {
                return HttpNotFound();
            }
            return View(npc);
        }

        // POST: Npc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Awareness,Intelligence,Personality,Agility,Brawn,Willpower,Coordination,Combat,Movement,Fortitude,Senses,Knowledge,Social")] AbstractNpc npc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(npc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(npc);
        }

        // GET: Npc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbstractNpc npc = db.Npcs.Find(id);
            if (npc == null)
            {
                return HttpNotFound();
            }
            return View(npc);
        }

        // POST: Npc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AbstractNpc npc = db.Npcs.Find(id);
            db.Npcs.Remove(npc);
            db.SaveChanges();
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
