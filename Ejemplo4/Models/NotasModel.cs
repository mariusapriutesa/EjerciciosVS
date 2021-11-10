using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models
{
   public  class NotasModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string di { set; get; }
        public string DI {
        
                get { return di; }
                set
            {
                    di = value;
                    OnPropertyChanged(nameof(DI));
                }
        }
        private string psp { set; get; }
        public string PSP
        {

            get { return psp; }
            set
            {
                psp = value;
                OnPropertyChanged(nameof(PSP));
            }
            
        }
        public NotasModel() {
            psp = "5";
        
        }
    }
}
