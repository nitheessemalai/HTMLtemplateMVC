using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLtemplateMVC.Controllers
{
    public class HTMLtemplateController : Controller

    {

        // GET: HTMLtemplateController1
        public ActionResult client()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }

        public ActionResult blog()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult services()
        {
            return View();
        }

        // GET: HTMLtemplateController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
      


        // GET: HTMLtemplateController1/Create
        public ActionResult Create() 

        {
            return View();
        }

        // POST: HTMLtemplateController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HTMLtemplateController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HTMLtemplateController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HTMLtemplateController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HTMLtemplateController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
