﻿namespace eShop.UseCases.CustomerPortal.OrderConfirmationScreen;

public class ViewOrderConfirmationUseCase : IViewOrderConfirmationUseCase
{
    private readonly IOrderRepository _orderRepository;

    public ViewOrderConfirmationUseCase(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Order Execute(string uniqueId)
    {
        return _orderRepository.GetOrderByUniqueId(uniqueId);
    }
}
