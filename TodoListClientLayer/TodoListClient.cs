using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListBusinessLayer;

namespace TodoListClientLayer
{
    class TodoListClient
    {
        static void Main(string[] args)
        {
            TodoListBusinessLayer.TodoListBusiness todoList = new TodoListBusiness();

            Startup: Console.WriteLine("Hi there, this is your existing TODO LIST");
            Console.Write(todoList.ReadList());

            Console.WriteLine("Enter command and press enter - (n)ew, (d)elete or (m)ark as done: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "n":
                    Console.WriteLine("Enter new item description: ");
                    string newItemDescription = Console.ReadLine();
                    // New item
                    goto Startup;
                case "d":
                    Console.WriteLine("Enter item number to delete: ");
                    string idToDelete = Console.ReadLine();
                    // Delete item
                    goto Startup;
                case "m":
                    Console.WriteLine("Enter item number to mark as done: ");
                    string idToChange = Console.ReadLine();

                    goto Startup;
                default:
                    Console.WriteLine("Invalid option!");
                    goto Startup;
            }
        }
    }
}
