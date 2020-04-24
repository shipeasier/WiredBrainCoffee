using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Storage
{
    public class CoffeeMachineStateSaver
    {
        private string _filename = "machine.json";

        public void Save(CoffeeMachineState state)
        {
            var json = JsonConvert.SerializeObject(state);
            File.WriteAllText(_filename, json);
        }

        public CoffeeMachineState Load()
        {
            if (File.Exists(_filename))
            {
                var json = File.ReadAllText(_filename);
                return JsonConvert.DeserializeObject<CoffeeMachineState>(json);
            }
            return new CoffeeMachineState();
        }

        public void ShowStoredJson()
        {
            var json = File.Exists(_filename) ? File.ReadAllText(_filename) : "<empty>";
#if NETSTANDARD1_3
      Console.WriteLine($"Stored JSON: {json}");
#elif NET461
            var window = new System.Windows.Window
            {
                Title = "Stored Json",
                Content = json,
                WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen,
                FontSize = 20,
                Width = 300,
                Height = 300
            };
            window.Show();
#endif
            }
    }
}
