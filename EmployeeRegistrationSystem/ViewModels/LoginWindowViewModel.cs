using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace EmployeeRegistrationSystem.ViewModels
{
    public class LoginWindowViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private Visibility _incorrectCredentialsVisibility = Visibility.Collapsed;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public Visibility IncorrectCredentialsVisibility
        {
            get { return _incorrectCredentialsVisibility; }
            set
            {
                _incorrectCredentialsVisibility = value;
                OnPropertyChanged(nameof(IncorrectCredentialsVisibility));
            }
        }

        public bool IsLoggedIn { get; private set; }
        public ICommand LoginCommand { get; }

        public event EventHandler LoginSuccessful;
        public event EventHandler LoginWindoClosed;

        public LoginWindowViewModel()
        {
            LoginCommand = new RelayCommand(Login);
        }

        private void Login(object obj)
        {
            if (_username == "admin" && _password == "@admin")
            {
                IsLoggedIn = true;
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                IncorrectCredentialsVisibility = Visibility.Visible;
            }
        }

        public void OnLoginWindoClosed()
        {
            LoginWindoClosed?.Invoke(this, EventArgs.Empty);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}