namespace ConsoleApp1
{
    public class FreeFactory : SubscriptionFactory
    {
        public override ISubscription CreateSubscription()
        {
            return new FreeSubscription();
        }
    }
}