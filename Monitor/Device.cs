namespace Monitor
{
    public class Device
    {
        public string DeviceName { get; set; }
        public string DeviceIP { get; set; }
        public string DeviceDescription { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsOnline { get; set; }

        public int offlineBuffer;
    }
}
