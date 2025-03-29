namespace ConsoleApp1
{
    public class FreeSubscription : ISubscription
    {
        public string GetBenefits()
        {
            return "Бесплатная подписка: доступ к основным функциям.";
        }
    }
}