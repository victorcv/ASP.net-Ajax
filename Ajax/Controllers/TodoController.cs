using Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax.Controllers
{
    public class TodoController : Controller
    {
        private TodoRepository _repo = new TodoRepository();
        // GET: Todo
        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }
        [HttpPost]
        public ActionResult Create(int priority, string description)
        {
            var item = _repo.Add(priority, description);
            return PartialView("_TodoItem", item);
        }
        [HttpPost]
        public ActionResult ToggleDone(int id)
        {
            _repo.ToggleDone(id);
            return PartialView("_TodoItem", _repo.GetById(id));
        }

    }
}