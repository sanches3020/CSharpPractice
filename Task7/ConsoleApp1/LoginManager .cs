using System;

namespace ConsoleApp1
{
    class LoginManager
    {
        private int _maxAttempts = 3;
        private int _currentAttempts = 0;

        public void AttemptLogin(int attempts)
        {
            _currentAttempts += attempts;

            if (_currentAttempts > _maxAttempts)
            {
                throw new TooManyLoginAttemptsException($"Попытки входа: {_currentAttempts}. Доступ заблокирован.");
            }

            Console.WriteLine($"Попытки входа: {_currentAttempts}. Вход выполнен успешно.");
        }
    }
}