using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Convertor.Parser;

namespace Convertor.Test
{
    [TestClass]
    public class TestArgumentParser
    {
        IArgumentParser validator;

        [TestInitialize]
        public void Initialize()
        {
            validator = new AlcolizerArgumentParser();
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        [TestCategory("Test Argument Validator")]
        public void IfArgumentLengthIsZeroShouldThrowException()
        {
            string[] args = new string[0];
            var actual = validator.Parse(args);
        }

        [TestMethod]
        [TestCategory("Test Argument Validator")]
        [ExpectedException(typeof(System.Exception))]
        public void ShouldThrowExceptionIfFormatIsInvalid()
        {
            string[] args = new string[1];
            args[0] = "Invalid";
            var actual = validator.Parse(args);
        }

        [TestMethod]
        [TestCategory("Test Argument Validator")]
        public void MicroGramPer100mLShouldReturnMicroGramPer100mL()
        {
            string[] args = new string[1];
            args[0] = "ug/100mL";
            var actual = validator.Parse(args);
            Assert.AreEqual("ug/100mL", actual);
        }

        [TestMethod]
        [TestCategory("Test Argument Validator")]
        public void MilliGramPerLShouldReturnMilliGramPerL()
        {
            string[] args = new string[1];
            args[0] = "mg/L";
            var actual = validator.Parse(args);
            Assert.AreEqual("mg/L", actual);
        }

        [TestMethod]
        [TestCategory("Test Argument Validator")]
        public void GramPer210LShouldReturnGramPer210L()
        {
            string[] args = new string[1];
            args[0] = "g/210L";
            var actual = validator.Parse(args);
            Assert.AreEqual("g/210L", actual);
        }

        [TestMethod]
        [TestCategory("Test Argument Validator")]
        public void GramPer230LShouldReturnGramPer230L()
        {
            string[] args = new string[1];
            args[0] = "g/230L";
            var actual = validator.Parse(args);
            Assert.AreEqual("g/230L", actual);
        }

        [TestMethod]
        [TestCategory("Test Argument Validator")]
        public void GramPerdLShouldReturnGramPerdL()
        {
            string[] args = new string[1];
            args[0] = "g/dL";
            var actual = validator.Parse(args);
            Assert.AreEqual("g/dL", actual);
        }

        [TestMethod]
        [TestCategory("Test Argument Validator")]
        public void MicroGramPerLShouldReturnMicroGramPerL()
        {
            string[] args = new string[1];
            args[0] = "ug/L";
            var actual = validator.Parse(args);
            Assert.AreEqual("ug/L", actual);
        }

        [TestMethod]
        [TestCategory("Test Argument Validator")]
        public void GramPerLShouldReturnGramPerL()
        {
            string[] args = new string[1];
            args[0] = "g/L";
            var actual = validator.Parse(args);
            Assert.AreEqual("g/L", actual);
        }

    }
}
