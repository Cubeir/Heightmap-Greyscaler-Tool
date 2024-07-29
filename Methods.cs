using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Windows.Forms;
using ImageMagick;
namespace Heightmap_Greyscaler;

public class Methods
{
    public static void Greyscale(string imagePath)
    {
        try
        {
            MagickImage image = new MagickImage(imagePath);

            image.BackgroundColor = new MagickColor("#000000");
            image.Alpha(AlphaOption.Remove);
            image.ColorSpace = ColorSpace.Gray;

            Console.WriteLine($"Converting {imagePath} to greyscale...");
            image.Write(imagePath);
        }
        catch
        {
            
        }
    }
    public static void OpenFile(string filePath)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = filePath,
            UseShellExecute = true
        };
        Process process = new Process
        {
            StartInfo = startInfo
        };
        process.Start();
    }
}

