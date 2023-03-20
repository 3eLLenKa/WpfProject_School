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
        public RelayCommand RussianLevelsViewCommand { get; set; }
        public RelayCommand EnglishLevelsViewCommand { get; set; }

        public GeneralViewModel GeneralVM { get; set; }

        public SettingsViewModel SettingsVM { get; set; }
        public RussianLevelsViewModel RussianLevelsVM { get; set; }
        public EnglishLevelsViewModel EnglishLevelsVM { get; set; }

        private object _currentView;
        private object _currentViewLevels;
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public object CurrentViewLevels
        {
            get { return _currentViewLevels; }
            set
            {
                _currentViewLevels = value; 
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            GeneralVM = new GeneralViewModel();
            SettingsVM = new SettingsViewModel();
            RussianLevelsVM = new RussianLevelsViewModel();
            EnglishLevelsVM = new EnglishLevelsViewModel();

            CurrentView = GeneralVM;
            CurrentViewLevels = RussianLevelsVM;

            GeneralViewCommand = new RelayCommand(o => { CurrentView = GeneralVM; });
            SettingsViewCommand = new RelayCommand(o => { CurrentView = SettingsVM; });
            RussianLevelsViewCommand = new RelayCommand(o => { CurrentViewLevels = RussianLevelsVM; });
            EnglishLevelsViewCommand = new RelayCommand(o => { CurrentViewLevels = EnglishLevelsVM; });
        }
    }
}
