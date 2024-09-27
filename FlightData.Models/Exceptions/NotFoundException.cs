namespace FlightData.Models.Exceptions;

public class NotFoundException(string message) : ApplicationException(message)
{
}