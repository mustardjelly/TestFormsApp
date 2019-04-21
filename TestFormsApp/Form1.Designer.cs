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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.DisplayListLabel = new System.Windows.Forms.Label();
            this.RichOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.TargetIterationLabel = new System.Windows.Forms.Label();
            this.TargetIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpaceOutputsLabel = new System.Windows.Forms.Label();
            this.IterationSpacerCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearVariableButton = new System.Windows.Forms.Button();
            this.StartingIterationLabel = new System.Windows.Forms.Label();
            this.StartingIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SelectAndCopyOutputButton = new System.Windows.Forms.Button();
            this.ClearInputButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.selectionVariableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TargetIterationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingIterationNumericUpDown)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionVariableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(3, 188);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(52, 18);
            this.OutputLabel.TabIndex = 13;
            this.OutputLabel.Text = "Output";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(3, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(39, 18);
            this.InputLabel.TabIndex = 11;
            this.InputLabel.Text = "Input";
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(618, 208);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(175, 459);
            this.DisplayListBox.TabIndex = 15;
            this.DisplayListBox.TabStop = false;
            this.DisplayListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisplayListBox_DoubleClick);
            // 
            // DisplayListLabel
            // 
            this.DisplayListLabel.AutoSize = true;
            this.DisplayListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayListLabel.Location = new System.Drawing.Point(615, 187);
            this.DisplayListLabel.Name = "DisplayListLabel";
            this.DisplayListLabel.Size = new System.Drawing.Size(95, 18);
            this.DisplayListLabel.TabIndex = 16;
            this.DisplayListLabel.Text = "Variables List";
            // 
            // RichOutputTextBox
            // 
            this.RichOutputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RichOutputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichOutputTextBox.HideSelection = false;
            this.RichOutputTextBox.Location = new System.Drawing.Point(6, 209);
            this.RichOutputTextBox.Name = "RichOutputTextBox";
            this.RichOutputTextBox.ReadOnly = true;
            this.RichOutputTextBox.Size = new System.Drawing.Size(603, 459);
            this.RichOutputTextBox.TabIndex = 12;
            this.RichOutputTextBox.TabStop = false;
            this.RichOutputTextBox.Text = "Output";
            // 
            // InputTextBox
            // 
            this.InputTextBox.AcceptsTab = true;
            this.InputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(6, 30);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(603, 155);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "";
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.InputTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InputTextBox_MouseUp);
            // 
            // TargetIterationLabel
            // 
            this.TargetIterationLabel.AutoSize = true;
            this.TargetIterationLabel.Location = new System.Drawing.Point(12, 59);
            this.TargetIterationLabel.Name = "TargetIterationLabel";
            this.TargetIterationLabel.Size = new System.Drawing.Size(79, 13);
            this.TargetIterationLabel.TabIndex = 18;
            this.TargetIterationLabel.Text = "Target Iteration";
            this.TargetIterationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TargetIterationNumericUpDown
            // 
            this.TargetIterationNumericUpDown.Location = new System.Drawing.Point(103, 57);
            this.TargetIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TargetIterationNumericUpDown.Name = "TargetIterationNumericUpDown";
            this.TargetIterationNumericUpDown.Size = new System.Drawing.Size(66, 20);
            this.TargetIterationNumericUpDown.TabIndex = 1;
            this.TargetIterationNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TargetIterationNumericUpDown.ValueChanged += new System.EventHandler(this.IterationMultiplierChanged);
            // 
            // SpaceOutputsLabel
            // 
            this.SpaceOutputsLabel.AutoSize = true;
            this.SpaceOutputsLabel.Location = new System.Drawing.Point(12, 88);
            this.SpaceOutputsLabel.Name = "SpaceOutputsLabel";
            this.SpaceOutputsLabel.Size = new System.Drawing.Size(78, 13);
            this.SpaceOutputsLabel.TabIndex = 19;
            this.SpaceOutputsLabel.Text = "Space Outputs";
            this.SpaceOutputsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IterationSpacerCheckBox
            // 
            this.IterationSpacerCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IterationSpacerCheckBox.AutoSize = true;
            this.IterationSpacerCheckBox.Location = new System.Drawing.Point(103, 88);
            this.IterationSpacerCheckBox.Name = "IterationSpacerCheckBox";
            this.IterationSpacerCheckBox.Size = new System.Drawing.Size(15, 14);
            this.IterationSpacerCheckBox.TabIndex = 2;
            this.IterationSpacerCheckBox.UseVisualStyleBackColor = true;
            this.IterationSpacerCheckBox.CheckStateChanged += new System.EventHandler(this.OnSpacingCheckboxChanged);
            // 
            // ClearVariableButton
            // 
            this.ClearVariableButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClearVariableButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClearVariableButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearVariableButton.Location = new System.Drawing.Point(625, 639);
            this.ClearVariableButton.Name = "ClearVariableButton";
            this.ClearVariableButton.Size = new System.Drawing.Size(162, 23);
            this.ClearVariableButton.TabIndex = 6;
            this.ClearVariableButton.Text = "Clear Variables";
            this.ClearVariableButton.UseVisualStyleBackColor = false;
            this.ClearVariableButton.Click += new System.EventHandler(this.OnRemoveAllVariableButtonClicked);
            // 
            // StartingIterationLabel
            // 
            this.StartingIterationLabel.AutoSize = true;
            this.StartingIterationLabel.Location = new System.Drawing.Point(7, 29);
            this.StartingIterationLabel.Name = "StartingIterationLabel";
            this.StartingIterationLabel.Size = new System.Drawing.Size(84, 13);
            this.StartingIterationLabel.TabIndex = 22;
            this.StartingIterationLabel.Text = "Starting Iteration";
            this.StartingIterationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartingIterationNumericUpDown
            // 
            this.StartingIterationNumericUpDown.Location = new System.Drawing.Point(103, 27);
            this.StartingIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingIterationNumericUpDown.Name = "StartingIterationNumericUpDown";
            this.StartingIterationNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.StartingIterationNumericUpDown.TabIndex = 0;
            this.StartingIterationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingIterationNumericUpDown.ValueChanged += new System.EventHandler(this.IterationMultiplierChanged);
            // 
            // SelectAndCopyOutputButton
            // 
            this.SelectAndCopyOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectAndCopyOutputButton.Location = new System.Drawing.Point(427, 639);
            this.SelectAndCopyOutputButton.Name = "SelectAndCopyOutputButton";
            this.SelectAndCopyOutputButton.Size = new System.Drawing.Size(175, 23);
            this.SelectAndCopyOutputButton.TabIndex = 2;
            this.SelectAndCopyOutputButton.Text = "Select All and Copy";
            this.SelectAndCopyOutputButton.UseVisualStyleBackColor = true;
            this.SelectAndCopyOutputButton.Click += new System.EventHandler(this.OnSelectCopyClicked);
            // 
            // ClearInputButton
            // 
            this.ClearInputButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearInputButton.Location = new System.Drawing.Point(509, 155);
            this.ClearInputButton.Name = "ClearInputButton";
            this.ClearInputButton.Size = new System.Drawing.Size(93, 23);
            this.ClearInputButton.TabIndex = 1;
            this.ClearInputButton.Text = "Clear Input";
            this.ClearInputButton.UseVisualStyleBackColor = true;
            this.ClearInputButton.Click += new System.EventHandler(this.OnClearInputClicked);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.SettingsGroupBox);
            this.MainPanel.Controls.Add(this.ClearInputButton);
            this.MainPanel.Controls.Add(this.SelectAndCopyOutputButton);
            this.MainPanel.Controls.Add(this.ClearVariableButton);
            this.MainPanel.Controls.Add(this.InputTextBox);
            this.MainPanel.Controls.Add(this.RichOutputTextBox);
            this.MainPanel.Controls.Add(this.DisplayListLabel);
            this.MainPanel.Controls.Add(this.DisplayListBox);
            this.MainPanel.Controls.Add(this.InputLabel);
            this.MainPanel.Controls.Add(this.OutputLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(802, 673);
            this.MainPanel.TabIndex = 27;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.StartingIterationNumericUpDown);
            this.SettingsGroupBox.Controls.Add(this.StartingIterationLabel);
            this.SettingsGroupBox.Controls.Add(this.IterationSpacerCheckBox);
            this.SettingsGroupBox.Controls.Add(this.SpaceOutputsLabel);
            this.SettingsGroupBox.Controls.Add(this.TargetIterationNumericUpDown);
            this.SettingsGroupBox.Controls.Add(this.TargetIterationLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(618, 24);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(175, 161);
            this.SettingsGroupBox.TabIndex = 3;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // selectionVariableBindingSource
            // 
            this.selectionVariableBindingSource.DataSource = typeof(TestFormsApp.SelectionVariable);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(802, 673);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainWindow";
            this.Text = "Variable Iterator";
            ((System.ComponentModel.ISupportInitialize)(this.TargetIterationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingIterationNumericUpDown)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionVariableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource selectionVariableBindingSource;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label InputLabel;
        public System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Label DisplayListLabel;
        private System.Windows.Forms.RichTextBox RichOutputTextBox;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.Label TargetIterationLabel;
        private System.Windows.Forms.NumericUpDown TargetIterationNumericUpDown;
        private System.Windows.Forms.Label SpaceOutputsLabel;
        private System.Windows.Forms.CheckBox IterationSpacerCheckBox;
        private System.Windows.Forms.Button ClearVariableButton;
        private System.Windows.Forms.Label StartingIterationLabel;
        private System.Windows.Forms.NumericUpDown StartingIterationNumericUpDown;
        private System.Windows.Forms.Button SelectAndCopyOutputButton;
        private System.Windows.Forms.Button ClearInputButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
    }
}

