using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoExample.Business.Abstract;
using ToDoExample.DataAccess.Abstract;
using ToDoExample.Entities;

namespace ToDoExample.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IToDoListService _toDoListService;
        private IToDoItemService _toDoItemService;
        public HomeController(IToDoListService toDoListService, IToDoItemService toDoItemService)
        {
            _toDoListService = toDoListService;
            _toDoItemService = toDoItemService;
        }
        public IActionResult Index()
        {
            var model = _toDoListService.GetAllWithItems();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddCardModal(int? id)
        {
            var model = _toDoListService.GetById((int)id);
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult AddCard(ToDoItem entity)
        {
            entity.isValid = true;
            _toDoItemService.Create(entity);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult UpdateCardModal(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var model = _toDoItemService.GetById((int)id);
            return PartialView(model);
        }
        
        [HttpPost]
        public IActionResult UpdateCard(ToDoItem entity)
        {
            _toDoItemService.Update(entity);
            return RedirectToAction("Index");
        }

        
        public IActionResult DeleteCard(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var entity = _toDoItemService.GetById((int)id);
            if (entity !=null)
            {
                _toDoItemService.Delete(entity);
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteList(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var entity = _toDoListService.GetById((int)id);
            if (entity != null)
            {
                _toDoListService.Delete(entity);
            }
            return RedirectToAction("Index");
        }


        public IActionResult UpdateListModal(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var model = _toDoListService.GetById((int)id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult UpdateList(ToDoList entity)
        {
            _toDoListService.Update(entity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddListModal()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddList(ToDoList entity)
        {
            entity.isValid = true;
            _toDoListService.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateIsValid(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Index");
            }
            var entity = _toDoItemService.GetById((int)id);
            if (entity != null)
            {
                entity.isValid = false;
                _toDoItemService.Update(entity);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }


    }
}