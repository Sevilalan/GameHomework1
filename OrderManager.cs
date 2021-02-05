using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework1
{
    public class OrderManager : IOrderService
    {
        public void SatısYap(Product product)
        {
            Console.WriteLine("Satış işlemi başarı ile tamamlandı! Satın alınan ürün: "+ product.ProductName);
        }
    }
}
