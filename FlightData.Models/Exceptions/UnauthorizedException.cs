namespace FlightData.Models.Exceptions;

public class UnauthorizedException(string message) : ApplicationException(message)
{
}