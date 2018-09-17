namespace Models.Domain
{
    public class ShoppingCartItem : Entity
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }

        public long ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
