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
        TabControl1 = new TabControl();
        tabPage1 = new TabPage();
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
        tabPage2 = new TabPage();
        RectanglesGroupBox = new GroupBox();
        RectangleFindButton = new Button();
        RectangleColorTextBox = new TextBox();
        RectangleColorLabel = new Label();
        RectangleWidthTextBox = new TextBox();
        RectangleWidthLabel = new Label();
        RectangleLenghtLabel = new Label();
        RectangleLenghtTextBox = new TextBox();
        RectanglesListBox = new ListBox();
        TabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        SeasonGroup.SuspendLayout();
        groupBox1.SuspendLayout();
        tabPage2.SuspendLayout();
        RectanglesGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // TabControl1
        // 
        TabControl1.Controls.Add(tabPage1);
        TabControl1.Controls.Add(tabPage2);
        TabControl1.Dock = DockStyle.Fill;
        TabControl1.Location = new Point(0, 0);
        TabControl1.Name = "TabControl1";
        TabControl1.SelectedIndex = 0;
        TabControl1.Size = new Size(800, 450);
        TabControl1.TabIndex = 0;
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
        // ValueListLabel
        // 
        ValueListLabel.AutoSize = true;
        ValueListLabel.Location = new Point(192, 11);
        ValueListLabel.Name = "ValueListLabel";
        ValueListLabel.Size = new Size(81, 15);
        ValueListLabel.TabIndex = 7;
        ValueListLabel.Text = "Choose Value:";
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
        // IntValueBox
        // 
        IntValueBox.AutoSize = true;
        IntValueBox.Location = new Point(437, 138);
        IntValueBox.Name = "IntValueBox";
        IntValueBox.Size = new Size(55, 15);
        IntValueBox.TabIndex = 5;
        IntValueBox.Text = "Int value:";
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
        // tabPage2
        // 
        tabPage2.Controls.Add(RectanglesGroupBox);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(792, 422);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Classes";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // RectanglesGroupBox
        // 
        RectanglesGroupBox.Controls.Add(RectangleFindButton);
        RectanglesGroupBox.Controls.Add(RectangleColorTextBox);
        RectanglesGroupBox.Controls.Add(RectangleColorLabel);
        RectanglesGroupBox.Controls.Add(RectangleWidthTextBox);
        RectanglesGroupBox.Controls.Add(RectangleWidthLabel);
        RectanglesGroupBox.Controls.Add(RectangleLenghtLabel);
        RectanglesGroupBox.Controls.Add(RectangleLenghtTextBox);
        RectanglesGroupBox.Controls.Add(RectanglesListBox);
        RectanglesGroupBox.Location = new Point(8, 6);
        RectanglesGroupBox.Name = "RectanglesGroupBox";
        RectanglesGroupBox.Size = new Size(246, 215);
        RectanglesGroupBox.TabIndex = 0;
        RectanglesGroupBox.TabStop = false;
        RectanglesGroupBox.Text = "Rectangles";
        // 
        // RectangleFindButton
        // 
        RectangleFindButton.Location = new Point(139, 183);
        RectangleFindButton.Name = "RectangleFindButton";
        RectangleFindButton.Size = new Size(100, 23);
        RectangleFindButton.TabIndex = 7;
        RectangleFindButton.Text = "Find";
        RectangleFindButton.UseVisualStyleBackColor = true;
        RectangleFindButton.MouseClick += RectangleFindButton_Click;
        // 
        // RectangleColorTextBox
        // 
        RectangleColorTextBox.Location = new Point(140, 128);
        RectangleColorTextBox.Name = "RectangleColorTextBox";
        RectangleColorTextBox.Size = new Size(100, 23);
        RectangleColorTextBox.TabIndex = 6;
        // 
        // RectangleColorLabel
        // 
        RectangleColorLabel.AutoSize = true;
        RectangleColorLabel.Location = new Point(139, 110);
        RectangleColorLabel.Name = "RectangleColorLabel";
        RectangleColorLabel.Size = new Size(36, 15);
        RectangleColorLabel.TabIndex = 5;
        RectangleColorLabel.Text = "Color";
        // 
        // RectangleWidthTextBox
        // 
        RectangleWidthTextBox.Location = new Point(139, 84);
        RectangleWidthTextBox.Name = "RectangleWidthTextBox";
        RectangleWidthTextBox.Size = new Size(100, 23);
        RectangleWidthTextBox.TabIndex = 4;
        RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
        // 
        // RectangleWidthLabel
        // 
        RectangleWidthLabel.AutoSize = true;
        RectangleWidthLabel.Location = new Point(139, 66);
        RectangleWidthLabel.Name = "RectangleWidthLabel";
        RectangleWidthLabel.Size = new Size(39, 15);
        RectangleWidthLabel.TabIndex = 3;
        RectangleWidthLabel.Text = "Width";
        // 
        // RectangleLenghtLabel
        // 
        RectangleLenghtLabel.AutoSize = true;
        RectangleLenghtLabel.Location = new Point(139, 22);
        RectangleLenghtLabel.Name = "RectangleLenghtLabel";
        RectangleLenghtLabel.Size = new Size(44, 15);
        RectangleLenghtLabel.TabIndex = 2;
        RectangleLenghtLabel.Text = "Lenght";
        // 
        // RectangleLenghtTextBox
        // 
        RectangleLenghtTextBox.Location = new Point(139, 40);
        RectangleLenghtTextBox.Name = "RectangleLenghtTextBox";
        RectangleLenghtTextBox.Size = new Size(100, 23);
        RectangleLenghtTextBox.TabIndex = 1;
        RectangleLenghtTextBox.TextChanged += RectangleLenghtTextBox_TextChanged;
        // 
        // RectanglesListBox
        // 
        RectanglesListBox.FormattingEnabled = true;
        RectanglesListBox.ItemHeight = 15;
        RectanglesListBox.Location = new Point(6, 22);
        RectanglesListBox.Name = "RectanglesListBox";
        RectanglesListBox.Size = new Size(127, 184);
        RectanglesListBox.TabIndex = 0;
        RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(TabControl1);
        Name = "MainForm";
        Text = "Form1";
        TabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        SeasonGroup.ResumeLayout(false);
        SeasonGroup.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tabPage2.ResumeLayout(false);
        RectanglesGroupBox.ResumeLayout(false);
        RectanglesGroupBox.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl TabControl1;
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
    private TabPage tabPage2;
    private GroupBox RectanglesGroupBox;
    private ListBox RectanglesListBox;
    private TextBox RectangleLenghtTextBox;
    private Button RectangleFindButton;
    private TextBox RectangleColorTextBox;
    private Label RectangleColorLabel;
    private TextBox RectangleWidthTextBox;
    private Label RectangleWidthLabel;
    private Label RectangleLenghtLabel;
}
