using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SubscriptionFactory factory = new PremiumFactory();
            ISubscription subscription = factory.CreateSubscription();
            Console.WriteLine(subscription.GetBenefits());
        }
    }
}