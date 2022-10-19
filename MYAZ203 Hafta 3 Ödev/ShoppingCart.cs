namespace MYAZ203_Hafta_3_Ödev
{
    public class ShoppingCart
    {
        private List<CartItem> cartItems;

        public ShoppingCart()
        {
            cartItems = new List<CartItem>();
        }
        public void Add(CartItem cartItem)
        {
            cartItems.Add(cartItem);
        }

        public void GetBalance()
        {
            double balance = 0;
            foreach(CartItem cartItem in cartItems)
            {
                balance += (cartItem.Product.Price) * cartItem.Quantity;
            }
            Console.WriteLine("Toplam sepet tutarı: {0}",balance);
        }
       
        public void GetList()
        {
            foreach (CartItem cartItem in cartItems)
            {
                Console.WriteLine($"Product Id: {cartItem.CartId } Product Name: {cartItem.Product.ProductName} Quantity: {cartItem.Quantity}");
            }
        }
        public void Delete(int id)
        {
            var productId = cartItems.FirstOrDefault(a => a.CartId == id);
            if (productId == null)
                Console.WriteLine("Silinmesi istenilen id ye sahip ürün bulunamadı.\n");
            cartItems.Remove(productId);
        }
    }
}
