using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class NullIdException:Exception
    {
        public NullIdException() : base(ExceptionMessages.NullIdException) { }

    }
}
