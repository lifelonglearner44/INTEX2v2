using Microsoft.EntityFrameworkCore;
using INTEX2v2.Data;

namespace INTEX2v2.Models
{
    public class EFINTEX2v2Repository : IINTEX2v2Repository
    {
        private ApplicationDbContext _context;
        public EFINTEX2v2Repository(ApplicationDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<Customer> Customers  => _context.Customers;

        public IQueryable<Order> Orders => _context.Orders;

        public IQueryable<Product> Products => _context.Products;

        public IQueryable<LineItem> LineItems => _context.LineItems;

        public IQueryable<Recommendation> Recommendations => _context.Recommendations;

        public void AddProduct(Product Product)
        {
            _context.Add(Product);
            _context.SaveChanges();
        }

        public void RemoveProduct(Product Product)
        {
            _context.Remove(Product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product Product)
        {
            _context.Update(Product);
            _context.SaveChanges();
        }

        public void AddCustomer(Customer Customer)
        {
            _context.Add(Customer);
            _context.SaveChanges();
        }

        public void RemoveCustomer(Customer Customer)
        {
            _context.Remove(Customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer Customer)
        {
            _context.Update(Customer);
            _context.SaveChanges();
        }

        public void AddRecommendation(Recommendation Recommendation)
        {
            _context.Add(Recommendation);
            _context.SaveChanges();
        }

        public void RemoveRecommendation(Recommendation Recommendation)
        {
            _context.Remove(Recommendation);
            _context.SaveChanges();
        }

        public void UpdateRecommendation(Recommendation Recommendation)
        {
            _context.Update(Recommendation);
            _context.SaveChanges();
        }
    }
}
