﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EditorasController : Controller
    {
        private WebAppContext db = new WebAppContext();

        // GET: /Editoras/
        public ActionResult Index()
        {
            return View(db.Editoras.ToList());
        }

        // GET: /Editoras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Editora editora = db.Editoras.Find(id);
            if (editora == null)
            {
                return HttpNotFound();
            }
            return View(editora);
        }

        // GET: /Editoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Editoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EditoraID,Nome,Email")] Editora editora)
        {
            if (ModelState.IsValid)
            {
                db.Editoras.Add(editora);
                db.SaveChanges();
                TempData["Mensagem"] = "Editora cadastrada com sucesso!";
                return RedirectToAction("Index");
            }

            return View(editora);
        }

        // GET: /Editoras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Editora editora = db.Editoras.Find(id);
            if (editora == null)
            {
                return HttpNotFound();
            }
            return View(editora);
        }

        // POST: /Editoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EditoraID,Nome,Email")] Editora editora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(editora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(editora);
        }

        // GET: /Editoras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Editora editora = db.Editoras.Find(id);
            if (editora == null)
            {
                return HttpNotFound();
            }
            return View(editora);
        }

        // POST: /Editoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Editora editora = db.Editoras.Find(id);
            db.Editoras.Remove(editora);
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
