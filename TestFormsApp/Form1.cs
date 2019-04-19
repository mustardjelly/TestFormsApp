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
        private string defaultOutputText => InputTextBox.Text.Length == 0 ? noInputDefault : noVariableDefault;

        private const string noVariableDefault = "Please select a variable to continue.";
        private const string noInputDefault = "Please type something in the input box to continue.";
        private const string StartingIterationName = "StartingIterationNumericUpDown";
        private const string TargetIterationName = "TargetIterationNumericUpDown";

        public MainWindow()
        {
            InitializeComponent();
            selections = new List<SelectionVariable>();
            SetOutputText();
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
                SetOutputText();

            }
            catch
            {
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
                AddAndRefreshVariableToVariableList(sv, false);
            }

            RefreshItemDataSource(DisplayListBox, DisplayTextList);
            SetOutputText();
        }

        /// <summary>
        /// Sets the number of iterations to create. Defaults to 10.
        /// </summary>
        private void IterationMultiplierChanged(object sender, EventArgs e)
        {
            // multiplier = (int)(sender as NumericUpDown).Value;
            if (!(StartingIterationNumericUpDown.Value <= TargetIterationNumericUpDown.Value)) {
                switch((sender as NumericUpDown).Name) {
                    case StartingIterationName:
                        StartingIterationNumericUpDown.Value = TargetIterationNumericUpDown.Value;
                        break;
                    case TargetIterationName:
                        TargetIterationNumericUpDown.Value = StartingIterationNumericUpDown.Value;
                        break;
                }

            }
            SetOutputText();
        }

        private void OnSpacingCheckboxChanged(object sender, EventArgs e) {
            SetOutputText();
        }

        private void OnRemoveAllVariableButtonClicked(object sender, EventArgs e) {
            ClearDisplayedVariables();
            RefreshItemDataSource(DisplayListBox, DisplayTextList);
            SetOutputText();

        }

        #endregion

        #region Working methods

        /// <summary>
        /// Adds a selection variable to the list and refreashes all display lists/boxes
        /// </summary>
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
                    SetOutputText();
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
                SetOutputText();
            }

            #endregion

        }
        
        private void AddSelectionVariable(SelectionVariable currentVariable)
        {
            selections.Add(currentVariable);
            var variableBase = currentVariable.GetBaseWord();
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

            var baseWordToRemove = DisplayTextList[removalIndex];
            DisplayTextList.RemoveAt(removalIndex);

            for (int i = selections.Count - 1; i >= 0; i--)
            {
                if (selections[i].GetBaseWord() == baseWordToRemove)
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
            StripExcess(new SelectionVariable(InputTextBox.SelectionStart, InputTextBox.SelectionLength, InputText)) ;

        /// <summary>
        ///
        /// </summary>
        private void SetOutputText()
        {
            // Provide textual guidance
            if (InputTextBox.Text.Length == 0 || selections.Count == 0) {
                RichOutputTextBox.Text = defaultOutputText;
                return;
            }

            var outString = string.Empty;
            var counter = StartingMultiplier;
            var target = TargetMultiplier;

            // iteration loop
            while (counter <= target) {
                var editedVariable = string.Empty;
                var outputText = InputText;
                var variableNumber = 0;
                int modifier = 0;
                // variable loop
                foreach (var selection in SortedSelectionsList) {
                    // Get the replacement variable
                    editedVariable =  GetIteratedVariable(selection, counter);
                    // Set the replacement variable over the original variable for this iteration
                    {
                        var startIndex = selection.Index; // to deal with variable length that can be generated

                        var firstHalf = outputText.Remove(startIndex + modifier, outputText.Length - startIndex - modifier);
                        var secondHalf = outputText.Remove(0, startIndex + selection.Length + modifier);

                        outputText = firstHalf + editedVariable + secondHalf;
                    }

                    // add modifiers here
                    modifier += editedVariable.Length - selection.ToString(InputText).Length;
                }

                // Should update variables to use settings as defined in the application, using selectionList wizardry
                if (counter++ != target) {
                    outString += outputText + IterationSpacer;
                } else {
                    outString += outputText;
                }
            }

            RichOutputTextBox.Text = outString;


        }
        
        /// <summary>
        /// Takes a variable and sets its iteration to a set number.
        /// </summary>
        internal string GetIteratedVariable(SelectionVariable variableToEdit, int iterationCount)
        {
            string wordToEdit = variableToEdit.ToString(InputText);
            string regexPattern = "([A-Za-z]+)(\\d+)?";

            var match = Regex.Match(wordToEdit, regexPattern);

            var editedWord = match.Groups[1].ToString() + iterationCount;
            return editedWord;
        }

        /// <summary>
        /// Because winforms are stupid, this is how my datasource is refreashed.
        /// </summary>
        void RefreshItemDataSource(ListControl controlObject, List<string> list) {
            list.Sort();
            controlObject.DataSource = null;
            controlObject.DataSource = list;
        }
        
        /// <summary>
        /// Scans the target text and makes a best guess at variables, then iterates them in the output.
        /// </summary>
        /// <returns></returns>
        internal List<SelectionVariable> GenerateListOfInputVariables()
        {
            List<SelectionVariable> outListOfVariables = new List<SelectionVariable>();
            string regexPattern = "[\\s \\( \\. \\{ \\[ ]?([A-Za-z]+\\d+)";
            var collectionOfVariables = Regex.Matches(InputText, regexPattern);

            // foreach match, place in variables list
            foreach (Match match in collectionOfVariables)
            {
                outListOfVariables.Add(new SelectionVariable(match.Groups[1].Index, match.Groups[1].Length, InputText));
            }

            return outListOfVariables;
        }

        /// <summary>
        /// Determines if the two selection variables overlap with each other.
        /// e.g     "( [ ) ]" OR
        ///         "( [ ] )"
        /// </summary>
        internal bool DoesCurrentVariableOverlapExisting(SelectionVariable currentSelectionVariable,
            SelectionVariable existingSelectionVariable)
        {
            if (currentSelectionVariable.Index < existingSelectionVariable.Index)
            {
                // currentVariable is before tested existing variable
                if (currentSelectionVariable.Index + currentSelectionVariable.Length - 1 <
                    existingSelectionVariable.Index)
                {
                    return false;
                }
                // currentVariable runs into the LHS of the existing variable
                return true;
            }

            // duplicates
            if (currentSelectionVariable.Index == existingSelectionVariable.Index)
            {
                return true;
            }
            
            if (currentSelectionVariable.Index >
                // currentVariable begins after the existing variable
                existingSelectionVariable.Index + existingSelectionVariable.Length - 1)
            {
                return false;
            }
            // currentVariable runs into the RHS of the existing variable
            return true;
        }

        /// <summary>
        /// Trims down a passed in current variable to an acceptable variable. 
        /// </summary>
        internal SelectionVariable StripExcess(SelectionVariable currentVariable) {
            var regexPattern = "([A-Za-z]+(\\d+)?)";
            var currentVariableText = currentVariable.ToString(InputText);
            Match regexMatch = Regex.Match(currentVariableText, regexPattern);

            currentVariable.Length = regexMatch.Value.Length;
            return currentVariable;

        }

        #endregion

        #region Properties

        public List<string> DisplayTextList = new List<string>();
        public string InputText { get; set; }
        public string IterationSpacer => iterationSpacerCheckBox.Checked ? "\r\n\r\n" : "\r\n";
        internal List<SelectionVariable> SortedSelectionsList => selections.OrderBy(s => s.Index).ToList();
        
        internal int TargetMultiplier => (int) TargetIterationNumericUpDown.Value;
        internal int StartingMultiplier => (int) StartingIterationNumericUpDown.Value;

        #endregion
    }
}


