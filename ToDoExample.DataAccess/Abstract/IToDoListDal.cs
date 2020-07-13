using System;
using System.Collections.Generic;
using System.Text;
using ToDoExample.DataAccess.Concrete.EF;
using ToDoExample.Entities;

namespace ToDoExample.DataAccess.Abstract
{
    public interface IToDoListDal:IRepository<ToDoList>
    {
        ToDoList GetByIdWithItems(int id);
        List<ToDoList> GetAllWithItems();
    }
}
