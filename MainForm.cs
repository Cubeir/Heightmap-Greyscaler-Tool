using System;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Heightmap_Greyscaler.Properties;
namespace Heightmap_Greyscaler;

public partial class MainForm : Form
{
    private string selectedFolderPath;
    private List<string> selectedFilePaths = new List<string>();
    private bool _isRecursiveSearchEnabled = true;
    private bool _isSafetyEnabled = true;


    public MainForm()
    {
        InitializeComponent();
        recursiveSearch_checkbox.CheckedChanged += recursiveSearch_checkbox_CheckedChanged;
        safety_checkbox.CheckedChanged += safety_checkbox_CheckedChanged;
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }

    public void folder_button_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.ShowNewFolderButton = true;


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolderPath = folderBrowserDialog.SelectedPath;
            }
        }
        if (selectedFolderPath != null && selectedFolderPath != "")
        {
            MessageBox.Show("Selected Folder:\n\n" + selectedFolderPath);
        }

    }

    public void file_button_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.tga;*.png;*.jpg;*.jpeg";
            openFileDialog.Title = "Select Files";

            // Show the file open dialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePaths.Clear();
                selectedFilePaths.AddRange(openFileDialog.FileNames);
            }
        }
        if (selectedFilePaths.Count > 0)
        {
            MessageBox.Show("Selected Files:\n\n" + string.Join("\n\n", selectedFilePaths));
        }
    }

    public async void greyscale_button_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(selectedFolderPath) && !selectedFilePaths.Any())
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Select at least one file or folder.");
            return;
        }

        List<string> allFilePaths = new List<string>();
        allFilePaths.AddRange(selectedFilePaths);


        // Search
        if (!string.IsNullOrEmpty(selectedFolderPath))
        {
            allFilePaths.AddRange(GetImageFilesFromFolder(selectedFolderPath));
        }

        // Apply safety filter if enabled
        if (_isSafetyEnabled)
        {
            allFilePaths = allFilePaths
                .Where(filePath => Path.GetFileNameWithoutExtension(filePath).EndsWith("_heightmap"))
                .ToList();
        }

        progressBar1.Minimum = 0;
        progressBar1.Maximum = allFilePaths.Count;
        progressBar1.Value = 0;
        progressBar1.Step = 1;

        foreach (var filePath in allFilePaths)
        {
            Methods.Greyscale(filePath);

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
        }

        selectedFolderPath = string.Empty;
        selectedFilePaths.Clear();

        SystemSounds.Asterisk.Play();
        progressBar1.Value = 0;
        MessageBox.Show("Processing completed.");
    }



    private void recursiveSearch_checkbox_CheckedChanged(object sender, EventArgs e)
    {
        _isRecursiveSearchEnabled = recursiveSearch_checkbox.Checked;
    }
    private void safety_checkbox_CheckedChanged(object sender, EventArgs e)
    {
        _isSafetyEnabled = safety_checkbox.Checked;
    }


    private void cubeir_pictureBox_Click(object sender, EventArgs e)
    {
        Methods.OpenFile(Path.Combine("miscellaneous", "url.url"));
    }


    /// - - - - Methods - - - - ///

    // Selected path retriever
    public string GetSelectedFolderPath()
    {
        return selectedFolderPath;
    }
    public List<string> GetSelectedFilePaths()
    {
        return selectedFilePaths;
    }

    // Recursively image path retriever
    private List<string> GetImageFilesFromFolder(string folderPath)
    {
        List<string> imageFiles = new List<string>();
        string[] searchPatterns = new string[] { "*.tga", "*.png", "*.jpg", "*.jpeg" };


        SearchOption searchOption = _isRecursiveSearchEnabled ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        foreach (string searchPattern in searchPatterns)
        {
            imageFiles.AddRange(Directory.GetFiles(folderPath, searchPattern, searchOption));
        }

        return imageFiles;
    }



    // Visual UI Elements
    private void folder_button_MouseDown(object sender, MouseEventArgs e)
    {
        Button clickedButton = sender as Button;
        clickedButton.BackgroundImage = Properties.Resources.oak_dark;
        clickedButton.BackgroundImageLayout = ImageLayout.Tile;
        clickedButton.Cursor = Cursors.Hand;
        clickedButton.FlatStyle = FlatStyle.Flat;
        clickedButton.FlatAppearance.BorderColor = Color.FromArgb(44, 44, 42);
        clickedButton.FlatAppearance.BorderSize = 3;
    }
    private void folder_button_MouseUp(object sender, MouseEventArgs e)
    {
        Button clickedButton = sender as Button;
        clickedButton.BackgroundImage = Properties.Resources.oak;
        clickedButton.BackgroundImageLayout = ImageLayout.Tile;
        clickedButton.Cursor = Cursors.Hand;
        clickedButton.FlatStyle = FlatStyle.Flat;
        clickedButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        clickedButton.FlatAppearance.BorderSize = 1;
    }
    private void file_button_MouseUp(object sender, MouseEventArgs e)
    {
        folder_button_MouseUp(sender, e);
    }
    private void file_button_MouseDown(object sender, MouseEventArgs e)
    {
        folder_button_MouseDown(sender, e);
    }

    private void greyscale_button_MouseDown(object sender, MouseEventArgs e)
    {
        Button clickedButton = sender as Button;
        clickedButton.BackgroundImage = Properties.Resources.oak_greyscale_dark;
        clickedButton.BackgroundImageLayout = ImageLayout.Tile;
        clickedButton.Cursor = Cursors.Hand;
        clickedButton.FlatStyle = FlatStyle.Flat;
        clickedButton.FlatAppearance.BorderColor = Color.FromArgb(44, 44, 42);
        clickedButton.FlatAppearance.BorderSize = 3;
    }
    private void greyscale_button_MouseUp(object sender, MouseEventArgs e)
    {
        Button clickedButton = sender as Button;
        clickedButton.BackgroundImage = Properties.Resources.oak_greyscale;
        clickedButton.BackgroundImageLayout = ImageLayout.Tile;
        clickedButton.Cursor = Cursors.Hand;
        clickedButton.FlatStyle = FlatStyle.Flat;
        clickedButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        clickedButton.FlatAppearance.BorderSize = 1;
    }
}


