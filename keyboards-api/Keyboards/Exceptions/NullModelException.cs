using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class NullModelException:Exception
    {
        public NullModelException() : base(ExceptionMessages.NullModelException) { }

    }
}
