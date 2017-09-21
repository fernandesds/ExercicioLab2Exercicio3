using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaAcademicoAula3.Models;

namespace SistemaAcademicoAula3.Controllers
{
    public class NivelEnsinoController : Controller
    {
        private SistemaAcademicoContext db = new SistemaAcademicoContext();

        // GET: NivelEnsino
        public ActionResult Index()
        {
            return View(db.NivelEnsinoes.ToList());
        }

        // GET: NivelEnsino/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEnsino nivelEnsino = db.NivelEnsinoes.Find(id);
            if (nivelEnsino == null)
            {
                return HttpNotFound();
            }
            return View(nivelEnsino);
        }

        // GET: NivelEnsino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NivelEnsino/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NivelEnsinoId,Descricao")] NivelEnsino nivelEnsino)
        {
            if (ModelState.IsValid)
            {
                db.NivelEnsinoes.Add(nivelEnsino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nivelEnsino);
        }

        // GET: NivelEnsino/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEnsino nivelEnsino = db.NivelEnsinoes.Find(id);
            if (nivelEnsino == null)
            {
                return HttpNotFound();
            }
            return View(nivelEnsino);
        }

        // POST: NivelEnsino/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NivelEnsinoId,Descricao")] NivelEnsino nivelEnsino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nivelEnsino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nivelEnsino);
        }

        // GET: NivelEnsino/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEnsino nivelEnsino = db.NivelEnsinoes.Find(id);
            if (nivelEnsino == null)
            {
                return HttpNotFound();
            }
            return View(nivelEnsino);
        }

        // POST: NivelEnsino/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NivelEnsino nivelEnsino = db.NivelEnsinoes.Find(id);
            db.NivelEnsinoes.Remove(nivelEnsino);
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
