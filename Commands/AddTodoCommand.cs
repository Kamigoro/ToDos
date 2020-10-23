using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using ToDoList.Models;
using ToDoList.ViewModels;

namespace ToDoList.Commands
{
    public class AddTodoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private MainViewModel _mainViewModel;

        public AddTodoCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _mainViewModel.AddTodo();
        }
    }
}
