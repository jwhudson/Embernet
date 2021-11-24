using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListClassLibrary.DataAccess;
using ToDoListClassLibrary.Models;

namespace PortfolioLaunchPage.Pages.Components
{
    public partial class ToDoTrackerComponent
    {
        [Inject]
        public ITodoListService TodoList { get; set; }
        private List<ITaskModel> currentTasks;
        private ITaskModel Task = new TaskModel();

        private void HandleValidCreate()
        {
            TodoList.AddTask(Task);
            Task = new TaskModel();
            DisplayTasks();
        }
        private void DisplayTasks()
        {
            currentTasks = TodoList.ReadTasks();
        }

        private string FormatTaskTime(ITaskModel task)
        {
            TimeSpan time = TodoList.TimeTaken(task);
            string formatHours = time.Hours.ToString("D2");
            string formatMinutes = time.Minutes.ToString("D2");
            return $"{formatHours}:{formatMinutes}";
        }

        
    }
}
