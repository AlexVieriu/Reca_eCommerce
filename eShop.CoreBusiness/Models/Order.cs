﻿namespace eShop.CoreBusiness.Models;

public class Order
{
    public Order()
    {
        LineItems = new();
    }

    public int? OrderId { get; set; }                   // the number of the Order
    public DateTime? DatePlaced { get; set; }
    public DateTime? DateProcessing { get; set; }
    public DateTime? DateProcessed { get; set; }
    public string CustomerName { get; set; }
    public string CustomerAddress { get; set; }
    public string CustomerCity { get; set; }
    public string CustomerStateProvince { get; set; }
    public string CustomerCountry { get; set; }
    public string AdminUser { get; set; }
    public List<OrderLineItem> LineItems { get; set; }  // each line Item will have a product in it
    public string UniqueId { get; set; }


    // Add OrderLineItem
    public void AddProduct(int productId, int qty, double price, Product product)
    {
        var item = LineItems.FirstOrDefault(x => x.ProductId == productId);

        if (qty > 0 && price > 0)
        {
            if (item == null)
                LineItems.Add(new OrderLineItem() { ProductId = productId, Price = price, Quantity = qty, Product = product });
            else
                item.Quantity += qty;
        }
    }

    // Remove OrderLineItem
    public void RemoveProduct(int productId)
    {
        var item = LineItems.FirstOrDefault(x => x.ProductId == productId);
        if (item !=null)
            LineItems.Remove(item);                         
    }
}
