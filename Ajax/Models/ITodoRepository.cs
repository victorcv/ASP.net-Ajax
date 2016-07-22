using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajax.Models
{
    public interface ITodoRepository
    {
        TodoItem Add(int priority, string description);
        bool ToggleDone(int id);
        IEnumerable<TodoItem> GetAll();
        TodoItem GetById(int id);
    }
}
