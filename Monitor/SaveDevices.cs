using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Monitor
{
    public static class SaveDevices
    {
        public static void Save(List<Device> Devices)
        {
            string json = JsonConvert.SerializeObject(Devices);
            File.WriteAllText("devices.dvc", json);
        }
    }
}
