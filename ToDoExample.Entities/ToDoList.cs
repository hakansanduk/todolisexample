using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoExample.Entities
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isValid { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }
    }
}
