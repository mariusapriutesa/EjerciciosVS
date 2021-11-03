using Ejemplo4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejemplo4.Commands
{
    class StudentCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string accion = parameter.ToString();

            if (accion.Equals("nuevo"))
            {
                studentViewModel.ListaEstudiantes.Add(studentViewModel.CurrentStudent);
            }
        }

        private StudentViewModel studentViewModel;
        public StudentCommand(StudentViewModel studentViewModel)
        {
            this.studentViewModel = studentViewModel;
        }
    }
}
