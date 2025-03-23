using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class NullKeyboardException:Exception
    {
        public NullKeyboardException() : base(ExceptionMessages.NullKeyboardException) { }

    }
}
