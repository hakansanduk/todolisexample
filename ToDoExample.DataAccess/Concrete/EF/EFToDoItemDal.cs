using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ToDoExample.DataAccess.Abstract;
using ToDoExample.Entities;

namespace ToDoExample.DataAccess.Concrete.EF
{
    public class EFToDoItemDal : EFGenericRepository<ToDoItem, ToDoContext>, IToDoItemDal
    {
      
    }
}
