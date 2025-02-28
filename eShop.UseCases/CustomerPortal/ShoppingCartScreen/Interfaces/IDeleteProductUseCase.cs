﻿namespace eShop.UseCases.CustomerPortal.ShoppingCartScreen.Interfaces;

public interface IDeleteProductUseCase
{
    Task<Order> ExecuteAsync(int productId);
}
