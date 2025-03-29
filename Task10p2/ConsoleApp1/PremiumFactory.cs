namespace ConsoleApp1
{
    public class PremiumFactory : SubscriptionFactory
    {
        public override ISubscription CreateSubscription()
        {
            return new PremiumSubscription();
        }
    }
}