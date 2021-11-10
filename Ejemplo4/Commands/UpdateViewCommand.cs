using Ejemplo4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejemplo4.Commands
{
    class UpdateViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.viewModel.SelectedViewModel = new StudentViewModel();
             
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine(parameter.ToString());

            if (parameter.ToString().Equals("home")) {

                this.viewModel.SelectedViewModel = new HomeViewModel();

            } else if (parameter.ToString().Equals("login"))
            {
                this.viewModel.SelectedViewModel = new LoginViewModel();

            }else if (parameter.ToString().Equals("student"))
            {
                this.viewModel.SelectedViewModel = new StudentViewModel();

            } else if (parameter.ToString().Equals("tabla"))
            {
                viewModel.SelectedViewModel = new StudentTableViewModel();

            }
        }
        
    }
}
