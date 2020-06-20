using System;

namespace Ginder.Common.Helpers
{
    public class CommandResult<T>
    {
        public T Result { get; set; }
        public Exception Exception { get; set; }
        public bool IsSuccess { get; set; }
        
        public CommandResult(T result)
        {
            IsSuccess = true;
            Exception = null;
            Result = result;
        }

        public CommandResult(Exception exception)
        {
            Exception = exception;
            IsSuccess = false;
            Result = default;
        }

        public CommandResult()
        {
            
        }
    }
}
