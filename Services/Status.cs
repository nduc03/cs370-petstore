namespace petstore
{
    public struct Status(bool success, string message)
    {
        public readonly bool Success => success;
        public readonly string Message => message;
    }

    public struct Status<T>(bool success, string message, T? data)
    {
        public readonly bool Success => success;
        public readonly string Message => message;
        public readonly T? Data => data;
    }
}
