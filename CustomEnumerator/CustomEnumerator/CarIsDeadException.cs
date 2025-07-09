using System;
using System.Data;
using System.Runtime.Serialization;

namespace CustomEnumerator
{
    [Serializable]
    public class CarIsDeadException : ApplicationException
    {
        //private string _message;
        //public CarIsDeadException() { }
        //public CarIsDeadException(string message) : base(message) { _message = message; }
        //public CarIsDeadException(string message, Exception innerException) : base(message, innerException) { }
        //protected CarIsDeadException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        //public override string Message => $"This is issue = {_message}";

        // This time we are not creating any message variable to display instead we can send to the parent class directly
        public CarIsDeadException() { }
        public CarIsDeadException(string message) : base(message) { }
        public CarIsDeadException(string message, Exception innerException) : base(message, innerException) { }
        protected CarIsDeadException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        // We didn't override the message property for displaying the message in console
    }
}