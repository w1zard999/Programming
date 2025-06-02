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
        tabPage2 = new TabPage();
        classesControl1 = new Programming.View.Panels.ClassesControl();
        tabPage3 = new TabPage();
        rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
        enumsControl1 = new Programming.View.Panels.EnumsControl();
        TabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
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
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(enumsControl1);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(792, 422);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Enums";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(classesControl1);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(792, 422);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Classes";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // classesControl1
        // 
        classesControl1.Location = new Point(-3, 0);
        classesControl1.Name = "classesControl1";
        classesControl1.Size = new Size(792, 422);
        classesControl1.TabIndex = 0;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(rectanglesCollisionControl1);
        tabPage3.Location = new Point(4, 24);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(792, 422);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Rectangles";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // rectanglesCollisionControl1
        // 
        rectanglesCollisionControl1.Location = new Point(0, 0);
        rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
        rectanglesCollisionControl1.Size = new Size(792, 422);
        rectanglesCollisionControl1.TabIndex = 0;
        // 
        // enumsControl1
        // 
        enumsControl1.Location = new Point(0, 0);
        enumsControl1.Name = "enumsControl1";
        enumsControl1.Size = new Size(792, 422);
        enumsControl1.TabIndex = 0;
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
        tabPage2.ResumeLayout(false);
        tabPage3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabControl TabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
    private View.Panels.ClassesControl classesControl1;
    private View.Panels.EnumsControl enumsControl1;
}
