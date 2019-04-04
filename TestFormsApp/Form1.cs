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

namespace TestFormsApp {
    public partial class MainWindow : Form {
        private string inputText;
        private List<SelectionVariable> selections = new List<SelectionVariable>();
        private SelectionVariable lastSelectionVariable;

        public MainWindow() {
            InitializeComponent();
        }

        #region Event methods

        /// <summary>
        /// Event for double clicking on the display list box.
        /// </summary>
        private void DisplayListBox_DoubleClick(object sender, MouseEventArgs e) {
            var removeIndex = DisplayListBox.SelectedIndex;
            
            if (removeIndex < 0 || removeIndex >= DisplayTextList.Count) {
                return;
            }

            try {
                DisplayTextList.RemoveAt(removeIndex);                        
                RefreshItemDataSource(DisplayListBox, DisplayTextList);

            }
            catch {
                throw new IndexOutOfRangeException();
            }

        }

        private void InputTextBox_MouseUp(object sender, MouseEventArgs e) {
            var currentVariable = CreateCurrentSelectionVariable();

            if (string.IsNullOrWhiteSpace(currentVariable.ToString(inputText))) {
                return;
            }

            if ((lastSelectionVariable == null) || !(currentVariable.ToString(inputText) == lastSelectionVariable.ToString(inputText))){
                AddAndRefreshVariableToVariableList();
            }

        }
        
        private void InputTextBox_TextChanged(object sender, EventArgs e) {
            if (inputText == InputTextBox.Text) {
                return;
            }
            
            inputText = InputTextBox.Text;
            // Reset the DisplayTextList here
            // Add code for auto detecting variables here
            GenerateListOfInputVariables();
            DisplayTextList.Clear();
            return;
            
            RefreshItemDataSource(DisplayListBox, DisplayTextList);
            // Generate auto guess in Output Box here
        }

        #endregion

        #region Working methods

        private void AddAndRefreshVariableToVariableList() {
            selections.Add(CreateCurrentSelectionVariable());
            lastSelectionVariable = selections.Last();
            DisplayTextList.Add(selections.Last().ToString(inputText));

            RefreshItemDataSource(DisplayListBox, DisplayTextList);

            SetOutputText(inputText, 10);

        }

        private SelectionVariable CreateCurrentSelectionVariable() => 
            new SelectionVariable(InputTextBox.SelectionStart, InputTextBox.SelectionLength);


        internal static void FindVariables(string inputString, int iteration) {
            List<int> outDictionary = new List<int>();
            if (inputString.Length <= 0) {
                return;
            }

            var items = Regex.Matches(inputString, "\\D+");

            var clonedInputString = inputString;
            List<SelectionVariable> listOfMatches = new List<SelectionVariable>();

            var outString = string.Empty;

            foreach (Match match in items) {
                outString += match.Value + $"{iteration}";
            }
            

        }

        private void SetOutputText(string outputText, int multiplier = 1) {
            var outString = string.Empty;

            while (multiplier > 0) {
                outString += outputText + "\r\n\r\n";
                multiplier--;
            }

            RichOutputTextBox.Text = outString;


        }

        void RefreshItemDataSource(ListControl controlObject, IEnumerable<string> list) {
            controlObject.DataSource = null;
            controlObject.DataSource = list;
        }

        internal string GenerateListOfInputVariables() {
            // Get Text in input box
            // Find all matches for 
            // regex string (" " || "(" || "." || "{" || "[")  + \w+\d
            // e.g starts with space, left bracket, full stop, left curly brace, or left square bracket
            // Contains any number of non numeric letters, and ends with a digits
            string regexPattern = "[\\s \\( \\. \\{ \\[ ]([A-Za-z]+\\d+)";
            var collectionOfVariables = Regex.Matches(inputText, regexPattern);
            

            // foreach match, place in variables list if not already in list
            foreach (Match match in collectionOfVariables) {
                DisplayTextList.Add(new SelectionVariable(match.Index + 1, match.Length - 1).ToString(inputText));
            }

            RefreshItemDataSource(DisplayListBox, DisplayTextList);

            return string.Empty;
        }

        #endregion

        #region Properties

        public List<string> DisplayTextList = new List<string>();

        #endregion

        private void InputTextBox_TextChanged(object sender, KeyEventArgs e) {

        }
    }
}


