using System;

public class TooManyLoginAttemptsException : Exception
{
    public TooManyLoginAttemptsException() : base("Слишком много попыток входа в систему.") { }

    public TooManyLoginAttemptsException(string message) : base(message) { }

    public TooManyLoginAttemptsException(string message, Exception innerException) : base(message, innerException) { }
}