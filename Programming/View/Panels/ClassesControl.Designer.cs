namespace Programming.View.Panels
{
    partial class ClassesControl
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
            groupBox2.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
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
            groupBox2.Location = new Point(392, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 413);
            groupBox2.TabIndex = 3;
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
            RectanglesGroupBox.Location = new Point(7, 5);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(379, 413);
            RectanglesGroupBox.TabIndex = 2;
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
            // ClassesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(RectanglesGroupBox);
            Name = "ClassesControl";
            Size = new Size(792, 422);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox FilmRatingTextBox;
        private Label FilmRatingLable;
        private TextBox FilmGenreTextBox;
        private Label FilmGenreLable;
        private Button FilmFindButton;
        private TextBox FilmReleaseYearTextBox;
        private Label FilmReleaseYearLable;
        private TextBox FilmDurationTextBox;
        private Label FilmDurationLable;
        private Label FilmTitleLable;
        private TextBox FilmTitleTextBox;
        private ListBox FilmsListBox;
        private GroupBox RectanglesGroupBox;
        private TextBox TextBoxRectangleId;
        private Label LabelRectangleId;
        private TextBox TextBoxCenterCoordY;
        private Label LabelCoordY;
        private Label LabelCoordX;
        private TextBox TextBoxCenterCoordX;
        private Label LabelCenterOfRectangle;
        private Button RectangleFindButton;
        private TextBox RectangleColorTextBox;
        private Label RectangleColorLabel;
        private TextBox RectangleWidthTextBox;
        private Label RectangleWidthLabel;
        private Label RectangleLenghtLabel;
        private TextBox RectangleLenghtTextBox;
        private ListBox RectanglesListBox;
    }
}
