namespace ConsoleApp1
{
    class FileInfoProvider
    {
        public void GetFileInfo(string path)
        {
            if (File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);
                Console.WriteLine($"Размер файла: {fileInfo.Length} байт");
                Console.WriteLine($"Дата создания: {fileInfo.CreationTime}");
                Console.WriteLine($"Дата последнего изменения: {fileInfo.LastWriteTime}");
            }
            else
            {
                Console.WriteLine($"Файл не существует: {path}");
            }
        }

        public bool CompareFilesBySize(string path1, string path2)
        {
            FileInfo file1 = new FileInfo(path1);
            FileInfo file2 = new FileInfo(path2);
            return file1.Length == file2.Length;
        }

        public void CheckFilePermissions(string path)
        {
            if (File.Exists(path))
            {
                var attributes = File.GetAttributes(path);
                Console.WriteLine($"Права доступа к файлу {path}:");
                Console.WriteLine($"Чтение: {(attributes.HasFlag(FileAttributes.ReadOnly) ? "Запрещено" : "Разрешено")}");
            }
            else
            {
                Console.WriteLine($"Файл не существует: {path}");
            }
        }
    }
}