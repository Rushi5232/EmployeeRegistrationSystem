using EmployeeRegistrationSystem.ViewModels;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeRegistrationSystem.Views
{
    public partial class LoginWindow : Window
    {
        public LoginWindowViewModel ViewModel { get; }

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginWindowViewModel viewModel)
            {
                viewModel.Password = ((PasswordBox)sender).Password;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DataContext is LoginWindowViewModel viewModel && !viewModel.IsLoggedIn)
            {
                viewModel.OnLoginWindoClosed();
            }
            base.OnClosing(e);
        }
    }
}