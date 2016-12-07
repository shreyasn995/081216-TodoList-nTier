using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListDatabaseLayer
{
    public class TodoListDatabase
    {
        List<Item> itemList = new List<Item>();
        public string ReadList()
        {
            string listToReturn = null;
            foreach (Item item in itemList)
            {
                listToReturn += (item.ToString());
            }
            return listToReturn;
        }
        public void NewItem(string description)
        {
            Item newItem = new Item(description);
            itemList.Add(newItem);
        }
        public void DeleteItem(int itemId)
        {
            itemList.Remove(itemList[--itemId]);
        }
        public void MarkItem(int itemId)
        {
            itemList[--itemId].MarkDone();
        } 
    }

    internal class Item
    {
        string description;
        bool done;
        public Item(string description)
        {
            this.description = description;
            this.done = false;
        }

        public override string ToString()
        {
            return (description + " " + done.ToString() + "\n");
        }
        public void MarkDone()
        {
            done = true;
        }
    }
}
