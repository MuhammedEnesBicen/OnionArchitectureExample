namespace OnionArchitectureExample.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Validation error occureed")
        {

        }

        public ValidationException(string message) : base(message)
        {

        }

        public ValidationException(Exception exception) : this(exception.Message)
        {

        }

    }
}
