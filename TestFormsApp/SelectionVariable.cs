using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestFormsApp {
    /// <summary>
    /// The SelectionVariable class for holding information selections made in a text box.
    /// </summary>
    public class SelectionVariable
    {
        private string baseWord;
        private int selectionIndex;
        private int selectionLength;

        /// <summary>
        /// The constructor for a Selection Variable. Tracks the starting index and length of a selection.
        /// </summary>
        public SelectionVariable(int index, int length) {
            this.selectionIndex = index;
            this.selectionLength = length;
        }

        public SelectionVariable(int index, int length, string inputText) : this(index, length){
            SetBaseWord(inputText);
        }

        /// <summary>
        /// Reports the starting index of the selection.
        /// </summary>
        public int Index { set { selectionIndex = value; } get { return selectionIndex; } }
        
        /// <summary>
        /// Reports the length of the selection.
        /// </summary>
        public int Length { set { selectionLength = value; } get { return selectionLength; } }

        public string TextString => ToString();

        /// <summary>
        /// Produces the string representation of this data object.
        /// </summary>
        /// <returns></returns>
        public string ToString(string originalText) {

            if (originalText == null || selectionLength > originalText.Length) {
                return string.Empty;
            }

            string outString = string.Empty;
            
            var endIndex = selectionIndex + selectionLength;
            var startIndex = selectionIndex;

            while (startIndex < endIndex) {
                outString += originalText[startIndex++];
            }
            return outString;
            
        }

        // Returns and sets the baseword for this selection variable.
        public string SetBaseWord(string originalText)
        {
            var variable = this.ToString(originalText);
            var regexPattern = "[A-Za-z]+";
            this.baseWord = Regex.Match(variable, regexPattern).ToString();

            return baseWord;
        }

        public string GetBaseWord()
        {
            return baseWord;
        }
    }
}
