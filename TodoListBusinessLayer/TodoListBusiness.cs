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
        public void DeleteItem(int itemId)
        {
            db.DeleteItem(itemId);
        }
        public void MarkItem(int itemId)
        {
            db.MarkItem(itemId);
        }
    }
}