using System;
using System.Collections.Generic;
using System.Text;
using ToDoExample.Entities;

namespace ToDoExample.Business.Abstract
{
    public interface IToDoListService
    {
        ToDoList GetById(int id);
        List<ToDoList> GetAll();
        void Create(ToDoList entity);
        void Update(ToDoList entity);
        void Delete(ToDoList entity);

        ToDoList GetByIdWithItems(int id);
        List<ToDoList> GetAllWithItems();
    }
}
