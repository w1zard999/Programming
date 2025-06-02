namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            RectanglesListBox = new ListBox();
            LenghtRectangleLable = new Label();
            WidthRectangleLable = new Label();
            YCoordRectagleLable = new Label();
            XCoordRectangleLable = new Label();
            IdRectangleLable = new Label();
            SuspendLayout();
            // 
            // LengthRectangleTextBox
            // 
            LengthRectangleTextBox.Location = new Point(61, 351);
            LengthRectangleTextBox.Name = "LengthRectangleTextBox";
            LengthRectangleTextBox.Size = new Size(100, 23);
            LengthRectangleTextBox.TabIndex = 20;
            LengthRectangleTextBox.TextChanged += LengthRectangleTextBox_TextChanged;
            // 
            // WidthRectangleTextBox
            // 
            WidthRectangleTextBox.Location = new Point(61, 322);
            WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            WidthRectangleTextBox.Size = new Size(100, 23);
            WidthRectangleTextBox.TabIndex = 19;
            WidthRectangleTextBox.TextChanged += WidthRectangleTextBox_TextChanged;
            // 
            // YCoordRectangleTextBox
            // 
            YCoordRectangleTextBox.Location = new Point(61, 293);
            YCoordRectangleTextBox.Name = "YCoordRectangleTextBox";
            YCoordRectangleTextBox.Size = new Size(100, 23);
            YCoordRectangleTextBox.TabIndex = 18;
            YCoordRectangleTextBox.TextChanged += YCoordRectangleTextBox_TextChanged;
            // 
            // XCoordRectangleTextBox
            // 
            XCoordRectangleTextBox.Location = new Point(61, 264);
            XCoordRectangleTextBox.Name = "XCoordRectangleTextBox";
            XCoordRectangleTextBox.Size = new Size(100, 23);
            XCoordRectangleTextBox.TabIndex = 17;
            XCoordRectangleTextBox.TextChanged += XCoordRectangleTextBox_TextChanged;
            // 
            // IdRectangleTextBox
            // 
            IdRectangleTextBox.Location = new Point(61, 235);
            IdRectangleTextBox.Name = "IdRectangleTextBox";
            IdRectangleTextBox.ReadOnly = true;
            IdRectangleTextBox.Size = new Size(100, 23);
            IdRectangleTextBox.TabIndex = 16;
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Location = new Point(241, 6);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(545, 410);
            CanvasPanel.TabIndex = 15;
            // 
            // SelectedRectagleLable
            // 
            SelectedRectagleLable.AutoSize = true;
            SelectedRectagleLable.Location = new Point(8, 217);
            SelectedRectagleLable.Name = "SelectedRectagleLable";
            SelectedRectagleLable.Size = new Size(106, 15);
            SelectedRectagleLable.TabIndex = 14;
            SelectedRectagleLable.Text = "Selected rectangle:";
            // 
            // RemoveRectangleButton
            // 
            RemoveRectangleButton.FlatStyle = FlatStyle.Flat;
            RemoveRectangleButton.Location = new Point(120, 178);
            RemoveRectangleButton.Name = "RemoveRectangleButton";
            RemoveRectangleButton.Size = new Size(75, 23);
            RemoveRectangleButton.TabIndex = 13;
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
            AddRectangleButton.TabIndex = 12;
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
            RectanglesLabel.TabIndex = 11;
            RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(6, 33);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(229, 139);
            RectanglesListBox.TabIndex = 21;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            RectanglesListBox.MouseDown += RectanglesListBox_MouseDown;
            // 
            // LenghtRectangleLable
            // 
            LenghtRectangleLable.AutoSize = true;
            LenghtRectangleLable.Location = new Point(8, 354);
            LenghtRectangleLable.Name = "LenghtRectangleLable";
            LenghtRectangleLable.Size = new Size(47, 15);
            LenghtRectangleLable.TabIndex = 26;
            LenghtRectangleLable.Text = "Lenght:";
            // 
            // WidthRectangleLable
            // 
            WidthRectangleLable.AutoSize = true;
            WidthRectangleLable.Location = new Point(13, 325);
            WidthRectangleLable.Name = "WidthRectangleLable";
            WidthRectangleLable.Size = new Size(42, 15);
            WidthRectangleLable.TabIndex = 25;
            WidthRectangleLable.Text = "Width:";
            // 
            // YCoordRectagleLable
            // 
            YCoordRectagleLable.AutoSize = true;
            YCoordRectagleLable.Location = new Point(38, 296);
            YCoordRectagleLable.Name = "YCoordRectagleLable";
            YCoordRectagleLable.Size = new Size(17, 15);
            YCoordRectagleLable.TabIndex = 24;
            YCoordRectagleLable.Text = "Y:";
            // 
            // XCoordRectangleLable
            // 
            XCoordRectangleLable.AutoSize = true;
            XCoordRectangleLable.Location = new Point(38, 267);
            XCoordRectangleLable.Name = "XCoordRectangleLable";
            XCoordRectangleLable.Size = new Size(17, 15);
            XCoordRectangleLable.TabIndex = 23;
            XCoordRectangleLable.Text = "X:";
            // 
            // IdRectangleLable
            // 
            IdRectangleLable.AutoSize = true;
            IdRectangleLable.Location = new Point(35, 238);
            IdRectangleLable.Name = "IdRectangleLable";
            IdRectangleLable.Size = new Size(20, 15);
            IdRectangleLable.TabIndex = 22;
            IdRectangleLable.Text = "Id:";
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LenghtRectangleLable);
            Controls.Add(WidthRectangleLable);
            Controls.Add(YCoordRectagleLable);
            Controls.Add(XCoordRectangleLable);
            Controls.Add(IdRectangleLable);
            Controls.Add(RectanglesListBox);
            Controls.Add(LengthRectangleTextBox);
            Controls.Add(WidthRectangleTextBox);
            Controls.Add(YCoordRectangleTextBox);
            Controls.Add(XCoordRectangleTextBox);
            Controls.Add(IdRectangleTextBox);
            Controls.Add(CanvasPanel);
            Controls.Add(SelectedRectagleLable);
            Controls.Add(RemoveRectangleButton);
            Controls.Add(AddRectangleButton);
            Controls.Add(RectanglesLabel);
            Name = "RectanglesCollisionControl";
            Size = new Size(792, 422);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LengthRectangleTextBox;
        private TextBox WidthRectangleTextBox;
        private TextBox YCoordRectangleTextBox;
        private TextBox XCoordRectangleTextBox;
        private TextBox IdRectangleTextBox;
        private Panel CanvasPanel;
        private Label SelectedRectagleLable;
        private Button RemoveRectangleButton;
        private Button AddRectangleButton;
        private Label RectanglesLabel;
        private ListBox RectanglesListBox;
        private Label LenghtRectangleLable;
        private Label WidthRectangleLable;
        private Label YCoordRectagleLable;
        private Label XCoordRectangleLable;
        private Label IdRectangleLable;
    }
}
