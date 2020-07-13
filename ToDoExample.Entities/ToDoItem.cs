using System;

namespace ToDoExample.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public int ToDoListId { get; set; }
        public string Card { get; set; }
        public DateTime DateTime { get; set; }
        public bool isValid { get; set; }
    }
}