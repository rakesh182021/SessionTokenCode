namespace SessionTokenApi.Model
{
    public class SessionTokenRequest
    {
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string InvoiceNumber { get; set; }
        public string MerchantTxnId { get; set; }
    }
}
