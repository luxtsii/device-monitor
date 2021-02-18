using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Monitor
{
    public static class LoadDevices
    {

        public static void InitDevices(ListView list, List<Device> devices)
        {
            list.Items.Clear();
            foreach (var device in devices)
            {
                ListView lV = list;
                string[] values = new string[3];

                values[0] = device.DeviceName;
                values[1] = device.DeviceIP;
                values[2] = "Connecting...";

                ListViewItem lvi = new ListViewItem(values);
                lV.Items.Add(lvi);
            }

        }

        public static void LoadAllDevices(ListView list)
        {
            List<Device> allDevices = new List<Device>();

            if (!File.Exists("devices.dvc"))
                return;

            string rawText = File.ReadAllText("devices.dvc");

            var Devices = JsonConvert.DeserializeObject<Device[]>(rawText);

            foreach (var device in Devices)
            {
                allDevices.Add(device);
            }

            InitDevices(list, allDevices);
        }
    }
}
