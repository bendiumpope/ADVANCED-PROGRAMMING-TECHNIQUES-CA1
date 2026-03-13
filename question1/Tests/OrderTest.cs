using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class OrderTest
{
    [TestMethod]
    public void PayBillTest()
    {
        Order order = new Order(1, "Churros with Plain Sugar", 2);

        double result = order.PayBill(6);

        Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void CreateOrderTest()
    {
        Order order = new Order(2, "Churros with Chocolate Sauce", 1);

        Assert.AreEqual(2, order.OrderNo);
        Assert.AreEqual("Churros with Chocolate Sauce", order.OrderDetails);
        Assert.AreEqual(1, order.Quantity);
    }

    [TestMethod]
    public void PayBillMultipleQuantityTest()
    {
        Order order = new Order(3, "Churros with Nutella", 3);

        double result = order.PayBill(8);

        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void PayBillSingleItemTest()
    {
        Order order = new Order(4, "Churros with Cinnamon Sugar", 1);

        double result = order.PayBill(6);

        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void PayBillZeroQuantityTest()
    {
        Order order = new Order(5, "Churros with Plain Sugar", 0);

        double result = order.PayBill(6);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void PayBillChocolateSauceTest()
    {
        Order order = new Order(6, "Churros with Chocolate Sauce", 2);

        double result = order.PayBill(8);

        Assert.AreEqual(16, result);
    }
}