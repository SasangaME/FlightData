namespace FlightData.Models.Exceptions;

public class ApplicationException(string message) : Exception(message)
{
}