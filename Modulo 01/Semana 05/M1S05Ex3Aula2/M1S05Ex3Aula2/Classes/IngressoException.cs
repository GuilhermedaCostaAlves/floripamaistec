namespace M1S05Ex3Aula2.Classes
{
    internal class IngressoException : Exception
    {
        public IngressoException() 
        { 

        }

        public IngressoException(string message) : base(message)
        {

        }

        public IngressoException(string message, Exception causaException) : base(message, causaException)
        {

        }
    }  
}
