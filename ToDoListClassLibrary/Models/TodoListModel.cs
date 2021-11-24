using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListClassLibrary.Models
{
    public class TodoListModel : ITodoListModel
    {
        public List<ITaskModel> Tasks { get; set; } = new List<ITaskModel>();

    }
}
