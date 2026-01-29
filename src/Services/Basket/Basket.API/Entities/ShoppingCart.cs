namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; } = string.Empty;

        public List<ShoppingCartItem> Items { get; set; } = new();

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in Items)
                {
                    totalprice += item.Price * item.Quantity;
                }
                return totalprice;
            }
        }
    }




    public class ShoppingCartItem
    {
        public int Quantity { get; set; }
        public string Color { get; set; } = string.Empty;
        public decimal Price { get; set; } 
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;

    }
}
