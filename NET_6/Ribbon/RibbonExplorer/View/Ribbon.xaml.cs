﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RibbonExplorer
{
    public partial class Ribbon : UserControl
    {
        public Ribbon()
        {
            InitializeComponent();
            Tag = Properties.Resources.Ribbon;
            foreach (var key in Resources.Keys)
            {
                var cmd = Resources[key] as C1ToolbarCommand;
                if (cmd != null)
                {
                    CommandManager.RegisterClassCommandBinding(GetType(), new CommandBinding(
                      cmd, (s, e) => Execute(cmd.LabelTitle), (s, e) => e.CanExecute = true));
                }
            }
        }

        void Execute(string text)
        {
            tb.Text += text + "\n";
            tb.SelectionStart = tb.Text.Length;
        }

        private void OnHomeDialogLaunched(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog launcher clicked!");
        }
    }

    public class C1ToolbarCommand : ICommand
    {
        public string LabelTitle { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
        }
    }
}
