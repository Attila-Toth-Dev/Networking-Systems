namespace MGC_Application.Data
{
    public class UserData(string _username, string _password)
    {
        public string Username { get; set; } = _username;

        public string Password { get; set; } = _password;
    }
}
