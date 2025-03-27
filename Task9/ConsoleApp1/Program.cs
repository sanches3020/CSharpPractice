using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            FileInfoProvider fileInfoProvider = new FileInfoProvider();

            string filePath = @"evmenova.sa.txt";
            string copyPath = @"evmenova.sa_copy.txt";
            string movedFilePath = @"new_directory\evmenova.sa_moved.txt";
            string renamedFilePath = @"familiya.io";

            fileManager.CreateFile(filePath, "Это тестовый файл.");
            fileInfoProvider.GetFileInfo(filePath);

            fileManager.DeleteFile(filePath); 

            fileManager.CreateFile(filePath, "Еще один тест.");
            fileInfoProvider.GetFileInfo(filePath);

            fileManager.CopyFile(filePath, copyPath);
            fileInfoProvider.GetFileInfo(copyPath);

            Directory.CreateDirectory(Path.GetDirectoryName(movedFilePath)); 
            fileManager.MoveFile(filePath, movedFilePath);

            fileManager.RenameFile(movedFilePath, renamedFilePath);

            try
            {
                fileManager.DeleteFile(@"non_existent_file.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            bool areFilesEqual = fileInfoProvider.CompareFilesBySize(renamedFilePath, copyPath);
            Console.WriteLine($"Размеры файлов одинаковы: {areFilesEqual}");

            string directoryPath = @"some_directory";
            Directory.CreateDirectory(directoryPath); 
            fileManager.DeleteFilesByPattern(directoryPath, "*.ii"); 

            fileManager.ListFiles(directoryPath);

            fileManager.PreventWrite(renamedFilePath);
            try
            {
                File.WriteAllText(renamedFilePath, "Попытка записи");
                Console.WriteLine("Запись успешна!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Не удалось записать в файл. Запись запрещена.");
            }

            fileInfoProvider.CheckFilePermissions(renamedFilePath);
        }
    }
}