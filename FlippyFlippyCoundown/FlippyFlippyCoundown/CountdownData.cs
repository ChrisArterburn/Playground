using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippyFlippyCoundown
{
    public class CountdownData
    {
        public List<CountdownItem> Data { get; set; }

        public void DoUpdate()
        {
            foreach (var item in Data)
            {
                item.DoUpdate();
            }
        }

    }

    public class CountdownItem : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public DateTime EventTime { get; set; }

        public string Display 
        { 
            get
            {
                StringBuilder sb = new StringBuilder();

                List<string> pieces = new List<string>();

                TimeSpan eventTimespan = EventTime - DateTime.Now;

                if (eventTimespan > TimeSpan.Zero)
                {
                    if (eventTimespan.Days > 0) pieces.Add($"{eventTimespan.Days} days");
                    if (eventTimespan.Hours > 0) pieces.Add($"{eventTimespan.Hours} hours");
                    if (eventTimespan.Minutes > 0) pieces.Add($"{eventTimespan.Minutes} minutes");
                    if (eventTimespan.Seconds > 0) pieces.Add($"{eventTimespan.Seconds} seconds");

                    sb.Append(string.Join(", ", pieces));
                    sb.Append($" until {Name}");
                }
                else
                {
                    sb.Append($"{Name} has already happened");
                }


                return sb.ToString();
            } 
        }

        public void DoUpdate()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Display"));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    public class CountdownDataManager
    {
        public CountdownData Load(string fileName)
        {
            string jsonData = File.ReadAllText(fileName);

            CountdownData countdownData = JsonConvert.DeserializeObject<CountdownData>(jsonData);
            return countdownData;
        }


        public void Save(string fileName, CountdownData data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(fileName, jsonData);
        }
    }
}
