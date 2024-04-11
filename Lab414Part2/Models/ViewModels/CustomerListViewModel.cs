namespace INTEX2v2.Models.ViewModels
{
    public class CustomerListViewModel
    {
        public IQueryable<Customer> Customers { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
