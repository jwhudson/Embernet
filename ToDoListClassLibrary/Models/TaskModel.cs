using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListClassLibrary.Models
{
    public class TaskModel : ITaskModel
    {
        [Required(ErrorMessage ="Please enter a name for the task")]
        [StringLength(16, ErrorMessage ="Task name too long.")]
        public string TaskName { get; set; }
        [Required]
        public DateTime TaskStartTime { get; set; } = DateTime.Now;
        [Required]
        public DateTime TaskEndTime { get; set; } = DateTime.Now;
        public DateTime TaskDueDate { get; set; } = DateTime.Now;
        public TaskTypeModel TaskType { get; set; }
        public bool CompletionStatus { get; set; }

    }
}
