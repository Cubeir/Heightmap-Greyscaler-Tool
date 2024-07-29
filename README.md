# Heightmap-Greyscaler-Tool
A simple utility to help you quickly greyscale images for Minecraft RTX.

Greyscaling images is often not possible and confusing when done through majority of image-editing apps, which simply turn the image grey without changing the Colorspace to 8-bit single-channel greyscale which is ideal and required for Minecraft with RTX, otherwise you may get errors.

Even using advanced image editing software like Adobe Photoshop is less than ideal when compared to this tool for two main reasons:
- Default settings of Photoshop cause unnecessary noise and dithering on Greyscaled images.
- Photoshop often slightly shifts and distorts the final color of image.

Thus this app was made to address those issues, making it the ideal method to greyscale images for Minecraft with RTX. HGT is faster at processing files in bulk.
  
  
### Function Info
- Images are flattened into a black background, as Minecraft RTX requires fully opaque images as Heightmaps
- Only TGA, PNG, JPG and JPEG images are supported and processed.
- If you happen to use conventional naming scheme, checking `Process '_heightmap' suffix only` will provide a layer of safety in case of an accident.
- `Search Subfolders` will enable recursive search for the selected folder.
- You can select both files and folders and process them at the same time, the lists aren't cleared until processing is done, becareful not to select a folder, then a file and assume the folder is now unselected, it is not!


## Trivia
The Heightmap Greyscaler was initially a small part of Vanilla RTX ToolSuite, a personal app I've developed over the years that contains many useful modules made specifically for Vanilla RTX and to help realise its goal.
I decided to turn it to a seperate app for fun, and to make it less destructive...

I once accidentally greyscaled entirety of Vanilla RTX and lost a good chunk of progress, scarred, I then started to take measures to avoid a similar event from happening ever again, including 3 realtime local backups on seperate drives and a cloud backup.
This module can hardly pose any harm now as there are several checks, a lot has to go wrong, the user has to be out of their mind for something catastrophic to happen.

I may now move on to creating a fork of Vanilla RTX ToolSuite dedicated to Minecraft RTX PBR texturing in general, which I believe to be the ultimate tool for achieving consistency with high precision and level of detail.
Think of usual means of creating PBR textures for Minecraft RTX as using a rusty kitchen knife, the ToolSuite is a surgeon's steel scalpel set. Don't butcher the art!
