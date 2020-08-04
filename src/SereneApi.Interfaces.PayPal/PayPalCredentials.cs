namespace SereneApi.Interfaces.PayPal
{
    public class PayPalCredentials
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public PayPalCredentials()
        {
        }

        public PayPalCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
