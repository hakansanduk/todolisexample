using System;
using System.Collections.Generic;
using System.Text;
using ToDoExample.Entities;

namespace ToDoExample.DataAccess.Abstract
{
    public interface IToDoItemDal:IRepository<ToDoItem>
    {
    }
}
