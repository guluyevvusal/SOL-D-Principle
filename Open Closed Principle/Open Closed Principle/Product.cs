namespace Open_Closed_Principle
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public abstract class Discount
    {
        public abstract decimal ApplyDiscount(Product product);
    }

    public class PercentageDiscount : Discount
    {
        private decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public override decimal ApplyDiscount(Product product)
        {
            return product.Price * (1 - _percentage);
        }
    }

    public class FixedAmountDiscount : Discount
    {
        private decimal _amount;

        public FixedAmountDiscount(decimal amount)
        {
            _amount = amount;
        }

        public override decimal ApplyDiscount(Product product)
        {
            return product.Price - _amount;
        }
    }

    public class ShoppingCart
    {
        private IEnumerable<Product> _products;
        private Discount _discount;

        public ShoppingCart(IEnumerable<Product> products, Discount discount)
        {
            _products = products;
            _discount = discount;
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Product product in _products)
            {
                total += _discount.ApplyDiscount(product);
            }
            return total;
        }
    }
}
