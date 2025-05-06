using System.IO.Ports;

namespace SerialReader
{
    public partial class Form1 : Form
    {
        private SerialPortManager _portManager;
        private TelegramHandler _telegramHandler;
        private Telegram? _currentTelegram;

        public Form1()
        {
            InitializeComponent();

            cmbPortName.DataSource = SerialPort.GetPortNames();
            if (cmbPortName.Items.Count < 1)
            {
                cmbPortName.Text = "COM3";
            }
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (_portManager == null)
                _portManager = new SerialPortManager(cmbPortName.Text, Convert.ToInt32(txtBaudRate.Text));

            try
            {
                _portManager.Open();
                _portManager.TelegramReceived += OnTelegramReceived;
                _telegramHandler = new TelegramHandler();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar comunicação: {ex.Message}");
            }

        }

        private void carregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _telegramHandler.LoadFromCsv(ofd.FileName);
                SendNextTelegram();
            }
        }

        private void SendNextTelegram()
        {
            if (_telegramHandler.HasTelegram)
            {
                _currentTelegram = _telegramHandler.GetNextTelegram();
                _portManager.SendTelegram(_currentTelegram.Command);
                Log($"ENVIADO: {_currentTelegram.Command}");
            }
        }

        private void OnTelegramReceived(object? sender, string response)
        {
            Invoke(() =>
            {
                Log($"Recebido: {response}");

                if (_currentTelegram != null)
                {
                    bool isValid = _currentTelegram.ValidateResponse(response);
                    string validation = (isValid ? "Ok" : "Resposta diferente da esperada");
                    Log($"Recebido: {response}:{validation}");
                    _currentTelegram = null;
                    SendNextTelegram();
                }

            });
        }

        private void Log(string message)
        {
            txtLog.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void limparToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile();
            Environment.Exit(0);
        }

        private void SaveFile()
        {
            using SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.Title = "Salvar Arquivo";

            string format = "ddmmyyyy:hhmmsstt";
            string _filename = "log_" + String.Format("{0}.txt", DateTime.Now.ToString(format));
            sfd.FileName = _filename;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter writer = new StreamWriter(sfd.FileName);
                    writer.Write(txtLog.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar arquivo: " + ex.Message);
                }
            }

        }


        private void btnSendOneTelegram_Click(object sender, EventArgs e)
        {
            // Envia apenas um telegrama
            //txtTelegramReq.Text;
            //txtTelegramResExc.Text;
            Log($"Enviado:{txtTelegramReq.Text}");
        }

        private void txtTelegramReq_TextChanged(object sender, EventArgs e)
        {
            this.txtTelegramReq.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
        }

        private void txtTelegramResExc_TextChanged(object sender, EventArgs e)
        {
            this.txtTelegramResExc.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            btnSendOneTelegram.Enabled = txtTelegramReq.TextLength > 0 &&
                txtTelegramResExc.TextLength > 0;
        }

    }

}
