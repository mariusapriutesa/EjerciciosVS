using Ejemplo4.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejemplo4.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        public ViewModelBase SelectedViewModel 
        {
            get { return _selectedViewModel; }
            set 
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
             
        }

        public ICommand UpdateViewCommand { set; get; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
