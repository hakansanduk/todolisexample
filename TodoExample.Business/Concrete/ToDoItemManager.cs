using System;
using System.Collections.Generic;
using System.Text;
using ToDoExample.Business.Abstract;
using ToDoExample.DataAccess.Abstract;
using ToDoExample.Entities;

namespace ToDoExample.Business.Concrete
{
    public class ToDoItemManager : IToDoItemService
    {
        private IToDoItemDal _toDoItemDal;
        public ToDoItemManager(IToDoItemDal toDoItemDal)
        {
            _toDoItemDal = toDoItemDal;
        }

        public void Create(ToDoItem entity)
        {
            _toDoItemDal.Create(entity);
        }

        public void Delete(ToDoItem entity)
        {
            _toDoItemDal.Delete(entity);
        }

        public List<ToDoItem> GetAll()
        {
            return _toDoItemDal.GetAll();
        }

        public ToDoItem GetById(int id)
        {
            return _toDoItemDal.GetById(id);
        }

        public void Update(ToDoItem entity)
        {
            _toDoItemDal.Update(entity);
        }
    }
}
