﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BKV_LAB_3_WPF
{
    public class CustomCommand : ICommand
    {
        Action action;
        public event EventHandler? CanExecuteChanged;

        public CustomCommand(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            action();
        }
    }
}
