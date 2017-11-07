using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListFunctionality;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter task");

            TodoListManager.AddNewTask("buy milk");
            TodoListManager.AddNewTask("nopļauj zāli");

            TodoListManager.NameOfToDoList = "Groceries";

            TodoListManager.ShowTodos();

            Console.ReadKey();
        }
    }
}
