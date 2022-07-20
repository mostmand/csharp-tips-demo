using OneOf;

namespace Demo_15_OneOf;

public class Sample
{
    private readonly Random _random = new();
    
    public int DoAndThrowExceptionOnError()
    {
        if (ThrowError())
        {
            throw new Exception("Normal Exception");
        }

        return 10;
    }
    
    public OneOf<int, Exception> DoAndReturnResultOrError()
    {
        if (ThrowError())
        {
            return new Exception("OneOf Error");
        }

        return 10;
    }

    private bool ThrowError()
    {
        var randomNumber = _random.Next(0, 2);
        var throwError = randomNumber == 1;
        return throwError;
    }
}