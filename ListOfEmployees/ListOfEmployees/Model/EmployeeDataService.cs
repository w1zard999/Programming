using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace ListOfEmployees.Model
{
    public static class EmployeeDataService
    {
        /// <summary>
        /// Путь к файлу хранения данных сотрудников.
        /// </summary>
        private static readonly string FilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EmployeeApp",
            "employees.json");

        /// <summary>
        /// Сохраняет массив сотрудников в файл JSON.
        /// </summary>
        /// <param name="employees">Массив сотрудников для сохранения.</param>
        public static void Save(EmployeesInfo[] employees)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
                var options = new JsonSerializerOptions
                {
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All),
                    WriteIndented = true
                };
                string json = JsonSerializer.Serialize(employees, options);
                File.WriteAllText(FilePath, json, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        /// <summary>
        /// Загружает массив сотрудников из файла JSON.
        /// </summary>
        /// <returns>Массив сотрудников или пустой массив, если загрузка невозможна.</returns>
        public static EmployeesInfo[] Load()
        {
            if (!File.Exists(FilePath))
                return Array.Empty<EmployeesInfo>();

            try
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<EmployeesInfo[]>(json)
                       ?? Array.Empty<EmployeesInfo>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
                return Array.Empty<EmployeesInfo>();
            }
        }
    }
}
