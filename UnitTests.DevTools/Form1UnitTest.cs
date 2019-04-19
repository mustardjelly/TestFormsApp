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
            var textToTest = "Function123(myVariable1) {" +
                             "  method1;" +
                             "}";

            myMainWindow.InputText = textToTest;
            var myVariables = myMainWindow.GenerateListOfInputVariables();

            Assert.AreEqual(3, myVariables.Count, "All variables were not found.");
        }

        [TestMethod]
        public void DoesCurrentVariableOverlapExistingTest_NoOverlaps()
        {
            MainWindow myMainWindow = new MainWindow();
            var currentVariable = new SelectionVariable(2, 4);
            bool result;

            List<SelectionVariable> existingVariables = new List<SelectionVariable>()
            {
                new SelectionVariable(0, 1),
                new SelectionVariable(6, 1)

            };

            foreach (var existingVariable in existingVariables)
            {
                result = myMainWindow.DoesCurrentVariableOverlapExisting(currentVariable, existingVariable);
                Assert.IsFalse(result, $"Expected current I:2 L:4 not to overlap with existing I:{existingVariable.Index} L:{existingVariable.Length}");
            }
        }

        [TestMethod]
        public void DoesCurrentVariableOverlapExistingTest_AllOverlaps()
        {
            MainWindow myMainWindow = new MainWindow();
            var currentVariable = new SelectionVariable(2, 4);
            bool result;

            List<SelectionVariable> existingVariables = new List<SelectionVariable>()
            {
                new SelectionVariable(0, 3), // overlap on existing RHS
                new SelectionVariable(5, 1), // overlap on existing LHS
                new SelectionVariable(2, 4), // duplicate
                new SelectionVariable(3, 1), // currentVariable envelopes the existing variable
                new SelectionVariable(1, 6), // currentVariable is enveloped by the existing variable


            };

            foreach (var existingVariable in existingVariables)
            {
                result = myMainWindow.DoesCurrentVariableOverlapExisting(currentVariable, existingVariable);
                Assert.IsTrue(result, $"Expected current I:2 L:4 not to overlap with existing I:{existingVariable.Index} L:{existingVariable.Length}");
            }
        }

        [TestMethod]
        public void SetVariableIteration()
        {
            MainWindow myMainWindow = new MainWindow();
            myMainWindow.InputText = "Function123(myVariable1)";
            string resultString;

            var mySelectionVariables =  myMainWindow.GenerateListOfInputVariables();

            for (int i = 0; i < 10; i++)
            {
                resultString = myMainWindow.GetIteratedVariable(mySelectionVariables[0], i);
                Assert.AreEqual($"Function{i}", resultString);

                resultString = myMainWindow.GetIteratedVariable(mySelectionVariables[1], i);
                Assert.AreEqual($"myVariable{i}", resultString);

            }
        }


    }
}
