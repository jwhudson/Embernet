using System;
using System.Collections.Generic;
using ToDoListClassLibrary.Models;

namespace ToDoListClassLibrary.DataAccess
{
    public interface ITodoListService
    {
        void AddTask(ITaskModel task);
        List<ITaskModel> ReadTasks();
        TimeSpan TimeTaken(ITaskModel task);
    }
}