namespace HavitGridFooterBugBlazorServer.App.Models
{
    public class Invoice
    {
        public Invoice(
            int number,
            string clientName,
            decimal total)
        {
            if (string.IsNullOrWhiteSpace(clientName))
                throw new ArgumentNullException(nameof(clientName));

            Number = number;
            ClientName = clientName;
            Total = total;
        }

        public int Number { get; private set; }

        public string ClientName { get; private set; }

        public decimal Total { get; private set; }
    }
}