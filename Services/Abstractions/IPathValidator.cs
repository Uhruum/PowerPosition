namespace Services.Abstractions
{
    /// <summary>
    /// Validates if path is valid
    /// </summary>
    public interface IPathValidator
    {
        /// <summary>
        /// Validates if path is valid.
        /// Checks if provided string is null or empty and if string is a valid path.
        /// </summary>
        /// <param name="value">path</param>
        /// <returns>true if valid or false if invalid</returns>
        bool IsValid(string value);
    }
}