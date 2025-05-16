namespace petstore
{
    public interface IStatus
    {
        bool Success { get; }
        string Message { get; }
    }
    public record Status(bool Success, string Message) : IStatus;

    public record Status<T>(bool Success, string Message, T? Data) : IStatus;
}
