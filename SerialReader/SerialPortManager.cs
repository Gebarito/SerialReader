using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialReader
{
    internal class SerialPortManager
    {
        private SerialPort _serialPort;
        public event EventHandler<string> TelegramReceived;

        public SerialPortManager(string portName, int baudRate)
        {
            _serialPort = new SerialPort(portName, baudRate);
            _serialPort.DataReceived += OnDataReceived;
        }

        public void Open() => _serialPort.Open();
        public void Close() => _serialPort.Close();

        public void SendTelegram(string telegram)
        {
            if (_serialPort.IsOpen)
                _serialPort.WriteLine(telegram);
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string message = _serialPort.ReadLine();
            TelegramReceived?.Invoke(this, message);
        }
    
    }
}
