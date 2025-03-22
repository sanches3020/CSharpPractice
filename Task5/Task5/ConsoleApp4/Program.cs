using ConsoleApp4;
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageManager storageManager = new StorageManager();

            CloudStorage cloudStorage = storageManager;
            cloudStorage.SaveData("Облачные данные");

            LocalStorage localStorage = storageManager;
            localStorage.SaveData("Локальные данные");
        }
    }
}