namespace Programming;

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
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
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
        IntValueBox = new Label();
        EnumListLabel = new Label();
        ValueListLabel = new Label();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        SeasonGroup.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(800, 450);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(ValueListLabel);
        tabPage1.Controls.Add(EnumListLabel);
        tabPage1.Controls.Add(IntValueBox);
        tabPage1.Controls.Add(SeasonGroup);
        tabPage1.Controls.Add(groupBox1);
        tabPage1.Controls.Add(ValueTextBox);
        tabPage1.Controls.Add(ValuesListBox);
        tabPage1.Controls.Add(EnumsListBox);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(792, 422);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Enums";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // SeasonGroup
        // 
        SeasonGroup.Controls.Add(SeasonButton);
        SeasonGroup.Controls.Add(SeasonComboBox);
        SeasonGroup.Controls.Add(SeasonLabel);
        SeasonGroup.Location = new Point(431, 303);
        SeasonGroup.Name = "SeasonGroup";
        SeasonGroup.Size = new Size(353, 111);
        SeasonGroup.TabIndex = 4;
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
        groupBox1.Location = new Point(8, 303);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(341, 111);
        groupBox1.TabIndex = 3;
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
        ValueTextBox.Location = new Point(437, 156);
        ValueTextBox.Name = "ValueTextBox";
        ValueTextBox.Size = new Size(100, 23);
        ValueTextBox.TabIndex = 2;
        // 
        // ValuesListBox
        // 
        ValuesListBox.FormattingEnabled = true;
        ValuesListBox.ItemHeight = 15;
        ValuesListBox.Location = new Point(192, 29);
        ValuesListBox.Name = "ValuesListBox";
        ValuesListBox.Size = new Size(157, 244);
        ValuesListBox.TabIndex = 1;
        ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
        // 
        // EnumsListBox
        // 
        EnumsListBox.FormattingEnabled = true;
        EnumsListBox.ItemHeight = 15;
        EnumsListBox.Items.AddRange(new object[] { "Color", "Genre", "Season", "SmartphoneManufacturer", "StudentEducationType", "Weekday" });
        EnumsListBox.Location = new Point(8, 29);
        EnumsListBox.Name = "EnumsListBox";
        EnumsListBox.Size = new Size(157, 244);
        EnumsListBox.TabIndex = 0;
        EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
        // 
        // IntValueBox
        // 
        IntValueBox.AutoSize = true;
        IntValueBox.Location = new Point(437, 138);
        IntValueBox.Name = "IntValueBox";
        IntValueBox.Size = new Size(55, 15);
        IntValueBox.TabIndex = 5;
        IntValueBox.Text = "Int value:";
        // 
        // EnumListLabel
        // 
        EnumListLabel.AutoSize = true;
        EnumListLabel.Location = new Point(8, 11);
        EnumListLabel.Name = "EnumListLabel";
        EnumListLabel.Size = new Size(121, 15);
        EnumListLabel.TabIndex = 6;
        EnumListLabel.Text = "Choose enumeration:";
        // 
        // ValueListLabel
        // 
        ValueListLabel.AutoSize = true;
        ValueListLabel.Location = new Point(192, 11);
        ValueListLabel.Name = "ValueListLabel";
        ValueListLabel.Size = new Size(81, 15);
        ValueListLabel.TabIndex = 7;
        ValueListLabel.Text = "Choose Value:";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tabControl1);
        Name = "MainForm";
        Text = "Form1";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        SeasonGroup.ResumeLayout(false);
        SeasonGroup.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private ListBox EnumsListBox;
    private ListBox ValuesListBox;
    private TextBox ValueTextBox;
    private GroupBox groupBox1;
    private TextBox TextParseBox;
    private Button ParseButton;
    private Label TypeLabel;
    private Label DayOfTheWeekInfo;
    private GroupBox SeasonGroup;
    private Label SeasonLabel;
    private Button SeasonButton;
    private ComboBox SeasonComboBox;
    private Label ValueListLabel;
    private Label EnumListLabel;
    private Label IntValueBox;
}
