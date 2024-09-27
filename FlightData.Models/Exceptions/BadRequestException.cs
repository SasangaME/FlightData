namespace FlightData.Models.Exceptions;

public class BadRequestException(string message) : ApplicationException(message)
{
}