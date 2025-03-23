using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class KeyboardExistException : Exception
    {
        public KeyboardExistException() : base(ExceptionMessages.KeyboardExistException) { }

    }
}
