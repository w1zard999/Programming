namespace Programming.View.Panels
{
    partial class EnumsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ValueListLabel = new Label();
            EnumListLabel = new Label();
            IntValueBox = new Label();
            SeasonGroup = new GroupBox();
            SeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            groupBox1 = new GroupBox();
            DayOfTheWeekInfo = new Label();
            ParseButton = new Button();
            TypeLabel = new Label();
            TextParseBox = new TextBox();
            ValueTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            SeasonGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ValueListLabel
            // 
            ValueListLabel.AutoSize = true;
            ValueListLabel.Location = new Point(192, 10);
            ValueListLabel.Name = "ValueListLabel";
            ValueListLabel.Size = new Size(81, 15);
            ValueListLabel.TabIndex = 15;
            ValueListLabel.Text = "Choose Value:";
            // 
            // EnumListLabel
            // 
            EnumListLabel.AutoSize = true;
            EnumListLabel.Location = new Point(8, 10);
            EnumListLabel.Name = "EnumListLabel";
            EnumListLabel.Size = new Size(121, 15);
            EnumListLabel.TabIndex = 14;
            EnumListLabel.Text = "Choose enumeration:";
            // 
            // IntValueBox
            // 
            IntValueBox.AutoSize = true;
            IntValueBox.Location = new Point(437, 137);
            IntValueBox.Name = "IntValueBox";
            IntValueBox.Size = new Size(55, 15);
            IntValueBox.TabIndex = 13;
            IntValueBox.Text = "Int value:";
            // 
            // SeasonGroup
            // 
            SeasonGroup.Controls.Add(SeasonButton);
            SeasonGroup.Controls.Add(SeasonComboBox);
            SeasonGroup.Controls.Add(SeasonLabel);
            SeasonGroup.Location = new Point(431, 302);
            SeasonGroup.Name = "SeasonGroup";
            SeasonGroup.Size = new Size(353, 111);
            SeasonGroup.TabIndex = 12;
            SeasonGroup.TabStop = false;
            SeasonGroup.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(228, 57);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(75, 23);
            SeasonButton.TabIndex = 4;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Spring", "Autum", "Winter", "Summer" });
            SeasonComboBox.Location = new Point(6, 57);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(204, 23);
            SeasonComboBox.TabIndex = 3;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(6, 39);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(89, 15);
            SeasonLabel.TabIndex = 2;
            SeasonLabel.Text = "Choose season:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DayOfTheWeekInfo);
            groupBox1.Controls.Add(ParseButton);
            groupBox1.Controls.Add(TypeLabel);
            groupBox1.Controls.Add(TextParseBox);
            groupBox1.Location = new Point(8, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 111);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Weekday Parsing";
            // 
            // DayOfTheWeekInfo
            // 
            DayOfTheWeekInfo.AutoSize = true;
            DayOfTheWeekInfo.ForeColor = SystemColors.ControlDarkDark;
            DayOfTheWeekInfo.Location = new Point(5, 84);
            DayOfTheWeekInfo.Name = "DayOfTheWeekInfo";
            DayOfTheWeekInfo.Size = new Size(0, 15);
            DayOfTheWeekInfo.TabIndex = 3;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(225, 56);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(75, 23);
            ParseButton.TabIndex = 2;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(6, 34);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(125, 15);
            TypeLabel.TabIndex = 1;
            TypeLabel.Text = "Type value for parsing:";
            // 
            // TextParseBox
            // 
            TextParseBox.Location = new Point(6, 56);
            TextParseBox.Name = "TextParseBox";
            TextParseBox.Size = new Size(204, 23);
            TextParseBox.TabIndex = 0;
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(437, 155);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(100, 23);
            ValueTextBox.TabIndex = 10;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(192, 28);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(157, 244);
            ValuesListBox.TabIndex = 9;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Genre", "Season", "SmartphoneManufacturer", "StudentEducationType", "Weekday" });
            EnumsListBox.Location = new Point(8, 28);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(157, 244);
            EnumsListBox.TabIndex = 8;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ValueListLabel);
            Controls.Add(EnumListLabel);
            Controls.Add(IntValueBox);
            Controls.Add(SeasonGroup);
            Controls.Add(groupBox1);
            Controls.Add(ValueTextBox);
            Controls.Add(ValuesListBox);
            Controls.Add(EnumsListBox);
            Name = "EnumsControl";
            Size = new Size(792, 422);
            SeasonGroup.ResumeLayout(false);
            SeasonGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ValueListLabel;
        private Label EnumListLabel;
        private Label IntValueBox;
        private GroupBox SeasonGroup;
        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private Label SeasonLabel;
        private GroupBox groupBox1;
        private Label DayOfTheWeekInfo;
        private Button ParseButton;
        private Label TypeLabel;
        private TextBox TextParseBox;
        private TextBox ValueTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}
