using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class TypeExistException:Exception
    {
        public TypeExistException() : base(ExceptionMessages.TypeExistException) { }

    }
}
