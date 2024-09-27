namespace FlightData.Models.Exceptions;

public class InternalServerException(string message) : ApplicationException(message)
{
}