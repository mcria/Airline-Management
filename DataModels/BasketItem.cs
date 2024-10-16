﻿public class BasketItem : IBasketItem
{
    public Food FoodItem { get; set; }
    public int Quantity { get; set; }

    public BasketItem(Food fooditem, int quantity)
    {
        FoodItem = fooditem;
        Quantity = quantity;
    }

    public BasketItem(Food fooditem)
    {
        FoodItem = fooditem;
        Quantity = 1;
    }
}