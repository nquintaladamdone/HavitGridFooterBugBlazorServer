using Havit.Blazor.Components.Web;
using Havit.Blazor.Components.Web.Bootstrap;
using HavitGridFooterBugBlazorServer.App.Models;
using Microsoft.AspNetCore.Components;

namespace HavitGridFooterBugBlazorServer.App.Components
{
    public partial class Invoices
    {
        private readonly IEnumerable<Invoice> _invoices = new List<Invoice>()
        {
            new Invoice(1, "Client #1", 10.00m),
            new Invoice(2, "Client #2", 20.00m),
            new Invoice(3, "Client #3", 30.00m),
            new Invoice(4, "Client #4", 40.00m),
            new Invoice(5, "Client #5", 50.00m),
            new Invoice(6, "Client #6", 60.00m),
            new Invoice(7, "Client #7", 70.00m),
            new Invoice(8, "Client #8", 80.00m),
            new Invoice(9, "Client #9", 90.00m),
            new Invoice(10, "Client #10", 100.00m),
            new Invoice(11, "Client #11", 110.00m),
            new Invoice(12, "Client #12", 120.00m),
            new Invoice(13, "Client #13", 130.00m),
            new Invoice(14, "Client #14", 140.00m),
            new Invoice(15, "Client #15", 150.00m),
            new Invoice(16, "Client #16", 160.00m),
            new Invoice(17, "Client #17", 170.00m),
            new Invoice(18, "Client #18", 180.00m),
            new Invoice(19, "Client #19", 190.00m),
            new Invoice(20, "Client #20", 200.00m)
        }.AsEnumerable();

        [Inject] private IHxMessageBoxService? MessageBox { get; set; }

        public Task<GridDataProviderResult<Invoice>> OnLoadItems(GridDataProviderRequest<Invoice> request)
        {
            return Task.FromResult(request.ApplyTo(_invoices));
        }

        public async Task OnInvoiceSelected(Invoice? selectedInvoice)
        {
            if (selectedInvoice == null || MessageBox == null)
                return;

            await MessageBox.ShowAsync(
                "Information",
                $"Invoice #{selectedInvoice.Number} clicked!");
        }

        public decimal GetGrandTotal()
        {
            return _invoices.Sum(i => i.Total);
        }
    }
}