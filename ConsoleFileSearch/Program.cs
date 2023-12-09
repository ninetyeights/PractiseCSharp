// Prompt the user to enter the directory path
Console.WriteLine("Enter the directory path to search: ");

// Read the user input and store it in the variable directory path
string? directoryPath = Console.ReadLine();

// Prompt the user to enter the file type (e.g., "txt")
Console.WriteLine("Enter the file type to filter (without the dot)");
string? fileType = Console.ReadLine();

// Construct the search pattern based on the specified file type
string searchPattern = $"*.{fileType}";

Console.WriteLine(Directory.Exists(directoryPath));
// Check if the directory exists
if (Directory.Exists(directoryPath))
{
    // Get file in the directory and its subdirectories based on the specified file type
    string[] files = Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);
    // check if files are round
    if (files.Length > 0)
    {
        // Display the message indicating that files are round
        Console.WriteLine($"List of {fileType} files in the directory and its subdirectories");
        // Loop through each file in the files array
        foreach (string filePath in files)
        {
            // Get file information
            FileInfo fileInfo = new FileInfo(filePath);

            // Display the details: size, creation date, and last modified date
            Console.WriteLine($"{Environment.NewLine}Path: {filePath}");
            Console.WriteLine($"Size: {fileInfo.Length} bytes");
            Console.WriteLine($"Creation date: {fileInfo.CreationTime}");
            Console.WriteLine($"Last modified date: {fileInfo.LastWriteTime}");
        }
    }
    else
    {
        // Display a message indicating that no files of the
        // specified file type are round
        Console.WriteLine($"{Environment.NewLine}No {fileType} files found in the directory and its subdirectories");
    }
}
else
{
    Console.WriteLine($"{Environment.NewLine}The Directory {directoryPath} does not exists");
}

// To keep the console window open until the user presses ENTER
Console.ReadLine();