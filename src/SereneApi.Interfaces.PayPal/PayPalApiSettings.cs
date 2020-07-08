namespace SereneApi.Interfaces.PayPal
{
    internal static class PayPalApiSettings
    {
        public static string PayPalSource = "https://api.paypal.com/";

        public static string PayPalSandboxSource = "https://api.sandbox.paypal.com/";

        public static string AuthenticationResource = "oauth2";

        public static string AuthenticationResourcePath = "v1/";

        public static string TransactionResource = "transactions";

        public static string TransactionResourcePath = "v1/reporting/";
    }
}
