using LibraryHTMLtemplate.EmplyoeeModel;
using LibraryHTMLtemplate.RepositoryEmployee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace HTMLtemplateMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController1
        Repositoryemployee obj;
        locationrepository obj1;
        public EmployeeController()
        {
            obj = new Repositoryemployee();
            obj1 = new locationrepository();

        }

        public ActionResult List()
        {
            return View("List",obj.selectsp());
        }

        // GET: EmployeeController1/Details/5
        public ActionResult Details(int id)
        {
            var result = obj.selectid(id);
            return View("Detail", result);
        }

        // GET: EmployeeController1/Create
        public ActionResult Create()
        {
            var model = new ModelEmployee();
            model.locationModels = obj1.locationin();
            return View("create", model);

           // return View("create",new ModelEmployee());
        }

        // POST: EmployeeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create(ModelEmployee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    obj.Insertsp(emp);
                  

                   return RedirectToAction(nameof(List));
                }
                else
                {
                    emp.locationModels = obj1.locationin();
                   return View("create", new ModelEmployee());

                }
              
               // return RedirectToAction(nameof(List));

               
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var result = obj.selectid(id);
            return View("Edit", result);
          }
    

        // POST: EmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ModelEmployee emp)
        {
            try
            {
            emp.id = id;
            obj.updatesp(emp);
            return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Delete/5
        public ActionResult Delete(int id)
        {
            var result = obj.selectid(id);

            return View("Delete", result);
        }

        // POST: EmployeeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ModelEmployee emp)
        {
            try
            {
                obj.deletesp(id);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
