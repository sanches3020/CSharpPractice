namespace ConsoleApp1
{
    public class VIPFactory : SubscriptionFactory
    {
        public override ISubscription CreateSubscription()
        {
            return new VIPSubscription();
        }
    }
}