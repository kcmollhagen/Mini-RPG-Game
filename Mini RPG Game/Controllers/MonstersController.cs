﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Mini_RPG_Game.Models
{
    public class MonstersController : Controller
    {
        //private DBMonsterContext db = new DBMonsterContext();

        // GET: Monsters
        //public ActionResult Index()
        //{
        //    return View(db.Monsters.ToList());
        //}

        //public ActionResult MonsterList()
        //{
        //    ViewBag.monsters = db.Monsters.ToList();
        //    return View();
        //}

        // GET: Monsters/Details/5
        //        public ActionResult Details(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            Monster monster = db.Monsters.Find(id);
        //            if (monster == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(monster);
        //        }

        //        // GET: Monsters/Create
        //        public ActionResult Create()
        //        {
        //            return View();
        //        }

        //        // POST: Monsters/Create
        //        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Create([Bind(Include = "ID,Name,Hp,Attack,LootDropped")] Monster monster)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                db.Monsters.Add(monster);
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }

        //            return View(monster);
        //        }

        //        // GET: Monsters/Edit/5
        //        public ActionResult Edit(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            Monster monster = db.Monsters.Find(id);
        //            if (monster == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(monster);
        //        }

        //        // POST: Monsters/Edit/5
        //        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Edit([Bind(Include = "ID,Name,Hp,Attack,LootDropped")] Monster monster)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                db.Entry(monster).State = EntityState.Modified;
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }
        //            return View(monster);
        //        }

        //        // GET: Monsters/Delete/5
        //        public ActionResult Delete(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //            }
        //            Monster monster = db.Monsters.Find(id);
        //            if (monster == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(monster);
        //        }

        //        // POST: Monsters/Delete/5
        //        [HttpPost, ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult DeleteConfirmed(int id)
        //        {
        //            Monster monster = db.Monsters.Find(id);
        //            db.Monsters.Remove(monster);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        protected override void Dispose(bool disposing)
        //        {
        //            if (disposing)
        //            {
        //                db.Dispose();
        //            }
        //            base.Dispose(disposing);
        //        }
    }
}
