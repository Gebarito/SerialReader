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

            cmbParity.DataSource = Parity.GetNames(typeof(Parity));

            loadCOMPorts();
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (_portManager == null)
                _portManager = new SerialPortManager(
                    cmbPortName.Text,
                    Convert.ToInt32(txtBaudRate.Text),
                    Enum.TryParse<Parity>(cmbParity.Text, out Parity parity) ? parity : Parity.None
                 );

            try
            {
                _portManager.Open();
                _portManager.TelegramReceived += OnTelegramReceived;
                _telegramHandler = new TelegramHandler();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao iniciar comunicação: {ex.Message}",
                    "Erro ao abrir porta de comunicação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
                if (_currentTelegram != null)
                {
                    _portManager.SendTelegram(_currentTelegram.Command);
                    Log($"Enviado: {_currentTelegram.Command}");
                }
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
            var msg = MessageBox.Show("Deseja salvar antes de sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK;
            if (msg)
                SaveFile();
            if (_portManager != null)
                _portManager.Close();

            Environment.Exit(0);
        }

        private void SaveFile()
        {
            using SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.Title = "Salvar Arquivo";

            /*
             * Defines the name of the file "log_date:hour:minute:second.txt"
             */
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
                    MessageBox.Show(
                        "Erro ao salvar arquivo: " + ex.Message,
                        "Erro salvando arquivo de texto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnSendOneTelegram_Click(object sender, EventArgs e)
        {
            Telegram _telegram = new();

            _telegram.Command = txtTelegramReq.Text;
            _telegram.ExpectedResponse = txtTelegramResExc.Text;

            SerialPortManager _spManager = new SerialPortManager(
                    cmbPortName.Text,
                    Convert.ToInt32(txtBaudRate.Text),
                    Enum.TryParse<Parity>(cmbParity.Text, out Parity parity) ? parity : Parity.None
            );

            try
            {
                _spManager.Open();
                _spManager.SendTelegram(_telegram.Command);
                Log($"Enviado: {_telegram.Command}");

                string response = _spManager.ReadTelegram();
                string validateResponse = _telegram.ValidateResponse(response) ? "OK" : "Não correspondente";

                Log($"Recebido: {response}: {validateResponse}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao iniciar comunicação: {ex.Message}",
                    "Erro abrindo porta de comunicação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void txtTelegramReq_TextChanged(object sender, EventArgs e) => this.txtTelegramReq.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
        private void txtTelegramResExc_TextChanged(object sender, EventArgs e) => this.txtTelegramResExc.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
        private void TextBoxes_TextChanged(object sender, EventArgs e) => btnSendOneTelegram.Enabled = txtTelegramReq.TextLength > 0 && txtTelegramResExc.TextLength > 0;
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e) => showHelp();
        private void btnRefresh_Click(object sender, EventArgs e) => loadCOMPorts();

        private void showHelp()
        {
            string helpMessage = "Serial Reader\n\n" +
            "1. Conecte a porta com desejada.\n" +
            "2. Carregue um arquivo CSV com os telegramas a serem enviados e as respostas esperadas\n" +
            "3. Você pode enviar um telegrama único usando os campos de texto abaixo do log\n" +
            "4. Monitore o log dos telegramas recebidos e enviados\n" +
            "5. Salve o log se desejar.\n";
            MessageBox.Show(helpMessage, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadCOMPorts()
        {
            cmbPortName.DataSource = SerialPort.GetPortNames();
            if (cmbPortName.Items.Count < 1)
            {
                cmbPortName.Text = "COM3";
            }
        }
    }

}
