using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PECOM.Controllers.Admin
{
    public class ItemPicsController : Controller
    {
        PECOMEntities db = new PECOMEntities();
        // GET: ItemPics
        public ActionResult Index(int itemId)
        {
            var model = db.ITEMImages.Where(x => x.ItemId == itemId).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(int itemId, ITEMImages collection, HttpPostedFileBase file)
        {
            if (file != null)
            {
                file.SaveAs(HttpContext.Server.MapPath("~/Images/")
                                                      + file.FileName);
                collection.ImgName = file.FileName;
            }

            db.ITEMImages.Add(collection);
            db.SaveChanges();
            return RedirectToAction("Index", "ItemPics", new { itemId = itemId });
        }

        // GET: ItemPics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemPics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemPics/Create
        [HttpPost]
        public ActionResult Create(ITEMImages collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemPics/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemPics/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemPics/Delete/5
        public ActionResult Delete(int id)
        {
            var model = db.ITEMImages.Find(id);
            return View(model);
        }

        // POST: ItemPics/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var model = db.ITEMImages.Find(id);
                int? _itemId = model.ItemId;
                db.ITEMImages.Remove(model);
                db.SaveChanges();
                return RedirectToAction("Index","ItemPics",new { itemId=_itemId});
            }
            catch
            {
                return View();
            }
        }
    }
}
