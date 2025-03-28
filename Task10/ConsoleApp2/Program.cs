using System;

namespace StrategyPatternExample
{
    public interface IRatingStrategy
    {
        double CalculateRating(int userId);
    }

    public class SimpleRating : IRatingStrategy
    {
        public double CalculateRating(int userId)
        {
           
            return 5.0; 
        }
    }

    public class ComplexRating : IRatingStrategy
    {
        public double CalculateRating(int userId)
        {
            return new Random().Next(1, 11); 
        }
    }

    public class MachineLearningRating : IRatingStrategy
    {
        public double CalculateRating(int userId)
        {
            return 7.5; 
        }
    }

    public class UserRatingService
    {
        private IRatingStrategy _ratingStrategy;

        public void SetRatingStrategy(IRatingStrategy ratingStrategy)
        {
            _ratingStrategy = ratingStrategy;
        }

        public double CalculateRating(int userId)
        {
            if (_ratingStrategy == null)
                throw new InvalidOperationException("Стратегия не установлена.");

            return _ratingStrategy.CalculateRating(userId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserRatingService userRatingService = new UserRatingService();

            userRatingService.SetRatingStrategy(new SimpleRating());
            Console.WriteLine($"Simple Rating: {userRatingService.CalculateRating(1)}");

            userRatingService.SetRatingStrategy(new ComplexRating());
            Console.WriteLine($"Complex Rating: {userRatingService.CalculateRating(1)}");

            userRatingService.SetRatingStrategy(new MachineLearningRating());
            Console.WriteLine($"Machine Learning Rating: {userRatingService.CalculateRating(1)}");
        }
    }
}