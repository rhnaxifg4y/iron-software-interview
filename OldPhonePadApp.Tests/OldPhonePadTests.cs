using NUnit.Framework;
using OldPhonePadApp;

namespace OldPhonePadApp.Tests
{
    [TestFixture]
    public class OldPhonePadTests
    {
        [TestCase("33#", "E")]
        [TestCase("227*#", "B")]
        [TestCase("4433555 555666#", "HELLO")]
        [TestCase("8 88777444666*664#", "TURING")]
        [TestCase("222 2 22#", "CAB")]
        public void OldPhonePad_ExampleCases_ShouldReturnCorrectOutput(string input, string expected)
        {
            Assert.AreEqual(expected, OldPhonePadConverter.OldPhonePad(input));
        }

        [Test]
        public void OldPhonePad_EmptyInput_ShouldReturnEmptyString()
        {
            Assert.AreEqual(string.Empty, OldPhonePadConverter.OldPhonePad(""));
        }

        [Test]
        public void OldPhonePad_NoHashTermination_ShouldReturnEmptyString()
        {
            Assert.AreEqual(string.Empty, OldPhonePadConverter.OldPhonePad("22"));
        }

        [Test]
        public void OldPhonePad_OnlyHash_ShouldReturnEmptyString()
        {
            Assert.AreEqual(string.Empty, OldPhonePadConverter.OldPhonePad("#"));
        }

        [Test]
        public void OldPhonePad_MultipleBackspaces_ShouldWorkCorrectly()
        {
            Assert.AreEqual("A", OldPhonePadConverter.OldPhonePad("227***#"));
        }

        [Test]
        public void OldPhonePad_BackspaceOnEmpty_ShouldNotThrow()
        {
            Assert.AreEqual("B", OldPhonePadConverter.OldPhonePad("*22#"));
        }

        [Test]
        public void OldPhonePad_InvalidChars_ShouldBeIgnored()
        {
            // My implementation ignores '1's, so this should be "BE"
            Assert.AreEqual("BE", OldPhonePadConverter.OldPhonePad("11122 33#"));
        }
    }
}
