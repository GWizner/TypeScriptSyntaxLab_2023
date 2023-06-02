using System.Linq;
public class Program
{

    public static void Main(string[] args)
    {
        CustomerOrder[] sampleOrders = new CustomerOrder[]
        {
            new CustomerOrder() {customerName = "Acme Hardware", item = "Mouse", price = 25, quantity = 3},
            new CustomerOrder() {customerName = "Acme Hardware", item = "Keyboard", price = 45, quantity = 2},
            new CustomerOrder() {customerName = "Falls Realty", item = "Macbook", price = 800, quantity = 2},
            new CustomerOrder() {customerName = "Julie's Morning Diner", item = "iPad", price = 525, quantity = 1},
            new CustomerOrder() {customerName = "Julie's Morning Diner", item = "Credit Card Reader", price = 45, quantity = 1}
        };

        var sampleOrdersByCustomer = sampleOrders.GroupBy(x => x.customerName).OrderBy(x => x.Key).ToArray();
        var columnName1 = "CustomerName";
        var columnName2 = "Item";
        var columnName3 = "Price";
        var columnName4 = "Quantity";

        Console.WriteLine($"{columnName1:0,20} {columnName2:0,10} {columnName3:0,20} {columnName4:0,20}");

        foreach (var currCustomerGroup in sampleOrdersByCustomer)
        {
            Console.WriteLine($"{currCustomerGroup.Key}");
            foreach (var currOrder in currCustomerGroup)
            {
                decimal total = currOrder.quantity * currOrder.price;
                Console.WriteLine($"     {currOrder.item:0,10} ${currOrder.price:0,20} {currOrder.quantity:0,20} == ${total}");
            }
        }

        foreach (var currGroup in sampleOrdersByCustomer)
        {
            var currGroupOrdersArray = currGroup.ToArray();
            //Console.WriteLine($"{currGroup.Key}     {currGroup.First()}");
            Console.WriteLine($"{currGroup.Key}     {currGroupOrdersArray[0].item} {currGroupOrdersArray[0].price} {currGroupOrdersArray[0].quantity}");
            var currGroupOrdersArrayExceptFirstArray = currGroupOrdersArray.Skip(1);
            foreach (var currOrder in currGroupOrdersArrayExceptFirstArray)
            {
                decimal total = currOrder.quantity * currOrder.price;
                Console.WriteLine($"     {currOrder.item} ${currOrder.price} {currOrder.quantity} == ${total}");
            }
        }
    }

    public class CustomerOrder
    {
        public string customerName { get; set; }
        public string item { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
    }

}
