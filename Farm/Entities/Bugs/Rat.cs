﻿using CustomDelegates.Farm.Events;
using CustomDelegates.Infrastructure;

namespace CustomDelegates.Farm.Entities.Bugs;

[Subscribe]
public record Rat : IEntity
{
   public void FoodSubscription(IEntity sender, FoodEvent @event)
    {
        Console.WriteLine("Cat food received!!");
    }

    public void SleepSubscription(IEntity sender, SleepEvent @event)
    {
        Console.WriteLine("Cat sleeping");
    }

    public void Subscription(IEntity sender, BroadCastEvent @event)
    {
        Console.WriteLine("what do you want!!");
    }
}