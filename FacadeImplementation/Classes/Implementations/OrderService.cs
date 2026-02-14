namespace FacadeImplementation.Classes.Implementations
{
    public class OrderService
    {
        public bool HasEnoughOrders(int customerId, int orders)
        {
            return orders > 5;
        }
    }
}
