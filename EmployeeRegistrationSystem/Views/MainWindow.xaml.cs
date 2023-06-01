using EmployeeRegistrationSystem.Services;
using EmployeeRegistrationSystem.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace EmployeeRegistrationSystem.Views
{
    public partial class MainWindow : Window
    {
        private AuthenticationService _authenticationService;
        private LoginWindow _loginWindow;

        public MainWindow()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ShowLoginDialog();
        }

        private void ShowLoginDialog()
        {
            _loginWindow = new LoginWindow
            {
                Owner = this,
                DataContext = new LoginWindowViewModel()
            };
            (_loginWindow.DataContext as LoginWindowViewModel).LoginSuccessful += LoginWindow_LoginSuccessful;
            (_loginWindow.DataContext as LoginWindowViewModel).LoginWindoClosed += MainWindow_LoginWindoClosed;
            _loginWindow.ShowDialog();
        }

        private void MainWindow_LoginWindoClosed(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginWindow_LoginSuccessful(object sender, EventArgs e)
        {
            Visibility = Visibility.Visible;
            _loginWindow.Close();
        }

        // contact number field should restrict the input to numeric values only
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }
    }
}