using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ToDoList.Commands;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Todo> Todos { get; set; } = new ObservableCollection<Todo>();
        public AddTodoCommand AddTodoCommand { get; set; }
        public string TodoDescription { get; set; }

        public MainViewModel()
        {
            AddTodoCommand = new AddTodoCommand(this);
        }

        public void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(TodoDescription))
                Todos.Add(new Todo() { Description = TodoDescription });
        }

    }
}
