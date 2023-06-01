using EmployeeRegistrationSystem.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace EmployeeRegistrationSystem.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        // Implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Properties for data binding
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set
            {
                employeeName = value;
                OnPropertyChanged(nameof(EmployeeName));
            }
        }

        private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                contactNumber = value;
                OnPropertyChanged(nameof(ContactNumber));
            }
        }

        private string emailID;

        public string EmailID
        {
            get { return emailID; }
            set
            {
                emailID = value;
                OnPropertyChanged(nameof(EmailID));
            }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        private string education = "B. Tech";

        public string Education
        {
            get { return education; }
            set
            {
                education = value;
                OnPropertyChanged(nameof(Education));
            }
        }

        public List<string> EducationOptions { get; } = new List<string>
        {
            "MCA",
            "B. Tech",
            "B. Sc. (cs)",
            "M. Tech",
            "Other"
        };

        private int totalExperience;

        public int TotalExperience
        {
            get { return totalExperience; }
            set
            {
                totalExperience = value;
                OnPropertyChanged(nameof(TotalExperience));
            }
        }

        private Visibility _registerButtonTooltipVisibility;

        public Visibility RegisterButtonTooltipVisibility
        {
            get { return _registerButtonTooltipVisibility; }
            set
            {
                _registerButtonTooltipVisibility = value;
                OnPropertyChanged(nameof(RegisterButtonTooltipVisibility));
            }
        }

        // IDataErrorInfo implementation for data validation
        public string this[string columnName]
        {
            get
            {
                string errorMessage = null;

                switch (columnName)
                {
                    case "EmployeeName":
                        if (string.IsNullOrEmpty(EmployeeName))
                            errorMessage = "Employee name is required.";
                        break;

                    case "ContactNumber":
                        if (string.IsNullOrEmpty(ContactNumber))
                            errorMessage = "Contact number is required.";
                        else if (!Regex.IsMatch(ContactNumber, "^[0-9]{10}$"))
                            errorMessage = "Contact number must be 10 digits.";
                        break;

                    case "EmailID":
                        if (string.IsNullOrEmpty(EmailID))
                            errorMessage = "Email ID is required.";
                        else if (!Regex.IsMatch(EmailID, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                            errorMessage = "Invalid email format.";
                        break;

                    case "Address":
                        if (string.IsNullOrEmpty(Address))
                            errorMessage = "Address is required.";
                        break;

                    case "Education":
                        if (string.IsNullOrEmpty(Education))
                            errorMessage = "Education is required.";
                        break;

                    case "TotalExperience":
                        if (TotalExperience <= 0)
                            errorMessage = "Total experience must be a positive number.";
                        break;
                }

                return errorMessage;
            }
        }

        // Return the first error message from the IDataErrorInfo implementation
        public string Error => this[string.Empty];

        // Command properties for register, modify, and delete
        public ICommand RegisterCommand { get; }

        public ICommand ModifyCommand { get; }
        public ICommand DeleteCommand { get; }

        // Selected employee property
        private EmployeeModel selectedEmployee;

        public EmployeeModel SelectedEmployee
        {
            get { return selectedEmployee; }
            set
            {
                selectedEmployee = value;
                OnPropertyChanged(nameof(SelectedEmployee));
            }
        }

        // ObservableCollection for holding the list of employees
        public ObservableCollection<EmployeeModel> Employees { get; }

        // Constructor
        public EmployeeViewModel()
        {
            Employees = new ObservableCollection<EmployeeModel>();
            RegisterCommand = new RelayCommand(RegisterEmployee, CanRegisterEmployee);
            ModifyCommand = new RelayCommand(ModifyEmployee, CanModifyEmployee);
            DeleteCommand = new RelayCommand(DeleteEmployee, CanDeleteEmployee);
        }

        // Command methods for register, modify, and delete
        private bool CanRegisterEmployee(object parameter)
        {
            bool canRegister = !string.IsNullOrWhiteSpace(EmployeeName) &&
                               !string.IsNullOrWhiteSpace(ContactNumber) &&
                               !string.IsNullOrWhiteSpace(EmailID) &&
                               !string.IsNullOrWhiteSpace(Address) &&
                               !string.IsNullOrWhiteSpace(Education) &&
                               TotalExperience > 0;

            RegisterButtonTooltipVisibility = canRegister ? Visibility.Collapsed : Visibility.Visible;

            return canRegister;
        }

        private void RegisterEmployee(object parameter)
        {
            var newEmployee = new EmployeeModel
            {
                EmployeeName = EmployeeName,
                ContactNumber = ContactNumber,
                EmailID = EmailID,
                Address = Address,
                Education = Education,
                TotalExperience = TotalExperience
            };

            Employees.Add(newEmployee);
            ClearFields();
        }

        private bool CanModifyEmployee(object parameter)
        {
            return SelectedEmployee != null && string.IsNullOrEmpty(Error);
        }

        private void ModifyEmployee(object parameter)
        {
            SelectedEmployee.EmployeeName = EmployeeName;
            SelectedEmployee.ContactNumber = ContactNumber;
            SelectedEmployee.EmailID = EmailID;
            SelectedEmployee.Address = Address;
            SelectedEmployee.Education = Education;
            SelectedEmployee.TotalExperience = TotalExperience;

            ClearFields();
        }

        private bool CanDeleteEmployee(object parameter)
        {
            return SelectedEmployee != null;
        }

        private void DeleteEmployee(object parameter)
        {
            Employees.Remove(SelectedEmployee);
            ClearFields();
        }

        // Helper method to clear input fields
        private void ClearFields()
        {
            EmployeeName = string.Empty;
            ContactNumber = string.Empty;
            EmailID = string.Empty;
            Address = string.Empty;
            Education = null;
            TotalExperience = 0;
            SelectedEmployee = null;
        }
    }
}