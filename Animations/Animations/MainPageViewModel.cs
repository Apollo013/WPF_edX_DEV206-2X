using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animations
{
    public sealed class MainPageViewModel : ViewModel
    {
        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { _isLoading = value; NotifyPropertyChanged(); }
        }

        private List<string> _phoneticNames;
        public List<string> PhoneticNames
        {
            get { return _phoneticNames; }
            set { _phoneticNames = value; NotifyPropertyChanged(); }
        }

        public MainPageViewModel()
        {
            LoadData();
        }

        private async void LoadData()
        {
            IsLoading = true;
            await Task.Delay(TimeSpan.FromSeconds(3d));
            PhoneticNames = new List<string> { "Thomas", "Union", "Victor", "William", "X-ray", "Young", "Zero" };
            IsLoading = false;
        }

    }
}
