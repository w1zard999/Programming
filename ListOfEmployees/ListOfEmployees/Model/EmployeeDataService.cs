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
        private static readonly string FilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EmployeeApp",
            "employees.json");

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
