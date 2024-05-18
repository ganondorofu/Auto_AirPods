using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // BluetoothClientを作成
                BluetoothClient client = new BluetoothClient();

                // 接続したいBluetoothデバイスのアドレス（例: "00:1A:7D:DA:71:11"）
                string deviceAddress = "80:95:3a:dc:39:6e";
                BluetoothAddress address = BluetoothAddress.Parse(deviceAddress);

                // デバイスへの接続
                BluetoothDeviceInfo deviceInfo = new BluetoothDeviceInfo(address);
                client.Connect(deviceInfo.DeviceAddress, BluetoothService.SerialPort);

                MessageBox.Show("接続成功！");
            }
            catch (Exception ex)
            {
                string i = ("接続失敗: " + ex.Message);
            }
        }
    }
}
