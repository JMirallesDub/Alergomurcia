using AlergomuciaMVC.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlergomuciaMVC.Controllers
{
    public class SectionsController : Controller
    {
        // GET: Sections
        public ActionResult Index()
        {
            ServiceReference1.ServiceClient sec = new ServiceReference1.ServiceClient();
            return View(sec.GetAllSection());
        }

        // GET: Sections/Details/5
        public ActionResult Details(int id)
        {
            ServiceReference1.ServiceClient sec = new ServiceReference1.ServiceClient();
            return View(sec.GetSectionById(id));
        }

        //GET: Sections/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sections/Create
        [HttpPost]
        public ActionResult Create(Section model)
        {
            try
            {

                Section section = new Section();
                section.seccion = model.seccion;
                ServiceReference1.ServiceClient sec = new ServiceReference1.ServiceClient();
                sec.AddSection(section);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sections/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sections/Edit/5
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

        // GET: Sections/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sections/Delete/5
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
