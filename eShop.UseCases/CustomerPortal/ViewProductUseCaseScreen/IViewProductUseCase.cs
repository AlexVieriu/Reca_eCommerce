﻿namespace eShop.UseCases.CustomerPortal.ViewProductUseCaseScreen;

public interface IViewProductUseCase
{
    Product Execute(int productId);
}