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
            this.label1 = new System.Windows.Forms.Label();
            this.TargetIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.iterationSpacerCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearVariableButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StartingIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.selectionVariableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TargetIterationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingIterationNumericUpDown)).BeginInit();
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
            this.RichOutputTextBox.TabStop = false;
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
            this.DisplayListBox.Size = new System.Drawing.Size(176, 420);
            this.DisplayListBox.TabIndex = 15;
            this.DisplayListBox.TabStop = false;
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
            this.InputTextBox.AcceptsTab = true;
            this.InputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(15, 33);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(594, 136);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "";
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.InputTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InputTextBox_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Target Iteration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TargetIterationNumericUpDown
            // 
            this.TargetIterationNumericUpDown.Location = new System.Drawing.Point(721, 63);
            this.TargetIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TargetIterationNumericUpDown.Name = "TargetIterationNumericUpDown";
            this.TargetIterationNumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.TargetIterationNumericUpDown.TabIndex = 1;
            this.TargetIterationNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TargetIterationNumericUpDown.ValueChanged += new System.EventHandler(this.IterationMultiplierChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Space Outputs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iterationSpacerCheckBox
            // 
            this.iterationSpacerCheckBox.AutoSize = true;
            this.iterationSpacerCheckBox.Location = new System.Drawing.Point(721, 94);
            this.iterationSpacerCheckBox.Name = "iterationSpacerCheckBox";
            this.iterationSpacerCheckBox.Size = new System.Drawing.Size(15, 14);
            this.iterationSpacerCheckBox.TabIndex = 20;
            this.iterationSpacerCheckBox.UseVisualStyleBackColor = true;
            this.iterationSpacerCheckBox.CheckStateChanged += new System.EventHandler(this.OnSpacingCheckboxChanged);
            // 
            // ClearVariableButton
            // 
            this.ClearVariableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearVariableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearVariableButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClearVariableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearVariableButton.Location = new System.Drawing.Point(614, 643);
            this.ClearVariableButton.Name = "ClearVariableButton";
            this.ClearVariableButton.Size = new System.Drawing.Size(176, 23);
            this.ClearVariableButton.TabIndex = 21;
            this.ClearVariableButton.Text = "Clear Variables";
            this.ClearVariableButton.UseVisualStyleBackColor = false;
            this.ClearVariableButton.Click += new System.EventHandler(this.OnRemoveAllVariableButtonClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Starting Iteration";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartingIterationNumericUpDown
            // 
            this.StartingIterationNumericUpDown.Location = new System.Drawing.Point(721, 33);
            this.StartingIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingIterationNumericUpDown.Name = "StartingIterationNumericUpDown";
            this.StartingIterationNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.StartingIterationNumericUpDown.TabIndex = 23;
            this.StartingIterationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingIterationNumericUpDown.ValueChanged += new System.EventHandler(this.IterationMultiplierChanged);
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
            this.Controls.Add(this.StartingIterationNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearVariableButton);
            this.Controls.Add(this.iterationSpacerCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TargetIterationNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.RichOutputTextBox);
            this.Controls.Add(this.DisplayListLabel);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Name = "MainWindow";
            this.Text = "Variable Iterator";
            ((System.ComponentModel.ISupportInitialize)(this.TargetIterationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingIterationNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TargetIterationNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox iterationSpacerCheckBox;
        private System.Windows.Forms.Button ClearVariableButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StartingIterationNumericUpDown;
    }
}

