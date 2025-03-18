namespace Shared
{
    public static class Exceptions
    {
        public static void ThrowIfNullOrEmpty(string field, string paramName)
        {
            ArgumentException.ThrowIfNullOrEmpty(field, paramName);
        }

        public static void OutOfRangeException(decimal field, string paramName) => ArgumentOutOfRangeException.ThrowIfNegativeOrZero(field, paramName);

    }
}
