using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class PriceExistException:Exception
    {
        public PriceExistException() : base(ExceptionMessages.PriceExistException) { }

    }
}
