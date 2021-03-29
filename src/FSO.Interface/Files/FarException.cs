using System;

namespace FSO.Interface.Files
{
    /// <summary>
    /// Represents an exception thrown by a FAR3Archive instance.
    /// </summary>
    public class FarException : Exception
    {
        public FarException(string message)
            : base(message)
        {
        }
    }
}