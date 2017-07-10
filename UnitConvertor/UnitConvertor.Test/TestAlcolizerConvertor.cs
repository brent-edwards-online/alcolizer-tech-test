using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Convertor.UnitConvertor;

namespace Convertor.Test
{
    [TestClass]
    public class TestAlcolizerConvertor
    {
        private IUnitConvertor convertor;

        [TestInitialize]
        public void Initialize()
        {
            convertor = new AlcolizerConvertor();
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void OneGramPerLitreShouldReturn100000MicroGramPer100mL()
        {
            var actual = convertor.Convert(1.0, "g/L", "ug/100mL");
            Assert.AreEqual("100000.000000 ug/100mL", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void OneMilliGramPerLitreShouldReturn001000GramsPerLitre()
        {
            var actual = convertor.Convert(1.0, "mg/L", "g/L");
            Assert.AreEqual("0.001000 g/L", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void OneGramPer230LShouldReturn004348GramsPerLitre()
        {
            var actual = convertor.Convert(1.0, "g/230L", "g/L");
            Assert.AreEqual("0.004348 g/L", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void CanConvertTougPer100mL()
        {
            var actual = convertor.Convert(2.5, "g/230L", "ug/100mL");
            Assert.AreEqual("1086.956522 ug/100mL", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void CanConvertTomgPerL()
        {
            var actual = convertor.Convert(2.5, "g/dL", "mg/L");
            Assert.AreEqual("25000.000000 mg/L", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void CanConvertTogPer210L()
        {
            var actual = convertor.Convert(2.5, "ug/L", "g/210L");
            Assert.AreEqual("0.000525 g/210L", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void CanConvertTogPer230L()
        {
            var actual = convertor.Convert(3.5, "g/L", "g/230L");
            Assert.AreEqual("805.000000 g/230L", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void CanConvertTogPerdL()
        {
            var actual = convertor.Convert(8.5, "mg/L", "g/dL");
            Assert.AreEqual("0.000850 g/dL", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void CanConvertTougPerL()
        {
            var actual = convertor.Convert(15, "g/dL", "ug/L");
            Assert.AreEqual("150000000.000000 ug/L", actual);
        }

        [TestMethod]
        [TestCategory("Test Alcolizer Convertor")]
        public void CanConvertTogPerL()
        {
            var actual = convertor.Convert(15, "g/230L", "g/L");
            Assert.AreEqual("0.065217 g/L", actual);
        }
    }
}
