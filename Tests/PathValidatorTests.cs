using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Abstractions;
using Services.Implementations;

namespace Tests
{
    [TestClass]
    public class PathValidatorTests
    {

        [DataTestMethod]
        [DataRow(" ")]
        [DataRow("")]
        [DataRow("C:/abc\"d")]
        [DataRow("C:/abc<d")]
        [DataRow("C:/abc>d")]
        [DataRow("C:/abc|d")]
        [DataRow("./abc")]
        public void GivenPathValidatorWhenIsValidInvokedThenResultIsInValid(string prop)
        {
            IPathValidator validator = new PathValidator();
            Assert.IsFalse(validator.IsValid(prop));
        }

        [DataTestMethod]
        [DataRow(@"C:\\abc")]
        [DataRow(@"F:\FILES\")]
        [DataRow(@"C:\\abc.docx\\defg.docx")]
        [DataRow(@"C:\\\//\/\\/\\\/abc/\/\/\/\///\\\//\defg")]
        [DataRow(@"C:/abc/def~`!@#$%^&()_-+={[}];',.g")]
        [DataRow(@"C:\\\\\abc////////defg")]
        public void GivenPathValidatorWhenIsValidInvokedThenResultIsValid(string prop)
        {
            IPathValidator validator = new PathValidator();
            Assert.IsTrue(validator.IsValid(prop));
        }
    }
}