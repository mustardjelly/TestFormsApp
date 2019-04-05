using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
[assembly: InternalsVisibleTo("UnitTests.DevTools")]

namespace TestFormsApp
{
    public partial class MainWindow : Form
    {
        private List<SelectionVariable> selections;

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

            if (removeIndex < 0 || removeIndex >= DisplayTextList.Count)
            {
                return;
            }

            try
            {
                DisplayTextList.RemoveAt(removeIndex);
                RefreshItemDataSource(DisplayListBox, DisplayTextList);

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
            var currentVariable = CreateCurrentSelectionVariable();
            // Guard against white space or duplicates
            // TODO: Should check for overlaps
            if (string.IsNullOrWhiteSpace(currentVariable.ToString(InputText)) ||
                selections.Contains(currentVariable))
            {
                return;
            }

            AddAndRefreshVariableToVariableList();

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
            DisplayTextList?.Clear();
            selections?.Clear();

            InputText = InputTextBox.Text;
            // Add code for auto detecting variables here
            var listOfDetectedVariables = GenerateListOfInputVariables();
            selections = selections.Concat(listOfDetectedVariables) as List<SelectionVariable>;

            // Add detected variables to the display list
            AddListOfSelectionVariablesToDisplayTextList(listOfDetectedVariables);
            // Refresh the DisplayListBox
            RefreshItemDataSource(controlObject: DisplayListBox, list: DisplayTextList);
            // Generate auto guess in Output Box here
        }

        #endregion

        #region Working methods

        private void AddAndRefreshVariableToVariableList()
        {
            selections.Add(CreateCurrentSelectionVariable());
            DisplayTextList.Add(selections.Last().ToString(InputText));

            RefreshItemDataSource(DisplayListBox, DisplayTextList);

            SetOutputText(InputText, 10);

        }

        private SelectionVariable CreateCurrentSelectionVariable() =>
            new SelectionVariable(InputTextBox.SelectionStart, InputTextBox.SelectionLength);

        private void SetOutputText(string outputText, int multiplier = 1)
        {
            var outString = string.Empty;
            var counter = 0;
            // Guard against stupid multipliers
            if (multiplier < 1)
            {
                multiplier = 1;
            }

            while (counter < multiplier)
            {
                // Should update variables here using selectionList wizardry
                outString += outputText + "\r\n\r\n";
                counter++;
            }

            RichOutputTextBox.Text = outString;


        }

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

        internal void AddListOfSelectionVariablesToDisplayTextList(List<SelectionVariable> inList)
        {
            foreach (var variable in inList)
            {
                DisplayTextList.Add(variable.ToString(InputText));
            }
        }

        #endregion

        #region Properties

        public List<string> DisplayTextList = new List<string>();
        public string InputText { get; set; }

        #endregion
    }
}


