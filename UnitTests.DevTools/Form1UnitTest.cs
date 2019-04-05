using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFormsApp;

namespace UnitTests.DevTools {
    [TestClass]
    public class Form1UnitTest {
        [TestMethod]
        public void GenerateVariablesTest() {
            MainWindow myMainWindow = new MainWindow();
            List<string> listOfVariablesToDetect = new List<string>()
            {
                "V1",
                "Variable1",
                "Function123(myVariable1)"
            };
            List<string> listOfAnswers = new List<string>()
            {
                "V1",
                "Variable1",
                "Function123"
            };

            for(int i = 0; i < listOfVariablesToDetect.Count; i++){
                myMainWindow.InputText = listOfVariablesToDetect[i];
                var myVariables = myMainWindow.GenerateListOfInputVariables();
                myMainWindow.AddListOfSelectionVariablesToDisplayTextList(myVariables);
                Assert.AreEqual(listOfAnswers[i], myMainWindow.DisplayTextList[i]);
            }

            Assert.AreEqual(4, myMainWindow.DisplayTextList.Count);
        }
    }
}
