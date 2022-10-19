using MYAZ203_Hafta_3_Ödev;

Product product1 = new Product { ProductId = 101, ProductName = "Orkide 5 lt yağ", Price = 187 };
Product product2 = new Product { ProductId = 210, ProductName = "HUAWEI FreeBuds 4i", Price = 1499 };
Product product3 = new Product { ProductId = 19, ProductName = "Mi Smart Band 6", Price = 849 };

CartItem item1 = new CartItem { CartId = 1, Product = product1, Quantity = 5 };
CartItem item2 = new CartItem { CartId = 2, Product = product2, Quantity = 2 };
CartItem item3 = new CartItem { CartId = 3, Product = product3, Quantity = 19 };

ShoppingCart manager = new ShoppingCart();

manager.Add(item1);
manager.Add(item2);
manager.Add(item3);

manager.Delete(4);

manager.GetList();
manager.GetBalance();

Console.ReadLine();
