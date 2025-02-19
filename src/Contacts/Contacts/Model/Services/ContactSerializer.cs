using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Класс, предаставляющий методы для работы с памятью.
    /// </summary>
    internal static class ContactSerializer
    {
        /// <summary>
        /// Настройки сериализатора.
        /// </summary>
        static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings
        {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };
        /// <summary>
        /// Путь до каталога с сохранением.
        /// </summary>
        static string AppFolderPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");

        /// <summary>
        /// Сохранить данные.
        /// </summary>
        /// <param name="contact"></param>
        public static void Save(Contact contact)
        {
            File.WriteAllText(AppFolderPath + @"\contacts.json", JsonConvert.SerializeObject(contact, Formatting.Indented, Settings));
        }
        /// <summary>
        /// Загрузить данные.
        /// </summary>
        public static void Load()
        {
            Contact contact = new Contact();
            if (!Directory.Exists(AppFolderPath))
            {
                Directory.CreateDirectory(AppFolderPath);
            }

            if (File.Exists(AppFolderPath + @"\data.json"))
            {
                try
                {
                    Contact data = JsonConvert.DeserializeObject<Contact>(File.ReadAllText(AppFolderPath + @"\data.json"), Settings)!;
                    if (data != null) contact = data;
                }
                catch
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
