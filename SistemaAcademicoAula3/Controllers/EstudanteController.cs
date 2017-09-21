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
    public class EstudanteController : Controller
    {
        private SistemaAcademicoContext db = new SistemaAcademicoContext();

        // GET: Estudante
        public ActionResult Index()
        {
            var estudantes = db.Estudantes.Include(e => e.Endereco).Include(e => e.NivelEnsino);
            return View(estudantes.ToList());
        }

        // GET: Estudante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudantes.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // GET: Estudante/Create
        public ActionResult Create()
        {
            ViewBag.EstudanteID = new SelectList(db.Enderecoes, "EnderecoId", "Endereco1");
            ViewBag.NivelEnsinoId = new SelectList(db.NivelEnsinoes, "NivelEnsinoId", "Descricao");
            return View();
        }

        // POST: Estudante/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstudanteID,NomeEstudante,DataNascimento,Altura,Peso,NivelEnsinoId,EnderecoID")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Estudantes.Add(estudante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstudanteID = new SelectList(db.Enderecoes, "EnderecoId", "Endereco1", estudante.EstudanteID);
            ViewBag.NivelEnsinoId = new SelectList(db.NivelEnsinoes, "NivelEnsinoId", "Descricao", estudante.NivelEnsinoId);
            return View(estudante);
        }

        // GET: Estudante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudantes.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstudanteID = new SelectList(db.Enderecoes, "EnderecoId", "Endereco1", estudante.EstudanteID);
            ViewBag.NivelEnsinoId = new SelectList(db.NivelEnsinoes, "NivelEnsinoId", "Descricao", estudante.NivelEnsinoId);
            return View(estudante);
        }

        // POST: Estudante/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstudanteID,NomeEstudante,DataNascimento,Altura,Peso,NivelEnsinoId,EnderecoID")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstudanteID = new SelectList(db.Enderecoes, "EnderecoId", "Endereco1", estudante.EstudanteID);
            ViewBag.NivelEnsinoId = new SelectList(db.NivelEnsinoes, "NivelEnsinoId", "Descricao", estudante.NivelEnsinoId);
            return View(estudante);
        }

        // GET: Estudante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = db.Estudantes.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // POST: Estudante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estudante estudante = db.Estudantes.Find(id);
            db.Estudantes.Remove(estudante);
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
