# Heightmap-Greyscaler-Tool
A simple utility to help you quickly greyscale images for Minecraft RTX.

Greyscaling images through most image-editing apps can be confusing and often incorrect. These apps typically turn the image grey without changing the colorspace to the required single-channel (ideally 8-bit) greyscale needed for Minecraft with RTX, potentially causing errors.

Even advanced image editing software like Adobe Photoshop has its drawbacks:
- With default settings, Photoshop can introduce unnecessary noise and dithering in greyscaled images.
- Photoshop often unavoidably shifts the final colors of the image depending on the software the heightmap was created or edited with.

Heightmap Greyscaler Tool offers an efficient way to greyscale images for Minecraft RTX without any darkbacks and won't unnecessarily alter the input.


![AppImage](https://github.com/user-attachments/assets/aca2bda5-f8e4-4a2d-aeae-1cfc56df4a15)

## Functionality Information
- Requires [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Images are flattened into a black background, Minecraft RTX requires fully opaque images for Heightmaps as even a single slightly transparent pixel will cause an error.
- Only TGA, PNG, JPG/JPEG images supported by Minecraft are processed.
- If you happen to use the conventional naming scheme for your PBR textures (such as ones generated using [TSMaker](https://github.com/Cubeir/Texture-Set-Maker)), check `Process '_heightmap' suffix only` for a layer of safety against accidentally greyscaling other textures.
- `Search Subfolders` option enables a recursive search within the selected folder.
- You can select files and folders simultaneously and process them at the same time, the selected files are not cleared until processing is done, becareful not to select a folder then a file and assume the folder is now unselected, it is not.

  
  

## Trivia
The Heightmap Greyscaler was initially a small component of the Vanilla RTX ToolSuite, a personal application I have developed over the years. This suite contains numerous useful modules specifically designed to support the goals of Vanilla RTX.

I decided to turn the Heightmap Greyscaler into a separate app as a fun experiment and to reduce its potential for accidental data loss. In the past, I have inadvertently greyscaled the entirety of Vanilla RTX, scarred, I started to take measures to avoid a similar event from happening ever again, including 3 realtime local backups on seperate drives and a cloud backup.
This module can hardly pose any harm now as there are several checks, a lot has to go wrong, the user has to be extraordinarily negligent for something catastrophic to happen.

Looking ahead, I plan to create a fork of the Vanilla RTX ToolSuite dedicated to Minecraft RTX PBR texturing in general, which I believe to be the ultimate tool for achieving consistency with high precision and level of detail.
Think of usual means of creating PBR textures for Minecraft RTX as using a rusty kitchen knife, whereas the ToolSuite is like a surgeon's set of steel scalpels.
Don't butcher the art!
