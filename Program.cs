using CustomDelegates.Farm.Entities;
using CustomDelegates.Farm.Entities.Animals;
using CustomDelegates.Farm.Events;
using CustomDelegates.Infrastructure;

namespace CustomDelegates;

public class Program
{
    private static void InitialDispatch(Action launch) => launch();

    public static void Main(string[] args)
    {
        var dog = new Dog();
        InitialDispatch(() =>
        {
            new List<IEntity>
            {
                new Cat(),
                dog,
                dog
            };
            Subscribe.RegisterSubscriptions();
        });
        EventManager.Publish(dog, new SleepEvent());
    }
}