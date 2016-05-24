using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlergomuciaMVC.Controllers
{
    public class ReunionesController : Controller
    {
        // GET: Reuniones
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reuniones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reuniones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reuniones/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: Reuniones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reuniones/Edit/5
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

        // GET: Reuniones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reuniones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
