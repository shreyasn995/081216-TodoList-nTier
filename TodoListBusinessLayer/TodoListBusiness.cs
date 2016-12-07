using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListBusinessLayer;

namespace TodoListBusinessLayer
{
    public class TodoListBusiness
    {
        TodoListDatabaseLayer.TodoListDatabase db = new TodoListDatabaseLayer.TodoListDatabase();

        public string ReadList()
        {
            return db.ReadList();
        }
        public void NewItem(string description)
        {
            db.NewItem(description);
        }
        public void DeleteItem(string itemId)
        {
            db.DeleteItem(Int32.Parse(itemId));
        }
        public void MarkItem(string itemId)
        {
            db.MarkItem(Int32.Parse(itemId));
        }
    }
}