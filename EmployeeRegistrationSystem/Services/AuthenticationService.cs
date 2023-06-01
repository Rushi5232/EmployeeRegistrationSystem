namespace EmployeeRegistrationSystem.Services
{
    public class AuthenticationService
    {
        public bool Authenticate(string username, string password)
        {
            // Perform authentication logic here
            if (username == "admin" && password == "@admin")
            {
                return true;
            }

            return false;
        }
    }
}