using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetFinder.Application.ApplicationService;
using PetFinder.Application.ViewModel.Raca;
using PetFinder.Data.Context;
using PetFinder.Data.Interfaces;
using PetFinder.Domain.Entities;

namespace PetFinder.Web.Controllers
{
    public class RacasController : Controller
    {
        private readonly RacaAppService _racaAppService;

        public RacasController(RacaAppService racaAppService)
        {
            _racaAppService = racaAppService;
        }



        // GET: Racas
        public ActionResult Index()
        {
            return View(_racaAppService.ListAll());
        }

        // GET: Racas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var raca = _racaAppService.Get(id.Value);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        // GET: Racas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Racas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RacaId,Nome,Descricao,Tipo,UsuarioCriacao,DataCriacao,UsuarioUltimaAlteracao,DataUltimaAlteracao")] Raca raca)
        {
            if (ModelState.IsValid)
            {
                _racaAppService.Add(raca);
                //  db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(raca);
        }

        // GET: Racas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var raca = _racaAppService.Get(id.Value);

            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        // POST: Racas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RacaId,Nome,Descricao,Tipo")] RacaViewModel raca)
        {
            if (ModelState.IsValid)
            {
                _racaAppService.Update(raca);
                //db.Entry(raca).State = EntityState.Modified;
                // db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raca);
        }

        // GET: Racas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var raca = _racaAppService.Get(id.Value);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        // POST: Racas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _racaAppService.Delete(id);
            //db.Raca.Remove(raca);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _racaAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
