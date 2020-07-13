using System;
using System.Collections.Generic;
using System.Text;
using ToDoExample.Entities;

namespace ToDoExample.Business.Abstract
{
    public interface IToDoItemService
    {
        ToDoItem GetById(int id);
        List<ToDoItem> GetAll();
        void Create(ToDoItem entity);
        void Update(ToDoItem entity);
        void Delete(ToDoItem entity);
    }
}
