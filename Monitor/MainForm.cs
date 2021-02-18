using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Monitor
{
    public partial class MainForm : Form
    {
        public Scanner scanner;
        public static float containerToFormSize;
        List<Device> deviceList = new List<Device>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResizeAccordingly(this);
            scanner = new Scanner();
            InitTimer();

            LoadDevices.LoadAllDevices(deviceContainer);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            ResizeAccordingly(this);
        }

        void ResizeAccordingly(Control cont)
        {
            Control control = (Control)this;

            foreach (ColumnHeader c in deviceContainer.Columns)
            {
                c.Width = deviceContainer.Width / 3;
            }
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 30000; // 30 seconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scanner.doOnlineCheck(deviceContainer);
        }

        private void newDeviceButton_Click(object sender, EventArgs e)
        {
            Device brandNewDevice = new Device()
            {
                DeviceName = nameBox.Text,
                DeviceIP = addressBox.Text,
                DeviceDescription = descBox.Text
            };

            nameBox.Text = "";
            addressBox.Text = "";
            descBox.Text = "";

            deviceList.Add(brandNewDevice);

            brandNewDevice = null;

            SaveDevices.Save(deviceList);
            LoadDevices.InitDevices(deviceContainer, deviceList);
        }
    }
}
