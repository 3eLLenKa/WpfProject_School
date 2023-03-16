using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfProject_School.Core;
using WpfProject_School.MVVM.View;

namespace WpfProject_School.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand GeneralViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }
        public GeneralViewModel GeneralVM { get; set; }

        public SettingsViewModel SettingsVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            GeneralVM = new GeneralViewModel();
            SettingsVM = new SettingsViewModel();

            CurrentView = GeneralVM;

            GeneralViewCommand = new RelayCommand(o => { CurrentView = GeneralVM; });
            SettingsViewCommand = new RelayCommand(o => { CurrentView = SettingsVM; });
        }
    }
}
