using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class IdExistException:Exception
    {
        public IdExistException() :base(ExceptionMessages.IdExistException) { }
    }
}
