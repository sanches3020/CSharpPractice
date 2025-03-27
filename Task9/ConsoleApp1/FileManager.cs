namespace ConsoleApp1
{
    public class FileManager
    {
        public void CreateFile(string path, string content)
        {
            File.WriteAllText(path, content);
            Console.WriteLine($"Файл создан: {path}");
        }

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"Файл удален: {path}");
            } 
            else
            {
                Console.WriteLine($"Файл не существует: {path}");
            }
        }

        public void CopyFile(string sourcePath, string destinationPath)
        {
            File.Copy(sourcePath, destinationPath, true);
            Console.WriteLine($"Файл скопирован: {sourcePath} -> {destinationPath}");
        }

        public void MoveFile(string sourcePath, string destinationPath)
        {
            File.Move(sourcePath, destinationPath);
            Console.WriteLine($"Файл перемещён: {sourcePath} -> {destinationPath}");
        }

        public void RenameFile(string oldPath, string newPath)
        {
            File.Move(oldPath, newPath);
            Console.WriteLine($"Файл переименован: {oldPath} -> {newPath}");
        }

        public void DeleteFilesByPattern(string directory, string pattern)
        {
            var files = Directory.GetFiles(directory, pattern);
            foreach (var file in files)
            {
                File.Delete(file);
                Console.WriteLine($"Файл удален: {file}");
            }
        }

        public void ListFiles(string directory)
        {
            var files = Directory.GetFiles(directory);
            Console.WriteLine("Все файлы в директории:");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }

        public void PreventWrite(string path)
        {
            File.SetAttributes(path, FileAttributes.ReadOnly);
            Console.WriteLine($"Запись в файл запрещена: {path}");
        }
    }
}