using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class TodoRepository : ITodoRepository
    {
        private static Dictionary<int, TodoItem> _items = new Dictionary<int, TodoItem>()
                                                              {
                                                                  {
                                                                      1,
                                                                      new TodoItem()
                                                                          {
                                                                              Description = "Finish this course!",
                                                                              Id = 1,
                                                                              IsDone = false,
                                                                              Priority = 1
                                                                          }
                                                                      },
                                                                  {
                                                                      2,
                                                                      new TodoItem()
                                                                          {
                                                                              Description = "Goto the cinema",
                                                                              Id = 2,
                                                                              IsDone = false,
                                                                              Priority = 10
                                                                          }
                                                                      },
                                                                  {
                                                                      3,
                                                                      new TodoItem()
                                                                          {
                                                                              Description = "Begin my first MVC application",
                                                                              Id = 3,
                                                                              IsDone = true,
                                                                              Priority = 3
                                                                          }
                                                                      },
                                                              };
        private static int num = 4;


        public TodoItem Add(int priority, string description)
        {
            var newItem = new TodoItem();
            newItem.Priority = priority;
            newItem.Description = description;
            newItem.IsDone = false;
            newItem.Id = num++;
            _items.Add(newItem.Id, newItem);
            return newItem;
        }

        public bool ToggleDone(int id)
        {
            if (_items.ContainsKey(id))
            {
                _items[id].IsDone = !_items[id].IsDone;
                return true;
            }
            return false;
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _items.Values;
        }

        public TodoItem GetById(int id)
        {
            return _items[id];
        }
    }
}