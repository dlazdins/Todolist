using System;           

namespace ToDoList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ToDoTasks.Add(task);
        }

        public static void DeleteToDoFromList()

        {
            ShowToDos();
            Console.WriteLine("Please enter number to delete:");
            int deletableToDoNumber = int.Parse(Console.ReadLine());

            int indexInList = deletableToDoNumber - 1;
            if (ToDoTasks.Count > indexInList)
            {
                ToDoTasks.RemoveAt(deletableToDoNumber);
            }
        }


            public static void ShowToDos()

            {
                Console.WriteLine(NameOfToDoList + " has this to do: ");
                for (int i = 0; i < ToDoTasks.Count; i++)
                {
                    if (ToDoTasks[i] == "")
                    {
                        Console.WriteLine("--[NO ENTRY HERE]--");
                        continue;
                    }
                    Console.WriteLine(i + ". " + ToDoTasks[i]);
                }
            }

        public static void SaveToFile()
        {
            string.path = ???

             File.WriteAllLines(Path, ToDoTasks)
        }
        }
    }