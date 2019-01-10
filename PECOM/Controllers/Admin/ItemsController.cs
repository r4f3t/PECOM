using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PECOM.Controllers.Admin
{
    public class ItemsController : Controller
    {
        PECOMEntities db = new PECOMEntities();
        // GET: Items
        public ActionResult Index()
        {
            return View(db.ITEMS.ToList());
        }

        // GET: Items/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        public ActionResult Create(ITEMS collection)
        {
            try
            {
                db.ITEMS.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Items/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.ITEMS.SingleOrDefault(x=>x.ID==id);
            return View(model);
        }

        // POST: Items/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ITEMS collection)
        {
            try
            {

                // TODO: Add update logic here
                db.ITEMS.AddOrUpdate(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Items/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Items/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var model = db.ITEMS.Find(id);
                db.ITEMS.Remove(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
