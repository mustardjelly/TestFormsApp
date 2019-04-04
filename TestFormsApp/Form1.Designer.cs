namespace TestFormsApp {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.RichOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.DisplayListLabel = new System.Windows.Forms.Label();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.selectionVariableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.selectionVariableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RichOutputTextBox
            // 
            this.RichOutputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RichOutputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichOutputTextBox.HideSelection = false;
            this.RichOutputTextBox.Location = new System.Drawing.Point(15, 221);
            this.RichOutputTextBox.Name = "RichOutputTextBox";
            this.RichOutputTextBox.ReadOnly = true;
            this.RichOutputTextBox.Size = new System.Drawing.Size(594, 446);
            this.RichOutputTextBox.TabIndex = 12;
            this.RichOutputTextBox.Text = "Output";
            // 
            // DisplayListLabel
            // 
            this.DisplayListLabel.AutoSize = true;
            this.DisplayListLabel.Location = new System.Drawing.Point(613, 204);
            this.DisplayListLabel.Name = "DisplayListLabel";
            this.DisplayListLabel.Size = new System.Drawing.Size(69, 13);
            this.DisplayListLabel.TabIndex = 16;
            this.DisplayListLabel.Text = "Variables List";
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(614, 221);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(176, 446);
            this.DisplayListBox.TabIndex = 15;
            this.DisplayListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisplayListBox_DoubleClick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(570, 172);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Status";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 204);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 13;
            this.OutputLabel.Text = "Output";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 17);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(31, 13);
            this.InputLabel.TabIndex = 11;
            this.InputLabel.Text = "Input";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(15, 33);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(594, 136);
            this.InputTextBox.TabIndex = 17;
            this.InputTextBox.Text = "";
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.InputTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InputTextBox_MouseUp);
            // 
            // selectionVariableBindingSource
            // 
            this.selectionVariableBindingSource.DataSource = typeof(TestFormsApp.SelectionVariable);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 684);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.RichOutputTextBox);
            this.Controls.Add(this.DisplayListLabel);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.selectionVariableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource selectionVariableBindingSource;
        private System.Windows.Forms.RichTextBox RichOutputTextBox;
        private System.Windows.Forms.Label DisplayListLabel;
        public System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.RichTextBox InputTextBox;
    }
}

