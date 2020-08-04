namespace SereneApi.Interfaces.PayPal
{
    internal static class PayPalApiSettings
    {
        public static string PayPalSource { get; } = "https://api.paypal.com/";

        public static string PayPalSandboxSource { get; } = "https://api.sandbox.paypal.com/";

        public static string AuthenticationResource { get; } = "oauth2";

        public static string AuthenticationResourcePath { get; } = "v1/";

        public static string TransactionResource { get; } = "transactions";

        public static string TransactionResourcePath { get; } = "v1/reporting/";
    }
}
