using System;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Monitor
{
    public class Scanner
    {
        public string DataToSend = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        public int offlineStat;

        public void doOnlineCheck(ListView devices)
        {
            foreach (ListViewItem item in devices.Items)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(DataToSend);
                int timeout = 120;

                Ping statusCheck = new Ping();
                PingReply reply = statusCheck.Send(item.SubItems[1].Text, timeout, buffer);

                if (reply.Status == IPStatus.Success)
                {
                    try
                    {
                        item.SubItems[2].Text = "Online.";
                    }
                    catch (Exception)
                    {
                        item.SubItems[2].Text = "Online.";
                    }
                }
                else
                {
                    try
                    {
                        item.SubItems[2].Text = "Offline.";
                    }
                    catch (Exception)
                    {
                        item.SubItems[2].Text = "Offline.";
                    }
                }
            }
        }
    }
}
