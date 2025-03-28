namespace RaceGameApp
{
    public class RaceGame
    {
        private List<IPlayerObserver> _observers = new List<IPlayerObserver>();
        private string _raceStatus;

        public void Attach(IPlayerObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IPlayerObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_raceStatus);
            }
        }

        public void StartRace()
        {
            _raceStatus = "Гонка началась!";
            Notify();
        }

        public void UpdateRaceStatus(string status)
        {
            _raceStatus = status;
            Notify();
        }

        public void EndRace()
        {
            _raceStatus = "Гонка закончилась!";
            Notify();
        }
    }
    public interface IPlayerObserver
    {
        void Update(string status);
    }

    public class Spectator : IPlayerObserver
    {
        public void Update(string status)
        {
            Console.WriteLine($"Зритель: {status}");
        }
    }

    public class RaceCommentator : IPlayerObserver
    {
        public void Update(string status)
        {
            Console.WriteLine($"Комментатор: {status}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RaceGame raceGame = new RaceGame();
            Spectator spectator = new Spectator();
            RaceCommentator commentator = new RaceCommentator();

            raceGame.Attach(spectator);
            raceGame.Attach(commentator);

            raceGame.StartRace();

            raceGame.UpdateRaceStatus("Игрок 1 лидирует!");
            raceGame.UpdateRaceStatus("Игрок 2 догоняет!");
            raceGame.EndRace();
        }
    }
}