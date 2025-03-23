using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class IdNotFound:Exception
    {
        public IdNotFound() : base(ExceptionMessages.IdNotFound) { }
    }
}
