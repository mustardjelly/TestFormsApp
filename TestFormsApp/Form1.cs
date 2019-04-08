using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

[assembly: InternalsVisibleTo("UnitTests.DevTools")]

namespace TestFormsApp
{
    public partial class MainWindow : Form
    {
        private List<SelectionVariable> selections;
        private int Multiplier = 10;

        public MainWindow()
        {
            InitializeComponent();
            selections = new List<SelectionVariable>();
        }

        #region Event methods

        /// <summary>
        /// Event for double clicking on the display list box.
        /// </summary>
        private void DisplayListBox_DoubleClick(object sender, MouseEventArgs e)
        {
            var removeIndex = DisplayListBox.SelectedIndex;

            try
            {
                RemoveSelectionVariable(removeIndex);
                RefreshItemDataSource(DisplayListBox, DisplayTextList);
                SetOutputText(Multiplier);

            }
            catch
            {
                throw new IndexOutOfRangeException();
            }

        }

        /// <summary>
        /// Handles selection of variables
        /// </summary>
        private void InputTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if ((sender as RichTextBox).Text == string.Empty)
            {
                return;
            }
            var currentVariable = CreateCurrentSelectionVariable();

            // Guard against white space or duplicates
            //      Checking for white spaces
            //      Overlap check
            //      Duplicate check
            AddAndRefreshVariableToVariableList(currentVariable, true);

        }

        /// <summary>
        /// Handles changes to the Input Text Box
        /// </summary>
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the input box is unchanged
            if (InputText == InputTextBox.Text)
            {
                return;
            }

            if (selections == null)
            {
                selections = new List<SelectionVariable>();
            }

            // Reset the lists here
            ClearDisplayedVariables();

            InputText = InputTextBox.Text;
            // Add code for auto detecting variables here
            var listOfDetectedVariables = GenerateListOfInputVariables();
            foreach (var sv in listOfDetectedVariables)
            {
                //selections.Add(sv);
                AddAndRefreshVariableToVariableList(sv, false);
            }

            RefreshItemDataSource(DisplayListBox, DisplayTextList);
            SetOutputText(Multiplier);

            //// Add detected variables to the display list
            //AddListOfSelectionVariablesToDisplayTextList(selections);
            //// Refresh the DisplayListBox
            //RefreshItemDataSource(controlObject: DisplayListBox, list: DisplayTextList);
            //// Generate auto guess in Output Box here
        }

        /// <summary>
        /// Sets the number of iterations to create. Defaults to 10.
        /// </summary>
        private void IterationsChanged(object sender, EventArgs e)
        {
            Multiplier = (int)(sender as NumericUpDown).Value;
            SetOutputText(Multiplier);
        }

        #endregion

        #region Working methods

        internal void AddAndRefreshVariableToVariableList(SelectionVariable currentVariable = null, bool refresh = false)
        {
            #region checking code
            if (currentVariable == null) {
                currentVariable = CreateCurrentSelectionVariable();
            }

            // filter white space
            if (currentVariable.Length == 0)
            {
                return;
            }

            // filter duplicates and overlapping variables
            foreach (var selection in selections)
            {
                if (DoesCurrentVariableOverlapExisting(currentVariable, selection))
                {
                    SetOutputText(Multiplier);
                    return; // do not add invalid selections
                }

            }
            #endregion

            #region adding code
            AddSelectionVariable(currentVariable);

            #endregion

            #region refreshing code

            if (refresh)
            {
                RefreshItemDataSource(DisplayListBox, DisplayTextList);
                SetOutputText(10);
            }

            #endregion

        }

        private void AddSelectionVariable(SelectionVariable currentVariable)
        {

            selections.Add(currentVariable);
            var variableBase = currentVariable.BaseWord(InputText);
            if (DisplayTextList.Contains(variableBase))
            {
                return;
            }
            DisplayTextList.Add(variableBase);

        }

        private void RemoveSelectionVariable(int removalIndex)
        {
            if (removalIndex < 0 || removalIndex >= DisplayTextList.Count)
            {
                throw new IndexOutOfRangeException();
            }

            var baseVariableToRemove = DisplayTextList[removalIndex];
            DisplayTextList.RemoveAt(removalIndex);

            for (int i = selections.Count - 1; i >= 0; i--)
            {
                if (selections[i].BaseWord(InputText) == baseVariableToRemove)
                    selections.Remove(selections[i]);

            }
        }

        /// <summary>
        /// Clear current list of variables.
        /// This should only occur on new instance or if the input text changes.
        /// </summary>
        private void ClearDisplayedVariables()
        {
            DisplayTextList?.Clear();
            selections?.Clear();

        }

        private SelectionVariable CreateCurrentSelectionVariable() =>
            new SelectionVariable(InputTextBox.SelectionStart, InputTextBox.SelectionLength);

        private void SetOutputText(int multiplier = 1)
        {
            var outString = string.Empty;
            var counter = 1;
            // Guard against nonsense multipliers
            if (multiplier < 1)
            {
                multiplier = 1;
            }

            while (counter <= multiplier)
            {
                var editedVariable = string.Empty;
                var outputText = InputText;
                var variableNumber = 0;
                int modifier = 0;

                foreach (var selection in selections)
                {
                    // Get the replacement variable
                    editedVariable =  GetVariableIteration(selection, counter);
                    // Set the replacement variable over the original variable
                    {
                        var startIndex = selection.StartingIndex; // to deal with variable length that can be generated

                        var firstHalf = outputText.Remove(startIndex + modifier, outputText.Length - startIndex - modifier);
                        var secondHalf = outputText.Remove(0, startIndex + selection.Length + modifier);
                        outputText = firstHalf + editedVariable + secondHalf;

                        // add modifiers here
                        modifier += editedVariable.Length - selection.ToString(InputText).Length;
                    }
                    //outputText = outputText.Replace(selection.ToString(InputText), editedVariable);
                }

                // Should update variables to use settings as defined in the application, using selectionList wizardry
                if (counter++ != multiplier)
                {
                    outString += outputText + "\r\n\r\n";
                }
                else
                {
                    outString += outputText;
                }
            }

            RichOutputTextBox.Text = outString;


        }

        // Takes a detected variable and replaces its number with the dictated number
        internal string GetVariableIteration(SelectionVariable variableToEdit, int iterationCount)
        {
            string wordToEdit = variableToEdit.ToString(InputText);
            string regexPattern = "([A-Za-z]+)(\\d+)";

            var match = Regex.Match(wordToEdit, regexPattern);

            var editedWord = match.Groups[1].ToString() + iterationCount;
            return editedWord;
        }

        /// <summary>
        /// Because winforms are stupid, this is how a datasource is refreashed.
        /// </summary>
        void RefreshItemDataSource(ListControl controlObject, IEnumerable<string> list)
        {
            controlObject.DataSource = null;
            controlObject.DataSource = list;
        }
        
        internal List<SelectionVariable> GenerateListOfInputVariables()
        {
            List<SelectionVariable> outListOfVariables = new List<SelectionVariable>();
            // Get Text in input box
            // Find all matches for 
            // regex string (" " || "(" || "." || "{" || "[")  + \w+\d
            // e.g starts with space, left bracket, full stop, left curly brace, or left square bracket
            // Contains any number of non numeric letters, and ends with a digits
            string regexPattern = "[\\s \\( \\. \\{ \\[ ]?([A-Za-z]+\\d+)";
            var collectionOfVariables = Regex.Matches(InputText, regexPattern);


            // foreach match, place in variables list if not already in list
            foreach (Match match in collectionOfVariables)
            {
                outListOfVariables.Add(new SelectionVariable(match.Groups[1].Index, match.Groups[1].Length));
            }

            return outListOfVariables;
        }

        /// <summary>
        /// Determines if the two passed in variables overlap with each other.
        /// </summary>
        /// <returns></returns>
        internal bool DoesCurrentVariableOverlapExisting(SelectionVariable currentSelectionVariable,
            SelectionVariable existingSelectionVariable)
        {
            if (currentSelectionVariable.StartingIndex < existingSelectionVariable.StartingIndex)
            {
                // currentVariable is before tested existing variable
                if (currentSelectionVariable.StartingIndex + currentSelectionVariable.Length - 1 <
                    existingSelectionVariable.StartingIndex)
                {
                    return false;
                }
                // currentVariable runs into the LHS of the existing variable
                return true;
            }

            // duplicates
            if (currentSelectionVariable.StartingIndex == existingSelectionVariable.StartingIndex)
            {
                return true;
            }
            
            if (currentSelectionVariable.StartingIndex >
                // currentVariable begins after the existing variable
                existingSelectionVariable.StartingIndex + existingSelectionVariable.Length - 1)
            {
                return false;
            }
            // currentVariable runs into the RHS of the existing variable
            return true;
        }

        #endregion

        #region Properties

        public List<string> DisplayTextList = new List<string>();
        public string InputText { get; set; }

        #endregion
    }
}


