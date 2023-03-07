using System;
using System.IO;
using Services.Abstractions;

namespace Services.Implementations
{
    public class PathValidator : IPathValidator
    {
        public bool IsValid(string value)
        {
            try
            {
                string root = Path.GetPathRoot(value);
                return string.IsNullOrEmpty(root.Trim('\\', '/')) == false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}