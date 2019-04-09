using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFormsApp;

namespace UnitTests.DevTools
{
    [TestClass]
    public class SelectionVariableUnitTests
    {
        [TestMethod]
        public void BaseWordTests()
        {
            var inputString = "01word1SomeOtherNumber";
            var selectionVariable = new SelectionVariable(2, 5);

            var baseWord = selectionVariable.SetBaseWord(inputString);

            Assert.AreEqual("word", baseWord);
        }
    }
}
