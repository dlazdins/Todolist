using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TodoListFunctionality
{
    public class TodoListManager
    {
        public static string NameOfToDoList;
        private static List<string> todoTasks = new List<string>();
        public static void AddNewTask(string task)
        {
            todoTasks.Add(task);
        }

        public static void ShowTodos()
        {
            Console.WriteLine(NameOfToDoList + " has this to do: ");
            foreach (string todo in todoTasks)
            {
                Console.WriteLine(todo);
            }
        }
    }
}
