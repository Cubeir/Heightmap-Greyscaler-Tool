namespace Heightmap_Greyscaler;

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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        folder_button = new Button();
        file_button = new Button();
        greyscale_button = new Button();
        recursiveSearch_checkbox = new CheckBox();
        safety_checkbox = new CheckBox();
        cubeir_pictureBox = new PictureBox();
        progressBar1 = new ProgressBar();
        ((System.ComponentModel.ISupportInitialize)cubeir_pictureBox).BeginInit();
        SuspendLayout();
        // 
        // folder_button
        // 
        folder_button.Anchor = AnchorStyles.None;
        folder_button.AutoSize = true;
        folder_button.BackColor = SystemColors.Desktop;
        folder_button.BackgroundImage = (Image)resources.GetObject("folder_button.BackgroundImage");
        folder_button.Cursor = Cursors.Hand;
        folder_button.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        folder_button.FlatStyle = FlatStyle.Flat;
        folder_button.Font = new Font("Monocraft", 11.25F, FontStyle.Bold);
        folder_button.ForeColor = Color.White;
        folder_button.Location = new Point(14, 12);
        folder_button.Margin = new Padding(5, 3, 10, 5);
        folder_button.Name = "folder_button";
        folder_button.Size = new Size(186, 54);
        folder_button.TabIndex = 1;
        folder_button.Text = "Select Folder";
        folder_button.UseVisualStyleBackColor = false;
        folder_button.Click += folder_button_Click;
        // 
        // file_button
        // 
        file_button.Anchor = AnchorStyles.None;
        file_button.AutoSize = true;
        file_button.BackColor = SystemColors.Desktop;
        file_button.BackgroundImage = (Image)resources.GetObject("file_button.BackgroundImage");
        file_button.Cursor = Cursors.Hand;
        file_button.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        file_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
        file_button.FlatAppearance.MouseOverBackColor = Color.Gray;
        file_button.FlatStyle = FlatStyle.Flat;
        file_button.Font = new Font("Monocraft", 11.25F, FontStyle.Bold);
        file_button.ForeColor = Color.White;
        file_button.Location = new Point(14, 74);
        file_button.Margin = new Padding(5, 3, 10, 5);
        file_button.Name = "file_button";
        file_button.Size = new Size(186, 54);
        file_button.TabIndex = 2;
        file_button.Text = "Select Files";
        file_button.UseVisualStyleBackColor = false;
        file_button.Click += file_button_Click;
        // 
        // greyscale_button
        // 
        greyscale_button.Anchor = AnchorStyles.None;
        greyscale_button.AutoSize = true;
        greyscale_button.BackColor = SystemColors.Desktop;
        greyscale_button.BackgroundImage = (Image)resources.GetObject("greyscale_button.BackgroundImage");
        greyscale_button.Cursor = Cursors.Hand;
        greyscale_button.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        greyscale_button.FlatStyle = FlatStyle.Flat;
        greyscale_button.Font = new Font("Monocraft", 11.25F, FontStyle.Bold);
        greyscale_button.ForeColor = Color.White;
        greyscale_button.Location = new Point(14, 156);
        greyscale_button.Margin = new Padding(5, 3, 10, 5);
        greyscale_button.Name = "greyscale_button";
        greyscale_button.Size = new Size(186, 54);
        greyscale_button.TabIndex = 3;
        greyscale_button.Text = "Greyscale!";
        greyscale_button.UseVisualStyleBackColor = false;
        greyscale_button.Click += greyscale_button_Click;
        // 
        // recursiveSearch_checkbox
        // 
        recursiveSearch_checkbox.AutoSize = true;
        recursiveSearch_checkbox.BackColor = Color.Transparent;
        recursiveSearch_checkbox.Checked = true;
        recursiveSearch_checkbox.CheckState = CheckState.Checked;
        recursiveSearch_checkbox.Font = new Font("Monocraft", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
        recursiveSearch_checkbox.Location = new Point(14, 221);
        recursiveSearch_checkbox.Name = "recursiveSearch_checkbox";
        recursiveSearch_checkbox.Size = new Size(197, 21);
        recursiveSearch_checkbox.TabIndex = 5;
        recursiveSearch_checkbox.Text = "Search Subfolders";
        recursiveSearch_checkbox.UseVisualStyleBackColor = false;
        recursiveSearch_checkbox.CheckedChanged += recursiveSearch_checkbox_CheckedChanged;
        // 
        // safety_checkbox
        // 
        safety_checkbox.AutoSize = true;
        safety_checkbox.BackColor = Color.Transparent;
        safety_checkbox.Checked = true;
        safety_checkbox.CheckState = CheckState.Checked;
        safety_checkbox.Font = new Font("Monocraft", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
        safety_checkbox.Location = new Point(14, 244);
        safety_checkbox.Name = "safety_checkbox";
        safety_checkbox.Size = new Size(347, 21);
        safety_checkbox.TabIndex = 6;
        safety_checkbox.Text = "Process '_heightmap' suffix only";
        safety_checkbox.UseVisualStyleBackColor = false;
        safety_checkbox.CheckedChanged += safety_checkbox_CheckedChanged;
        // 
        // cubeir_pictureBox
        // 
        cubeir_pictureBox.BackColor = Color.Transparent;
        cubeir_pictureBox.BackgroundImage = (Image)resources.GetObject("cubeir_pictureBox.BackgroundImage");
        cubeir_pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        cubeir_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        cubeir_pictureBox.Cursor = Cursors.Hand;
        cubeir_pictureBox.Location = new Point(277, 59);
        cubeir_pictureBox.Name = "cubeir_pictureBox";
        cubeir_pictureBox.Size = new Size(84, 84);
        cubeir_pictureBox.TabIndex = 7;
        cubeir_pictureBox.TabStop = false;
        cubeir_pictureBox.Click += cubeir_pictureBox_Click;
        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(213, 187);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(209, 23);
        progressBar1.TabIndex = 8;
        // 
        // MainForm
        // 
        AccessibleRole = AccessibleRole.None;
        AutoScaleDimensions = new SizeF(9F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDark;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(434, 277);
        Controls.Add(progressBar1);
        Controls.Add(cubeir_pictureBox);
        Controls.Add(safety_checkbox);
        Controls.Add(recursiveSearch_checkbox);
        Controls.Add(greyscale_button);
        Controls.Add(file_button);
        Controls.Add(folder_button);
        DoubleBuffered = true;
        Font = new Font("Monocraft", 8.999999F, FontStyle.Bold);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Greyscaler for Minecraft RTX";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)cubeir_pictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button folder_button;
    private Button file_button;
    private Button greyscale_button;
    private CheckBox recursiveSearch_checkbox;
    private CheckBox safety_checkbox;
    private PictureBox cubeir_pictureBox;
    private ProgressBar progressBar1;
}
