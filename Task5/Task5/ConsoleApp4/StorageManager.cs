using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class StorageManager : CloudStorage, LocalStorage
    {
     
        void CloudStorage.SaveData(string data)
        {
            Console.WriteLine($"Данные сохранены в облаке: {data}");
        }

        void LocalStorage.SaveData(string data)
        {
            Console.WriteLine($"Данные сохранены локально: {data}");
        }
    }
}