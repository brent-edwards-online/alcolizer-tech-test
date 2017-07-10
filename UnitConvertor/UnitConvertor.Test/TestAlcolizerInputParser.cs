using Convertor.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitConvertor.Test
{
    [TestClass]
    public class TestAlcolizerInputParser
    {
        IInputParser parser;

        [TestInitialize]
        public void Initialize()
        {
            parser = new AlcolizerInputParser();
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        [ExpectedException(typeof(System.Exception))]
        public void EmptyStringShouldThrowException()
        { 
            var actual = parser.Parse("");
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        [ExpectedException(typeof(System.Exception))]
        public void InvalidStringShouldThrowException()
        {
            var actual = parser.Parse("Invalid");
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        [ExpectedException(typeof(System.Exception))]
        public void NegativeValueShouldThrowException()
        {
            var actual = parser.Parse("-1 g/L");
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void DoubleValueShouldParseCorrectly()
        {
            var actual = parser.Parse("1 g/L");
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("g/L", actual.Item2);

        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void IntValueShouldParseCorrectly()
        {
            var actual = parser.Parse("1.0 g/L");
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("g/L", actual.Item2);

        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        [ExpectedException(typeof(System.Exception))]
        public void InvalidValueShouldThrowException()
        {
            var actual = parser.Parse("RUBBISH g/L");
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        [ExpectedException(typeof(System.Exception))]
        public void MissingValueShouldThrowException()
        {
            var actual = parser.Parse("g/L");
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        [ExpectedException(typeof(System.Exception))]
        public void MissingUnitsShouldThrowException()
        {
            var actual = parser.Parse("1.0");
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void MicroGPer100mLShouldParseCorrectly()
        {
            var actual = parser.Parse("1.0 ug/100mL" );
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("ug/100mL", actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void MilliGPerLShouldParseCorrectly()
        {
            var actual = parser.Parse("1.0 mg/L");
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("mg/L", actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void GramsPer210LShouldParseCorrectly()
        {
            var actual = parser.Parse("1.0 g/210L");
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("g/210L", actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void GramsPer230LShouldParseCorrectly()
        {
            var actual = parser.Parse("1.0 g/230L");
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("g/230L", actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void GramsPerdLShouldParseCorrectly()
        {
            var actual = parser.Parse("1.0 g/dL");
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("g/dL", actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void MicroGramsPerLShouldParseCorrectly()
        {
            var actual = parser.Parse("1.0 ug/L");
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("ug/L", actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Input Parser")]
        public void GramsPerLShouldParseCorrectly()
        {
            var actual = parser.Parse("1.0 g/L");
            Assert.AreEqual(1.0, actual.Item1);
            Assert.AreEqual("g/L", actual.Item2);
        }
    }
}