using System;
using System.Collections.Generic;
using System.Text;
using ToDoExample.Business.Abstract;
using ToDoExample.DataAccess.Abstract;
using ToDoExample.Entities;

namespace ToDoExample.Business.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        private IToDoListDal _toDoListDal;
        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }
        public void Create(ToDoList entity)
        {
            _toDoListDal.Create(entity);
        }

        public void Delete(ToDoList entity)
        {
            _toDoListDal.Delete(entity);
        }

        public List<ToDoList> GetAll()
        {
            return _toDoListDal.GetAll();
        }

        public List<ToDoList> GetAllWithItems()
        {
            return _toDoListDal.GetAllWithItems();
        }

        public ToDoList GetById(int id)
        {
           return _toDoListDal.GetById(id);
        }

        public ToDoList GetByIdWithItems(int id)
        {
            return _toDoListDal.GetByIdWithItems(id);
        }

        public void Update(ToDoList entity)
        {
            _toDoListDal.Update(entity);
        }
    }
}
