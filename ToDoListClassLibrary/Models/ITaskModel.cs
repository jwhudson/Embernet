using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoListClassLibrary.Models
{
    public interface ITaskModel
    {
        string TaskName { get; set; }
        DateTime TaskStartTime { get; set; }
        DateTime TaskEndTime { get; set; }
        DateTime TaskDueDate { get; set; }
        bool CompletionStatus { get; set; }

        TaskTypeModel TaskType { get; set; }
    }
}