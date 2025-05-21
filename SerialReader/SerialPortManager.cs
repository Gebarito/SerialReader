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

        public SerialPortManager(string portName, int baudRate, Parity parity)
        {
            _serialPort = new SerialPort(portName, baudRate, parity);
            _serialPort.DataReceived += OnDataReceived;
        }

        public void Open() => _serialPort.Open();
        public void Close() => _serialPort.Close();

        public void SendTelegram(string telegram)
        {
            if (!_serialPort.IsOpen)
                throw new InvalidOperationException("Serial port is not open.");
            if (telegram == "")
                throw new ArgumentException("Telegram cannot be empty.");

            _serialPort.WriteLine(telegram);
        }

        public string ReadTelegram()
        {
            if (!_serialPort.IsOpen)
                throw new InvalidOperationException("Serial port is not open.");

            return _serialPort.ReadLine();
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string message = _serialPort.ReadLine();
            TelegramReceived?.Invoke(this, message);
        }
    }
}
