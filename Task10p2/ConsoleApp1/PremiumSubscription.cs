namespace ConsoleApp1
{
    public class PremiumSubscription : ISubscription
    {
        public string GetBenefits()
        {
            return "Премиум подписка: доступ к расширенным функциям.";
        }
    }
}