namespace keyboards_api.System
{
    public class ExceptionMessages
    {
        // General Exceptions
        public static readonly string NullKeyboardException = "Obiectul keyboard este null!";
        public static readonly string KeyboardExistException = "Obiectul keyboard deja există!";

        // Keyboard Attribute Exceptions
        public static readonly string NullIdException = "Atributul id este null!";
        public static readonly string IdNotFound = "Atributul Id nu a fost găsit!";
        public static readonly string NullTypeException = "Atributul Type este null, trebuie să îl completezi!";
        public static readonly string NullModelException = "Atributul Model este null, trebuie să îl completezi!";
        public static readonly string NullPriceException = "Atributul Price este null, trebuie să îl completezi!";

        // Attribute Already Exists Exceptions
        public static readonly string IdExistException = "Atributul id există deja!";
        public static readonly string TypeExistException = "Atributul type există deja!";
        public static readonly string ModelExistException = "Atributul model există deja!";
        public static readonly string PriceExistException = "Atributul price există deja!";
    }
}
