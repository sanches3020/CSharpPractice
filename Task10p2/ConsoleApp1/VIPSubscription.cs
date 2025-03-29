using ConsoleApp1;

namespace ConsoleApp1
{
    public class VIPSubscription : ISubscription
    {
        public string GetBenefits()
        {
            return "VIP подписка: доступ ко всем функциям.";
        }
    }
}