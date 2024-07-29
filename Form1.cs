using System;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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

        InitializeProgressBar(allFilePaths.Count);

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

        await ProcessFilesAsync(allFilePaths);

        selectedFolderPath = string.Empty;
        selectedFilePaths.Clear();

        SystemSounds.Asterisk.Play();
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


    /// - - - - Progress Bar - - - - ///
    private void InitializeProgressBar(int totalItemCount)
    {
        if (totalItemCount > 0)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = totalItemCount;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
        }
    }
    private async Task ProcessFilesAsync(List<string> files)
    {
        foreach (var filePath in files)
        {
            await Task.Run(() => Methods.Greyscale(filePath));
            UpdateProgressBar();
        }
        ResetProgressBar();
    }
    private void UpdateProgressBar()
    {
        if (progressBar1.InvokeRequired)
        {
            progressBar1.Invoke((Action)UpdateProgressBar);
        }
        else
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
        }
    }
    private void ResetProgressBar()
    {
        if (progressBar1.InvokeRequired)
        {
            progressBar1.Invoke((Action)ResetProgressBar);
        }
        else
        {
            progressBar1.Value = 0;
        }
    }
}


