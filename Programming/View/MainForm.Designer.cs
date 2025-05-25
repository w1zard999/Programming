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
        groupBox2 = new GroupBox();
        FilmRatingTextBox = new TextBox();
        FilmRatingLable = new Label();
        FilmGenreTextBox = new TextBox();
        FilmGenreLable = new Label();
        FilmFindButton = new Button();
        FilmReleaseYearTextBox = new TextBox();
        FilmReleaseYearLable = new Label();
        FilmDurationTextBox = new TextBox();
        FilmDurationLable = new Label();
        FilmTitleLable = new Label();
        FilmTitleTextBox = new TextBox();
        FilmsListBox = new ListBox();
        RectanglesGroupBox = new GroupBox();
        TextBoxRectangleId = new TextBox();
        LabelRectangleId = new Label();
        TextBoxCenterCoordY = new TextBox();
        LabelCoordY = new Label();
        LabelCoordX = new Label();
        TextBoxCenterCoordX = new TextBox();
        LabelCenterOfRectangle = new Label();
        RectangleFindButton = new Button();
        RectangleColorTextBox = new TextBox();
        RectangleColorLabel = new Label();
        RectangleWidthTextBox = new TextBox();
        RectangleWidthLabel = new Label();
        RectangleLenghtLabel = new Label();
        RectangleLenghtTextBox = new TextBox();
        RectanglesListBox = new ListBox();
        tabPage3 = new TabPage();
        LenghtRectangleLable = new Label();
        WidthRectangleLable = new Label();
        YCoordRectagleLable = new Label();
        XCoordRectangleLable = new Label();
        IdRectangleLable = new Label();
        LengthRectangleTextBox = new TextBox();
        WidthRectangleTextBox = new TextBox();
        YCoordRectangleTextBox = new TextBox();
        XCoordRectangleTextBox = new TextBox();
        IdRectangleTextBox = new TextBox();
        CanvasPanel = new Panel();
        SelectedRectagleLable = new Label();
        RemoveRectangleButton = new Button();
        AddRectangleButton = new Button();
        RectanglesLabel = new Label();
        RectanglesListBox1 = new ListBox();
        TabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        SeasonGroup.SuspendLayout();
        groupBox1.SuspendLayout();
        tabPage2.SuspendLayout();
        groupBox2.SuspendLayout();
        RectanglesGroupBox.SuspendLayout();
        tabPage3.SuspendLayout();
        SuspendLayout();
        // 
        // TabControl1
        // 
        TabControl1.Controls.Add(tabPage1);
        TabControl1.Controls.Add(tabPage2);
        TabControl1.Controls.Add(tabPage3);
        TabControl1.Dock = DockStyle.Fill;
        TabControl1.Location = new Point(0, 0);
        TabControl1.Name = "TabControl1";
        TabControl1.SelectedIndex = 0;
        TabControl1.Size = new Size(800, 450);
        TabControl1.TabIndex = 0;
        TabControl1.TabIndexChanged += TabControl1_TabIndexChanged;
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
        tabPage2.Controls.Add(groupBox2);
        tabPage2.Controls.Add(RectanglesGroupBox);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(792, 422);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Classes";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(FilmRatingTextBox);
        groupBox2.Controls.Add(FilmRatingLable);
        groupBox2.Controls.Add(FilmGenreTextBox);
        groupBox2.Controls.Add(FilmGenreLable);
        groupBox2.Controls.Add(FilmFindButton);
        groupBox2.Controls.Add(FilmReleaseYearTextBox);
        groupBox2.Controls.Add(FilmReleaseYearLable);
        groupBox2.Controls.Add(FilmDurationTextBox);
        groupBox2.Controls.Add(FilmDurationLable);
        groupBox2.Controls.Add(FilmTitleLable);
        groupBox2.Controls.Add(FilmTitleTextBox);
        groupBox2.Controls.Add(FilmsListBox);
        groupBox2.Location = new Point(393, 6);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(393, 413);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Films";
        // 
        // FilmRatingTextBox
        // 
        FilmRatingTextBox.Location = new Point(140, 216);
        FilmRatingTextBox.Name = "FilmRatingTextBox";
        FilmRatingTextBox.Size = new Size(148, 23);
        FilmRatingTextBox.TabIndex = 11;
        FilmRatingTextBox.TextChanged += FilmRating_TextChanged;
        // 
        // FilmRatingLable
        // 
        FilmRatingLable.AutoSize = true;
        FilmRatingLable.Location = new Point(139, 198);
        FilmRatingLable.Name = "FilmRatingLable";
        FilmRatingLable.Size = new Size(75, 15);
        FilmRatingLable.TabIndex = 10;
        FilmRatingLable.Text = "Rating (0-10)";
        // 
        // FilmGenreTextBox
        // 
        FilmGenreTextBox.Location = new Point(140, 172);
        FilmGenreTextBox.Name = "FilmGenreTextBox";
        FilmGenreTextBox.Size = new Size(148, 23);
        FilmGenreTextBox.TabIndex = 9;
        FilmGenreTextBox.TextChanged += FilmGenre_TextChange;
        // 
        // FilmGenreLable
        // 
        FilmGenreLable.AutoSize = true;
        FilmGenreLable.Location = new Point(140, 154);
        FilmGenreLable.Name = "FilmGenreLable";
        FilmGenreLable.Size = new Size(38, 15);
        FilmGenreLable.TabIndex = 8;
        FilmGenreLable.Text = "Genre";
        // 
        // FilmFindButton
        // 
        FilmFindButton.Location = new Point(167, 288);
        FilmFindButton.Name = "FilmFindButton";
        FilmFindButton.Size = new Size(100, 23);
        FilmFindButton.TabIndex = 7;
        FilmFindButton.Text = "Find";
        FilmFindButton.UseVisualStyleBackColor = true;
        FilmFindButton.MouseClick += FilmFindButton_Click;
        // 
        // FilmReleaseYearTextBox
        // 
        FilmReleaseYearTextBox.Location = new Point(140, 128);
        FilmReleaseYearTextBox.Name = "FilmReleaseYearTextBox";
        FilmReleaseYearTextBox.Size = new Size(148, 23);
        FilmReleaseYearTextBox.TabIndex = 6;
        FilmReleaseYearTextBox.TextChanged += FilmReleaseYear_TextChanged;
        // 
        // FilmReleaseYearLable
        // 
        FilmReleaseYearLable.AutoSize = true;
        FilmReleaseYearLable.Location = new Point(139, 110);
        FilmReleaseYearLable.Name = "FilmReleaseYearLable";
        FilmReleaseYearLable.Size = new Size(71, 15);
        FilmReleaseYearLable.TabIndex = 5;
        FilmReleaseYearLable.Text = "Release year";
        // 
        // FilmDurationTextBox
        // 
        FilmDurationTextBox.Location = new Point(139, 84);
        FilmDurationTextBox.Name = "FilmDurationTextBox";
        FilmDurationTextBox.Size = new Size(149, 23);
        FilmDurationTextBox.TabIndex = 4;
        FilmDurationTextBox.TextChanged += FilmDurationInMinutes_TextChanged;
        // 
        // FilmDurationLable
        // 
        FilmDurationLable.AutoSize = true;
        FilmDurationLable.Location = new Point(139, 66);
        FilmDurationLable.Name = "FilmDurationLable";
        FilmDurationLable.Size = new Size(112, 15);
        FilmDurationLable.TabIndex = 3;
        FilmDurationLable.Text = "Duration in minutes";
        // 
        // FilmTitleLable
        // 
        FilmTitleLable.AutoSize = true;
        FilmTitleLable.Location = new Point(139, 22);
        FilmTitleLable.Name = "FilmTitleLable";
        FilmTitleLable.Size = new Size(29, 15);
        FilmTitleLable.TabIndex = 2;
        FilmTitleLable.Text = "Title";
        // 
        // FilmTitleTextBox
        // 
        FilmTitleTextBox.Location = new Point(139, 40);
        FilmTitleTextBox.Name = "FilmTitleTextBox";
        FilmTitleTextBox.Size = new Size(149, 23);
        FilmTitleTextBox.TabIndex = 1;
        FilmTitleTextBox.TextChanged += FilmTitle_TextChange;
        // 
        // FilmsListBox
        // 
        FilmsListBox.FormattingEnabled = true;
        FilmsListBox.ItemHeight = 15;
        FilmsListBox.Location = new Point(6, 22);
        FilmsListBox.Name = "FilmsListBox";
        FilmsListBox.Size = new Size(127, 289);
        FilmsListBox.TabIndex = 0;
        FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
        // 
        // RectanglesGroupBox
        // 
        RectanglesGroupBox.Controls.Add(TextBoxRectangleId);
        RectanglesGroupBox.Controls.Add(LabelRectangleId);
        RectanglesGroupBox.Controls.Add(TextBoxCenterCoordY);
        RectanglesGroupBox.Controls.Add(LabelCoordY);
        RectanglesGroupBox.Controls.Add(LabelCoordX);
        RectanglesGroupBox.Controls.Add(TextBoxCenterCoordX);
        RectanglesGroupBox.Controls.Add(LabelCenterOfRectangle);
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
        RectanglesGroupBox.Size = new Size(379, 413);
        RectanglesGroupBox.TabIndex = 0;
        RectanglesGroupBox.TabStop = false;
        RectanglesGroupBox.Text = "Rectangles";
        // 
        // TextBoxRectangleId
        // 
        TextBoxRectangleId.Location = new Point(284, 40);
        TextBoxRectangleId.Name = "TextBoxRectangleId";
        TextBoxRectangleId.ReadOnly = true;
        TextBoxRectangleId.Size = new Size(42, 23);
        TextBoxRectangleId.TabIndex = 14;
        // 
        // LabelRectangleId
        // 
        LabelRectangleId.AutoSize = true;
        LabelRectangleId.Location = new Point(257, 43);
        LabelRectangleId.Name = "LabelRectangleId";
        LabelRectangleId.Size = new Size(21, 15);
        LabelRectangleId.TabIndex = 13;
        LabelRectangleId.Text = "ID:";
        // 
        // TextBoxCenterCoordY
        // 
        TextBoxCenterCoordY.Location = new Point(163, 224);
        TextBoxCenterCoordY.Name = "TextBoxCenterCoordY";
        TextBoxCenterCoordY.ReadOnly = true;
        TextBoxCenterCoordY.Size = new Size(100, 23);
        TextBoxCenterCoordY.TabIndex = 12;
        // 
        // LabelCoordY
        // 
        LabelCoordY.AutoSize = true;
        LabelCoordY.Location = new Point(140, 227);
        LabelCoordY.Name = "LabelCoordY";
        LabelCoordY.Size = new Size(17, 15);
        LabelCoordY.TabIndex = 11;
        LabelCoordY.Text = "Y:";
        // 
        // LabelCoordX
        // 
        LabelCoordX.AutoSize = true;
        LabelCoordX.Location = new Point(140, 198);
        LabelCoordX.Name = "LabelCoordX";
        LabelCoordX.Size = new Size(17, 15);
        LabelCoordX.TabIndex = 10;
        LabelCoordX.Text = "X:";
        // 
        // TextBoxCenterCoordX
        // 
        TextBoxCenterCoordX.Location = new Point(163, 195);
        TextBoxCenterCoordX.Name = "TextBoxCenterCoordX";
        TextBoxCenterCoordX.ReadOnly = true;
        TextBoxCenterCoordX.Size = new Size(100, 23);
        TextBoxCenterCoordX.TabIndex = 9;
        // 
        // LabelCenterOfRectangle
        // 
        LabelCenterOfRectangle.AutoSize = true;
        LabelCenterOfRectangle.Location = new Point(139, 172);
        LabelCenterOfRectangle.Name = "LabelCenterOfRectangle";
        LabelCenterOfRectangle.Size = new Size(108, 15);
        LabelCenterOfRectangle.TabIndex = 8;
        LabelCenterOfRectangle.Text = "Center of rectangle";
        // 
        // RectangleFindButton
        // 
        RectangleFindButton.Location = new Point(139, 288);
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
        RectangleColorTextBox.TextChanged += RectangleColor_TextChange;
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
        RectanglesListBox.Size = new Size(127, 289);
        RectanglesListBox.TabIndex = 0;
        RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(LenghtRectangleLable);
        tabPage3.Controls.Add(WidthRectangleLable);
        tabPage3.Controls.Add(YCoordRectagleLable);
        tabPage3.Controls.Add(XCoordRectangleLable);
        tabPage3.Controls.Add(IdRectangleLable);
        tabPage3.Controls.Add(LengthRectangleTextBox);
        tabPage3.Controls.Add(WidthRectangleTextBox);
        tabPage3.Controls.Add(YCoordRectangleTextBox);
        tabPage3.Controls.Add(XCoordRectangleTextBox);
        tabPage3.Controls.Add(IdRectangleTextBox);
        tabPage3.Controls.Add(CanvasPanel);
        tabPage3.Controls.Add(SelectedRectagleLable);
        tabPage3.Controls.Add(RemoveRectangleButton);
        tabPage3.Controls.Add(AddRectangleButton);
        tabPage3.Controls.Add(RectanglesLabel);
        tabPage3.Controls.Add(RectanglesListBox1);
        tabPage3.Location = new Point(4, 24);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(792, 422);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Rectangles";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // LenghtRectangleLable
        // 
        LenghtRectangleLable.AutoSize = true;
        LenghtRectangleLable.Location = new Point(12, 354);
        LenghtRectangleLable.Name = "LenghtRectangleLable";
        LenghtRectangleLable.Size = new Size(47, 15);
        LenghtRectangleLable.TabIndex = 15;
        LenghtRectangleLable.Text = "Lenght:";
        // 
        // WidthRectangleLable
        // 
        WidthRectangleLable.AutoSize = true;
        WidthRectangleLable.Location = new Point(17, 325);
        WidthRectangleLable.Name = "WidthRectangleLable";
        WidthRectangleLable.Size = new Size(42, 15);
        WidthRectangleLable.TabIndex = 14;
        WidthRectangleLable.Text = "Width:";
        // 
        // YCoordRectagleLable
        // 
        YCoordRectagleLable.AutoSize = true;
        YCoordRectagleLable.Location = new Point(42, 296);
        YCoordRectagleLable.Name = "YCoordRectagleLable";
        YCoordRectagleLable.Size = new Size(17, 15);
        YCoordRectagleLable.TabIndex = 13;
        YCoordRectagleLable.Text = "Y:";
        // 
        // XCoordRectangleLable
        // 
        XCoordRectangleLable.AutoSize = true;
        XCoordRectangleLable.Location = new Point(42, 267);
        XCoordRectangleLable.Name = "XCoordRectangleLable";
        XCoordRectangleLable.Size = new Size(17, 15);
        XCoordRectangleLable.TabIndex = 12;
        XCoordRectangleLable.Text = "X:";
        // 
        // IdRectangleLable
        // 
        IdRectangleLable.AutoSize = true;
        IdRectangleLable.Location = new Point(39, 238);
        IdRectangleLable.Name = "IdRectangleLable";
        IdRectangleLable.Size = new Size(20, 15);
        IdRectangleLable.TabIndex = 11;
        IdRectangleLable.Text = "Id:";
        // 
        // LengthRectangleTextBox
        // 
        LengthRectangleTextBox.Location = new Point(61, 351);
        LengthRectangleTextBox.Name = "LengthRectangleTextBox";
        LengthRectangleTextBox.Size = new Size(100, 23);
        LengthRectangleTextBox.TabIndex = 10;
        LengthRectangleTextBox.TextChanged += LengthRectangleTextBox_TextChanged;
        // 
        // WidthRectangleTextBox
        // 
        WidthRectangleTextBox.Location = new Point(61, 322);
        WidthRectangleTextBox.Name = "WidthRectangleTextBox";
        WidthRectangleTextBox.Size = new Size(100, 23);
        WidthRectangleTextBox.TabIndex = 9;
        WidthRectangleTextBox.TextChanged += WidthRectangleTextBox_TextChanged;
        // 
        // YCoordRectangleTextBox
        // 
        YCoordRectangleTextBox.Location = new Point(61, 293);
        YCoordRectangleTextBox.Name = "YCoordRectangleTextBox";
        YCoordRectangleTextBox.Size = new Size(100, 23);
        YCoordRectangleTextBox.TabIndex = 8;
        YCoordRectangleTextBox.TextChanged += YCoordRectangleTextBox_TextChanged;
        // 
        // XCoordRectangleTextBox
        // 
        XCoordRectangleTextBox.Location = new Point(61, 264);
        XCoordRectangleTextBox.Name = "XCoordRectangleTextBox";
        XCoordRectangleTextBox.Size = new Size(100, 23);
        XCoordRectangleTextBox.TabIndex = 7;
        XCoordRectangleTextBox.TextChanged += XCoordRectangleTextBox_TextChanged;
        // 
        // IdRectangleTextBox
        // 
        IdRectangleTextBox.Location = new Point(61, 235);
        IdRectangleTextBox.Name = "IdRectangleTextBox";
        IdRectangleTextBox.ReadOnly = true;
        IdRectangleTextBox.Size = new Size(100, 23);
        IdRectangleTextBox.TabIndex = 6;
        // 
        // CanvasPanel
        // 
        CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
        CanvasPanel.Location = new Point(241, 6);
        CanvasPanel.Name = "CanvasPanel";
        CanvasPanel.Size = new Size(545, 410);
        CanvasPanel.TabIndex = 5;
        // 
        // SelectedRectagleLable
        // 
        SelectedRectagleLable.AutoSize = true;
        SelectedRectagleLable.Location = new Point(8, 217);
        SelectedRectagleLable.Name = "SelectedRectagleLable";
        SelectedRectagleLable.Size = new Size(106, 15);
        SelectedRectagleLable.TabIndex = 4;
        SelectedRectagleLable.Text = "Selected rectangle:";
        // 
        // RemoveRectangleButton
        // 
        RemoveRectangleButton.FlatStyle = FlatStyle.Flat;
        RemoveRectangleButton.Location = new Point(120, 178);
        RemoveRectangleButton.Name = "RemoveRectangleButton";
        RemoveRectangleButton.Size = new Size(75, 23);
        RemoveRectangleButton.TabIndex = 3;
        RemoveRectangleButton.Text = "Remove";
        RemoveRectangleButton.UseVisualStyleBackColor = true;
        RemoveRectangleButton.Click += RemoveRectangleButton_Click;
        // 
        // AddRectangleButton
        // 
        AddRectangleButton.FlatStyle = FlatStyle.Flat;
        AddRectangleButton.Location = new Point(39, 178);
        AddRectangleButton.Name = "AddRectangleButton";
        AddRectangleButton.Size = new Size(75, 23);
        AddRectangleButton.TabIndex = 2;
        AddRectangleButton.Text = "Add";
        AddRectangleButton.UseVisualStyleBackColor = true;
        AddRectangleButton.Click += AddRectangleButton_Click;
        // 
        // RectanglesLabel
        // 
        RectanglesLabel.AutoSize = true;
        RectanglesLabel.Location = new Point(6, 15);
        RectanglesLabel.Name = "RectanglesLabel";
        RectanglesLabel.Size = new Size(67, 15);
        RectanglesLabel.TabIndex = 1;
        RectanglesLabel.Text = "Rectangles:";
        // 
        // RectanglesListBox1
        // 
        RectanglesListBox1.FormattingEnabled = true;
        RectanglesListBox1.ItemHeight = 15;
        RectanglesListBox1.Location = new Point(6, 33);
        RectanglesListBox1.Name = "RectanglesListBox1";
        RectanglesListBox1.Size = new Size(229, 139);
        RectanglesListBox1.TabIndex = 0;
        RectanglesListBox1.SelectedIndexChanged += RectanglesListBox1_SelectedIndexChanged;
        RectanglesListBox1.MouseDown += RectanglesListBox1_MouseDown;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(TabControl1);
        Name = "MainForm";
        Text = "Programming Demo";
        TabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        SeasonGroup.ResumeLayout(false);
        SeasonGroup.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tabPage2.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        RectanglesGroupBox.ResumeLayout(false);
        RectanglesGroupBox.PerformLayout();
        tabPage3.ResumeLayout(false);
        tabPage3.PerformLayout();
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
    private GroupBox groupBox2;
    private Button FilmFindButton;
    private TextBox FilmReleaseYearTextBox;
    private Label FilmReleaseYearLable;
    private TextBox FilmDurationTextBox;
    private Label FilmDurationLable;
    private Label FilmTitleLable;
    private TextBox FilmTitleTextBox;
    private ListBox FilmsListBox;
    private TextBox FilmRatingTextBox;
    private Label FilmRatingLable;
    private TextBox FilmGenreTextBox;
    private Label FilmGenreLable;
    private TextBox TextBoxCenterCoordY;
    private Label LabelCoordY;
    private Label LabelCoordX;
    private TextBox TextBoxCenterCoordX;
    private Label LabelCenterOfRectangle;
    private TextBox TextBoxRectangleId;
    private Label LabelRectangleId;
    private TabPage tabPage3;
    private ListBox RectanglesListBox1;
    private Button AddRectangleButton;
    private Label RectanglesLabel;
    private Panel CanvasPanel;
    private Label SelectedRectagleLable;
    private Button RemoveRectangleButton;
    private Label WidthRectangleLable;
    private Label YCoordRectagleLable;
    private Label XCoordRectangleLable;
    private Label IdRectangleLable;
    private TextBox LengthRectangleTextBox;
    private TextBox WidthRectangleTextBox;
    private TextBox YCoordRectangleTextBox;
    private TextBox XCoordRectangleTextBox;
    private TextBox IdRectangleTextBox;
    private Label LenghtRectangleLable;
}
