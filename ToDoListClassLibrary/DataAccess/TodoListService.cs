using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListClassLibrary.Models;

namespace ToDoListClassLibrary.DataAccess
{
    public class TodoListService : ITodoListService
    {
        private ITodoListModel _todoList;

        public TodoListService(ITodoListModel todoList)
        {
            _todoList = todoList;
        }

        public void AddTask(ITaskModel task)
        {
            _todoList.Tasks.Add(task);
        }

        public List<ITaskModel> ReadTasks()
        {
            return _todoList.Tasks;
        }

        public TimeSpan TimeTaken(ITaskModel task)
        {
            return task.TaskEndTime - task.TaskStartTime;
        }

    }
}
