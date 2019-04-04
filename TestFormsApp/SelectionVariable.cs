using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormsApp {
    /// <summary>
    /// The SelectionVariable class for holding information selections made in a text box.
    /// </summary>
    public class SelectionVariable {

        private int selectionIndex;
        private int selectionLength;

        /// <summary>
        /// The constructor for a Selection Variable. Tracks the starting index and length of a selection.
        /// </summary>
        public SelectionVariable(int index, int length) {
            this.selectionIndex = index;
            this.selectionLength = length;
        }

        /// <summary>
        /// Reports the starting index of the selection.
        /// </summary>
        public int StartingIndex => selectionIndex;
        
        /// <summary>
        /// Reports the length of the selection.
        /// </summary>
        public int Length => selectionLength;

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
    }
}
