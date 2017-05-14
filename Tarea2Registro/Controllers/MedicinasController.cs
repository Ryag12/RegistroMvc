using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tarea2Registro.DAL;
using Tarea2Registro.Models;

namespace Tarea2Registro.Controllers
{
    public class MedicinasController : Controller
    {
        private MiMedicinaDB db = new MiMedicinaDB();

        // GET: Medicinas
        public ActionResult Index()
        {
            return View(db.Agregar.ToList());
        }

        // GET: Medicinas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicinas medicinas = db.Agregar.Find(id);
            if (medicinas == null)
            {
                return HttpNotFound();
            }
            return View(medicinas);
        }

        // GET: Medicinas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Medicinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MedicinaId,NombreMedicina,CantidadExistencia,PrecioCompra,FechaVencimiento")] Medicinas medicinas)
        {
            if (ModelState.IsValid)
            {
                db.Agregar.Add(medicinas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medicinas);
        }

        // GET: Medicinas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicinas medicinas = db.Agregar.Find(id);
            if (medicinas == null)
            {
                return HttpNotFound();
            }
            return View(medicinas);
        }

        // POST: Medicinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MedicinaId,NombreMedicina,CantidadExistencia,PrecioCompra,FechaVencimiento")] Medicinas medicinas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicinas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicinas);
        }

        // GET: Medicinas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicinas medicinas = db.Agregar.Find(id);
            if (medicinas == null)
            {
                return HttpNotFound();
            }
            return View(medicinas);
        }

        // POST: Medicinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Medicinas medicinas = db.Agregar.Find(id);
            db.Agregar.Remove(medicinas);
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
