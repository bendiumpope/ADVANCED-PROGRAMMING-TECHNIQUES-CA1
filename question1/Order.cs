using System;

public class Order
{
    private string orderDetails;
    private int quantity;
    private double bill;
    private int orderNo;

    // Properties
    public string OrderDetails
    {
        get { return orderDetails; }
        set { orderDetails = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public double Bill
    {
        get { return bill; }
        set { bill = value; }
    }

    public int OrderNo
    {
        get { return orderNo; }
        set { orderNo = value; }
    }

    // Constructor
    public Order(int orderNo, string orderDetails, int quantity)
    {
        this.orderNo = orderNo;
        this.orderDetails = orderDetails;
        this.quantity = quantity;
    }

    // Method to calculate bill
    public double PayBill(double price)
    {
        bill = price * quantity;
        return bill;
    }

    // Method to display order collection
    public void CollectOrder()
    {
        Console.WriteLine($"Order {orderNo} collected: {orderDetails}");
    }
}