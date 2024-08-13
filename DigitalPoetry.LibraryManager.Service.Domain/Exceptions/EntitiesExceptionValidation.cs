namespace DigitalPoetry.LibraryManager.Service.Domain.Exceptions
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;

    /// <summary>Entities Exception Validation</summary>
    public class EntitiesExceptionValidation : Exception
    {
        /// <summary>EntitiesExceptionValidation Constructor</summary>
        /// <param name="error">Error Message</param>
        public EntitiesExceptionValidation(string errorMessage) : base(errorMessage) { }

        /// <summary>Throw Exception When Condition is True</summary>
        /// <param name="condition">Condition</param>
        /// <param name="errorMessage">Error Message</param>
        /// <exception cref="EntitiesExceptionValidation">Throw Exception</exception>
        public static void When(bool condition, string errorMessage)
        {
            if (condition) throw new EntitiesExceptionValidation(errorMessage);
        }
    }
}