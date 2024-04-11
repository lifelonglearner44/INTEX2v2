using Microsoft.CodeAnalysis;

namespace INTEX2v2.Models.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IQueryable<Product> Products { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

        public string? CurrentProductCategory { get; set; }
    }
}
