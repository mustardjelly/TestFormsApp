using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFormsApp;

namespace UnitTests.DevTools {
    [TestClass]
    public class Form1UnitTest {
        [TestMethod]
        public void MakeNumberStatusList_Debug() {
            //MainWindow.FindVariables("Variable1Variable2Variable30Variable4", 10);
            string[] things = {"Variable1", "public static void ThisIsTheFunction1()", "Variable1 = Variable2", "SomeFunction[variable1]"};
            List<string> outPuts = new List<string>();
            foreach (var thing in things) {
                string returnString = new MainWindow().GenerateListOfInputVariables(thing);

                if (returnString != string.Empty) {
                    outPuts.Add(returnString);
                }

            }
        }
    }
}
