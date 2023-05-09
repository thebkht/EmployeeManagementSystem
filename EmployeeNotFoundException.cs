namespace EmployeeManagementSystem
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(string message) : base(message)
        {

        }

        public EmployeeNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class EmployeeAlreadyExistsException : Exception
    {
        public EmployeeAlreadyExistsException(string message) : base(message)
        {
        }
        public EmployeeAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class DublicateUsernameException : Exception
    {
        public DublicateUsernameException(string message) : base(message)
        {
        }
        public DublicateUsernameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string message) : base(message)
        {
        }
        public InvalidUsernameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {
        }
        public InvalidPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class InvalidHourlyRateException : Exception
    {
        public InvalidHourlyRateException(string message) : base(message)
        {
        }
        public InvalidHourlyRateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException(string message) : base(message)
        {
        }
        public TaskNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class TaskAlreadyExistsException : Exception
    {
        public TaskAlreadyExistsException(string message) : base(message)
        {
        }
        public TaskAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class InvalidTaskDescriptionException : Exception
    {
        public InvalidTaskDescriptionException(string message) : base(message)
        {
        }
        public InvalidTaskDescriptionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class InvalidTaskStatusException : Exception
    {
        public InvalidTaskStatusException(string message) : base(message)
        {
        }
        public InvalidTaskStatusException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
