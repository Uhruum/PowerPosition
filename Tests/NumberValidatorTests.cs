using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Abstractions;
using Services.Implementations;

namespace Tests
{
    [TestClass]
    public class NumberValidatorTests
    {
        [DataTestMethod]
        [DataRow(" ")]
        [DataRow("")]
        [DataRow("a")]
        [DataRow("a12")]
        public void GivenNumberValidatorWhenIsValidInvokedThenResultIsInValid(string prop)
        {
            INumberValidator validator = new NumberValidator();
            Assert.IsFalse(validator.IsValid(prop));
        }

        [DataTestMethod]
        [DataRow("2")]
        [DataRow("5")]
        [DataRow("8 ")]
        [DataRow(" 12")]
        public void GivenNumberValidatorWhenIsValidInvokedThenResultIsValid(string prop)
        {
            INumberValidator validator = new NumberValidator();
            Assert.IsTrue(validator.IsValid(prop));
        }
    }
}