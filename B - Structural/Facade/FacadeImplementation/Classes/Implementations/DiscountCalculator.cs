using FacadeImplementation.Classes.Contracts;

namespace FacadeImplementation.Classes.Implementations
{
    public class DiscountCalculator : IDiscountCalculator
    {
        private readonly Lazy<CustomerDiscountBaseService> _customerDiscountBaseService;
        private readonly Lazy<OrderService> _orderService;
        private readonly Lazy<DayOfTheWeekFactorService> _dayOfTheWeekFactorService;

        public DiscountCalculator()
        {
            _customerDiscountBaseService = 
                new Lazy<CustomerDiscountBaseService>(() => new CustomerDiscountBaseService());
            _orderService = 
                new Lazy<OrderService>(() => new OrderService());
            _dayOfTheWeekFactorService = 
                new Lazy<DayOfTheWeekFactorService>(() => new DayOfTheWeekFactorService());
        }

        public double Calculate(int customerId)
        {
            var orders = 10;
            if (!_orderService.Value.HasEnoughOrders(customerId, orders))
                return 0;

            return _customerDiscountBaseService.Value.CalculateDiscountBase(customerId)
                * _dayOfTheWeekFactorService.Value.CalculateDayOfTheWeekFactor();
        }
    }
}
