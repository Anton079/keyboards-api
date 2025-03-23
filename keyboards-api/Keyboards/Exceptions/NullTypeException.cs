using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class NullTypeException:Exception
    {
        public NullTypeException() : base(ExceptionMessages.NullTypeException) { }

    }
}
