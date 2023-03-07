namespace Services.Abstractions
{
    /// <summary>
    /// Validates if number is valid
    /// </summary>
    public interface INumberValidator
    {
        /// <summary>
        /// Validates if number is valid.
        /// Checks if provided string is null or empty and if string is a number.
        /// </summary>
        /// <param name="value">string representation of number</param>
        /// <returns>true if valid or false if invalid</returns>
        bool IsValid(string value);
    }
}