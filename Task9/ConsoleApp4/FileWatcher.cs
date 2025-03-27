using System;
using System.Diagnostics;
using System.IO;

public class FileWatcher
{
    private readonly FileSystemWatcher _fileSystemWatcher;
    private readonly string _directoryPath;

    public FileWatcher(string directoryPath)
    {
        _directoryPath = directoryPath;

        _fileSystemWatcher = new FileSystemWatcher
        {
            Path = _directoryPath,
            NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite,
            Filter = "*.*"
        };

        _fileSystemWatcher.Created += OnCreated;
        _fileSystemWatcher.Deleted += OnDeleted;
        _fileSystemWatcher.Changed += OnChanged;
        _fileSystemWatcher.Renamed += OnRenamed;

        _fileSystemWatcher.EnableRaisingEvents = true;
    }

    private void OnCreated(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл создан: {e.FullPath}");
        HandleDuplicateFiles(e.FullPath);
        LogActivity("Created", e.FullPath);
    }

    private void OnDeleted(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл удален: {e.FullPath}");
        LogActivity("Deleted", e.FullPath);
    }

    private void OnChanged(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл изменен: {e.FullPath}");
        LogActivity("Changed", e.FullPath);
    }

    private void OnRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine($"Файл переименован: {e.OldFullPath} -> {e.FullPath}");
        LogActivity("Renamed", e.FullPath);
    }

    private void HandleDuplicateFiles(string filePath)
    {
        if (File.Exists(filePath))
        {
            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath),
                Path.GetFileNameWithoutExtension(filePath) + "_copy" + Path.GetExtension(filePath));

            int count = 1;
            while (File.Exists(newFilePath))
            {
                newFilePath = Path.Combine(Path.GetDirectoryName(filePath),
                    Path.GetFileNameWithoutExtension(filePath) + $"_copy{count++}" + Path.GetExtension(filePath));
            }

            File.Copy(filePath, newFilePath);
            Console.WriteLine($"Создана копия: {newFilePath}");
        }
    }

    private void LogActivity(string action, string filePath)
    {
        string logPath = Path.Combine(_directoryPath, "log.txt");
        using (StreamWriter sw = new StreamWriter(logPath, true))
        {
            sw.WriteLine($"{DateTime.Now}: {action} - {filePath}");
        }
    }
}
