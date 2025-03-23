using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class NullPriceException:Exception
    {
        public NullPriceException() : base(ExceptionMessages.NullPriceException) { }

    }
}
