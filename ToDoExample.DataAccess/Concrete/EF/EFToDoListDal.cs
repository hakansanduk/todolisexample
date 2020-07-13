using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoExample.DataAccess.Abstract;
using ToDoExample.Entities;

namespace ToDoExample.DataAccess.Concrete.EF
{
    public class EFToDoListDal : EFGenericRepository<ToDoList, ToDoContext>, IToDoListDal
    {
        public List<ToDoList> GetAllWithItems()
        {
            using (var context = new ToDoContext())
            {
                return context.ToDoList
                    .Include(i => i.ToDoItems)
                    .ToList();
            }
        }

        public ToDoList GetByIdWithItems(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.ToDoList
                    .Where(i => i.Id == id)
                    .Include(i => i.ToDoItems)
                    .FirstOrDefault();
            }
        }
    }
}
