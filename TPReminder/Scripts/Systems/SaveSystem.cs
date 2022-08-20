using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TaskReminder.Scripts.Systems
{
    public class Setting
    {
        public string Name;
        public dynamic Value;

        public Setting(string name, dynamic value)
        {
            Name = name;
            Value = value;
        }
    }

    public class SaveSystem
    {
        private static readonly string SettingsJsonPath = Application.StartupPath + "/Settings";
        private List<Setting> _settings = new List<Setting>();
        private List<string> _settingsJson = new List<string>();

        public SaveSystem()
        {
            Load();
        }
        
        public List<Setting> GetSettingsData()
        {
            return _settings;
        }

        public void AddSettingValue(string name, dynamic value)
        {
            var setting = _settings.FirstOrDefault(s => s.Name == name);
            if (setting != null)
                _settings.Remove(setting);
            
            _settings.Add(new Setting(name, value));
            Save();
        }

        public void Save()
        {
            _settingsJson = new List<string>();
            foreach (var setting in _settings)
            {
                _settingsJson.Add(JsonConvert.SerializeObject(setting, Formatting.Indented));
            }
            
            using (var file = File.CreateText(SettingsJsonPath))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, _settingsJson);
            }
        }
        
        private void Load()
        {
            if (!File.Exists(SettingsJsonPath)) return;
            using (var file = File.OpenText(SettingsJsonPath))
            {
                var serializer = new JsonSerializer();
                _settingsJson = (List<string>)serializer.Deserialize(file, typeof(List<string>));
                _settingsJson?.ForEach(s => _settings.Add(JsonConvert.DeserializeObject<Setting>(s)));
            }
        }
    }
}