using keyboards_api.System;

namespace keyboards_api.Keyboards.Exceptions
{
    public class ModelExistException : Exception
    {
        public ModelExistException() : base(ExceptionMessages.ModelExistException) { }

    }
}
