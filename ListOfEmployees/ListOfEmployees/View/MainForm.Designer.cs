namespace ListOfEmployees
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmployeesListBox = new ListBox();
            SelectedEmployeGroupBox = new GroupBox();
            PositionEmployeLabel = new Label();
            PositionEmployeTextBox = new TextBox();
            DeleteEmployeButton = new Button();
            SalaryEmployeLabel = new Label();
            AddEmployeButton = new Button();
            SalaryEmployeTextBox = new TextBox();
            DateOfEmploymentDateTimePicker = new DateTimePicker();
            DateOfEmployeLabel = new Label();
            FullNameEmployeLabel = new Label();
            FullNameEmployeTextBox = new TextBox();
            SaveNewInfoEmployeButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            SelectedEmployeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // EmployeesListBox
            // 
            EmployeesListBox.FormattingEnabled = true;
            EmployeesListBox.ItemHeight = 15;
            EmployeesListBox.Location = new Point(12, 12);
            EmployeesListBox.Name = "EmployeesListBox";
            EmployeesListBox.Size = new Size(268, 424);
            EmployeesListBox.TabIndex = 0;
            EmployeesListBox.MouseDown += EmployeesListBox_MouseDown;
            // 
            // SelectedEmployeGroupBox
            // 
            SelectedEmployeGroupBox.Controls.Add(PositionEmployeLabel);
            SelectedEmployeGroupBox.Controls.Add(PositionEmployeTextBox);
            SelectedEmployeGroupBox.Controls.Add(DeleteEmployeButton);
            SelectedEmployeGroupBox.Controls.Add(SalaryEmployeLabel);
            SelectedEmployeGroupBox.Controls.Add(AddEmployeButton);
            SelectedEmployeGroupBox.Controls.Add(SalaryEmployeTextBox);
            SelectedEmployeGroupBox.Controls.Add(DateOfEmploymentDateTimePicker);
            SelectedEmployeGroupBox.Controls.Add(DateOfEmployeLabel);
            SelectedEmployeGroupBox.Controls.Add(FullNameEmployeLabel);
            SelectedEmployeGroupBox.Controls.Add(FullNameEmployeTextBox);
            SelectedEmployeGroupBox.Controls.Add(SaveNewInfoEmployeButton);
            SelectedEmployeGroupBox.Location = new Point(286, 12);
            SelectedEmployeGroupBox.Name = "SelectedEmployeGroupBox";
            SelectedEmployeGroupBox.Size = new Size(502, 239);
            SelectedEmployeGroupBox.TabIndex = 1;
            SelectedEmployeGroupBox.TabStop = false;
            SelectedEmployeGroupBox.Text = "Selected Employe";
            // 
            // PositionEmployeLabel
            // 
            PositionEmployeLabel.AutoSize = true;
            PositionEmployeLabel.Location = new Point(75, 74);
            PositionEmployeLabel.Name = "PositionEmployeLabel";
            PositionEmployeLabel.Size = new Size(53, 15);
            PositionEmployeLabel.TabIndex = 9;
            PositionEmployeLabel.Text = "Position:";
            // 
            // PositionEmployeTextBox
            // 
            PositionEmployeTextBox.Location = new Point(134, 71);
            PositionEmployeTextBox.Name = "PositionEmployeTextBox";
            PositionEmployeTextBox.Size = new Size(218, 23);
            PositionEmployeTextBox.TabIndex = 8;
            PositionEmployeTextBox.TextChanged += PositionEmployeTextBox_TextChanged;
            // 
            // DeleteEmployeButton
            // 
            DeleteEmployeButton.Location = new Point(168, 210);
            DeleteEmployeButton.Name = "DeleteEmployeButton";
            DeleteEmployeButton.Size = new Size(75, 23);
            DeleteEmployeButton.TabIndex = 2;
            DeleteEmployeButton.Text = "Delete";
            DeleteEmployeButton.UseVisualStyleBackColor = true;
            DeleteEmployeButton.MouseClick += DeleteEmployeButton_MouseClick;
            // 
            // SalaryEmployeLabel
            // 
            SalaryEmployeLabel.AutoSize = true;
            SalaryEmployeLabel.Location = new Point(87, 132);
            SalaryEmployeLabel.Name = "SalaryEmployeLabel";
            SalaryEmployeLabel.Size = new Size(41, 15);
            SalaryEmployeLabel.TabIndex = 7;
            SalaryEmployeLabel.Text = "Salary:";
            // 
            // AddEmployeButton
            // 
            AddEmployeButton.Location = new Point(6, 210);
            AddEmployeButton.Name = "AddEmployeButton";
            AddEmployeButton.Size = new Size(75, 23);
            AddEmployeButton.TabIndex = 0;
            AddEmployeButton.Text = "Add";
            AddEmployeButton.UseVisualStyleBackColor = true;
            AddEmployeButton.MouseClick += AddEmployeButton_MouseClick;
            // 
            // SalaryEmployeTextBox
            // 
            SalaryEmployeTextBox.Location = new Point(134, 129);
            SalaryEmployeTextBox.Name = "SalaryEmployeTextBox";
            SalaryEmployeTextBox.Size = new Size(112, 23);
            SalaryEmployeTextBox.TabIndex = 6;
            SalaryEmployeTextBox.TextChanged += SalaryEmployeTextBox_TextChanged;
            // 
            // DateOfEmploymentDateTimePicker
            // 
            DateOfEmploymentDateTimePicker.Location = new Point(134, 100);
            DateOfEmploymentDateTimePicker.Name = "DateOfEmploymentDateTimePicker";
            DateOfEmploymentDateTimePicker.Size = new Size(150, 23);
            DateOfEmploymentDateTimePicker.TabIndex = 5;
            DateOfEmploymentDateTimePicker.ValueChanged += DateOfEmploymentDateTimePicker_ValueChanged;
            // 
            // DateOfEmployeLabel
            // 
            DateOfEmployeLabel.AutoSize = true;
            DateOfEmployeLabel.Location = new Point(7, 106);
            DateOfEmployeLabel.Name = "DateOfEmployeLabel";
            DateOfEmployeLabel.Size = new Size(121, 15);
            DateOfEmployeLabel.TabIndex = 4;
            DateOfEmployeLabel.Text = "Date Of Employment:";
            // 
            // FullNameEmployeLabel
            // 
            FullNameEmployeLabel.AutoSize = true;
            FullNameEmployeLabel.Location = new Point(64, 44);
            FullNameEmployeLabel.Name = "FullNameEmployeLabel";
            FullNameEmployeLabel.Size = new Size(64, 15);
            FullNameEmployeLabel.TabIndex = 3;
            FullNameEmployeLabel.Text = "Full Name:";
            // 
            // FullNameEmployeTextBox
            // 
            FullNameEmployeTextBox.Location = new Point(134, 41);
            FullNameEmployeTextBox.Name = "FullNameEmployeTextBox";
            FullNameEmployeTextBox.Size = new Size(362, 23);
            FullNameEmployeTextBox.TabIndex = 2;
            FullNameEmployeTextBox.TextChanged += FullNameEmployeTextBox_TextChanged;
            // 
            // SaveNewInfoEmployeButton
            // 
            SaveNewInfoEmployeButton.Location = new Point(87, 210);
            SaveNewInfoEmployeButton.Name = "SaveNewInfoEmployeButton";
            SaveNewInfoEmployeButton.Size = new Size(75, 23);
            SaveNewInfoEmployeButton.TabIndex = 1;
            SaveNewInfoEmployeButton.Text = "Save";
            SaveNewInfoEmployeButton.UseVisualStyleBackColor = true;
            SaveNewInfoEmployeButton.MouseClick += SaveNewInfoEmployeButton_MouseClick;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectedEmployeGroupBox);
            Controls.Add(EmployeesListBox);
            Name = "MainForm";
            Text = "EmployeApp";
            SelectedEmployeGroupBox.ResumeLayout(false);
            SelectedEmployeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox EmployeesListBox;
        private GroupBox SelectedEmployeGroupBox;
        private Label FullNameEmployeLabel;
        private TextBox FullNameEmployeTextBox;
        private Button SaveNewInfoEmployeButton;
        private Button AddEmployeButton;
        private Button DeleteEmployeButton;
        private Label SalaryEmployeLabel;
        private TextBox SalaryEmployeTextBox;
        private DateTimePicker DateOfEmploymentDateTimePicker;
        private Label DateOfEmployeLabel;
        private FileSystemWatcher fileSystemWatcher1;
        private Label PositionEmployeLabel;
        private TextBox PositionEmployeTextBox;
    }
}
