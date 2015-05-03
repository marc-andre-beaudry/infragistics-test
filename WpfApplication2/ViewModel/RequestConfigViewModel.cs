using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication2.ViewModel
{
    public class RequestConfigViewModel : BaseViewModel
    {
        public ICommand ClearDateCommand { get; set; }
        public ICommand SendRequestCommand { get; set; }

        private DateTime? _selectedDate;
        public DateTime? SelectedDate
        {
            get
            {
                return _selectedDate;
            }
            set
            {
                _selectedDate = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged("IsClearButtonVisible");
            }
        }

        public Boolean IsClearButtonVisible
        {
            get
            {
                return (_selectedDate != null);
            }
        }

        public RequestConfigViewModel()
        {
            ClearDateCommand = new RelayCommand(ClearDateCommandHandler);
            SendRequestCommand = new RelayCommand(SendRequestCommandHandler);
        }

        private void SendRequestCommandHandler(object obj)
        {
        }

        private void ClearDateCommandHandler(object obj)
        {
            SelectedDate = null;
        }
    }
}
