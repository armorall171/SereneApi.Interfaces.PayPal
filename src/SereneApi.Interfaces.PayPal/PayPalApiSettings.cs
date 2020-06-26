namespace SereneApi.Interfaces.PayPal
{
    public static class PayPalApiSettings
    {
        public static string PayPalSource = "https://api.paypal.com/";

        public static string PayPalSandboxSource = "https://api.sandbox.paypal.com/";

        public static string AuthenticationResource = "oauth2";

        public static string AuthenticationResourcePath = "v1/";

        //public static string TransactionResource = "transactions";
        public static string TransactionResource = "transactions?start_date=2020-06-20T00:00:00Z&end_date=2020-06-26T00:00:00Z";

        public static string TransactionResourcePath = "v1/reporting/";
    }
}
