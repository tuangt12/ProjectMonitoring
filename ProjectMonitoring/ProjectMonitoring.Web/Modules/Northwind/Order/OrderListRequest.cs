using Serenity.Services;

namespace ProjectMonitoring.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}