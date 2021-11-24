using System.Collections.Generic;

namespace ToDoListClassLibrary.Models
{
    public interface ITodoListModel
    {
        List<ITaskModel> Tasks { get; set; }
    }
}