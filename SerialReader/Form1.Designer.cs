namespace SerialReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLog = new TextBox();
            MSForm1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem1 = new ToolStripMenuItem();
            carregarToolStripMenuItem1 = new ToolStripMenuItem();
            limparToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            txtTelegramReq = new TextBox();
            txtTelegramResExc = new TextBox();
            lblTelegram = new Label();
            lblResExpected = new Label();
            btnOpenPort = new Button();
            txtBaudRate = new TextBox();
            cmbPortName = new ComboBox();
            lblPortName = new Label();
            lblBaudRate = new Label();
            btnSendOneTelegram = new Button();
            lblParity = new Label();
            cmbParity = new ComboBox();
            btnRefresh = new Button();
            MSForm1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLog
            // 
            txtLog.Location = new Point(17, 48);
            txtLog.Margin = new Padding(4, 5, 4, 5);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(953, 582);
            txtLog.TabIndex = 0;
            // 
            // MSForm1
            // 
            MSForm1.ImageScalingSize = new Size(24, 24);
            MSForm1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, ajudaToolStripMenuItem });
            MSForm1.Location = new Point(0, 0);
            MSForm1.Name = "MSForm1";
            MSForm1.Padding = new Padding(9, 3, 0, 3);
            MSForm1.Size = new Size(1143, 35);
            MSForm1.TabIndex = 1;
            MSForm1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvarToolStripMenuItem1, carregarToolStripMenuItem1, limparToolStripMenuItem1, sairToolStripMenuItem1 });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(91, 29);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem1
            // 
            salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            salvarToolStripMenuItem1.Size = new Size(181, 34);
            salvarToolStripMenuItem1.Text = "Salvar";
            salvarToolStripMenuItem1.Click += salvarToolStripMenuItem1_Click;
            // 
            // carregarToolStripMenuItem1
            // 
            carregarToolStripMenuItem1.Name = "carregarToolStripMenuItem1";
            carregarToolStripMenuItem1.Size = new Size(181, 34);
            carregarToolStripMenuItem1.Text = "Carregar";
            carregarToolStripMenuItem1.Click += carregarToolStripMenuItem1_Click;
            // 
            // limparToolStripMenuItem1
            // 
            limparToolStripMenuItem1.Name = "limparToolStripMenuItem1";
            limparToolStripMenuItem1.Size = new Size(181, 34);
            limparToolStripMenuItem1.Text = "Limpar";
            limparToolStripMenuItem1.Click += limparToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(181, 34);
            sairToolStripMenuItem1.Text = "Sair";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem1_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(74, 29);
            ajudaToolStripMenuItem.Text = "Ajuda";
            ajudaToolStripMenuItem.Click += ajudaToolStripMenuItem_Click;
            // 
            // txtTelegramReq
            // 
            txtTelegramReq.Location = new Point(139, 643);
            txtTelegramReq.Margin = new Padding(4, 5, 4, 5);
            txtTelegramReq.Name = "txtTelegramReq";
            txtTelegramReq.Size = new Size(831, 31);
            txtTelegramReq.TabIndex = 2;
            txtTelegramReq.TextChanged += txtTelegramReq_TextChanged;
            // 
            // txtTelegramResExc
            // 
            txtTelegramResExc.Location = new Point(139, 692);
            txtTelegramResExc.Margin = new Padding(4, 5, 4, 5);
            txtTelegramResExc.Name = "txtTelegramResExc";
            txtTelegramResExc.Size = new Size(831, 31);
            txtTelegramResExc.TabIndex = 3;
            txtTelegramResExc.TextChanged += txtTelegramResExc_TextChanged;
            // 
            // lblTelegram
            // 
            lblTelegram.AutoSize = true;
            lblTelegram.Location = new Point(17, 648);
            lblTelegram.Margin = new Padding(4, 0, 4, 0);
            lblTelegram.Name = "lblTelegram";
            lblTelegram.Size = new Size(96, 25);
            lblTelegram.TabIndex = 4;
            lblTelegram.Text = "Telegrama:";
            // 
            // lblResExpected
            // 
            lblResExpected.AutoSize = true;
            lblResExpected.Location = new Point(17, 697);
            lblResExpected.Margin = new Padding(4, 0, 4, 0);
            lblResExpected.Name = "lblResExpected";
            lblResExpected.Size = new Size(121, 25);
            lblResExpected.TabIndex = 5;
            lblResExpected.Text = "Resposta Exp:";
            // 
            // btnOpenPort
            // 
            btnOpenPort.Location = new Point(980, 547);
            btnOpenPort.Margin = new Padding(4, 5, 4, 5);
            btnOpenPort.Name = "btnOpenPort";
            btnOpenPort.Size = new Size(146, 87);
            btnOpenPort.TabIndex = 6;
            btnOpenPort.Text = "Iniciar";
            btnOpenPort.UseVisualStyleBackColor = true;
            btnOpenPort.Click += btnOpenPort_Click;
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(977, 257);
            txtBaudRate.Margin = new Padding(4, 5, 4, 5);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(144, 31);
            txtBaudRate.TabIndex = 7;
            txtBaudRate.Text = "9600";
            // 
            // cmbPortName
            // 
            cmbPortName.FormattingEnabled = true;
            cmbPortName.Location = new Point(977, 183);
            cmbPortName.Margin = new Padding(4, 5, 4, 5);
            cmbPortName.Name = "cmbPortName";
            cmbPortName.Size = new Size(106, 33);
            cmbPortName.TabIndex = 8;
            // 
            // lblPortName
            // 
            lblPortName.AutoSize = true;
            lblPortName.Location = new Point(977, 153);
            lblPortName.Margin = new Padding(4, 0, 4, 0);
            lblPortName.Name = "lblPortName";
            lblPortName.Size = new Size(136, 25);
            lblPortName.TabIndex = 9;
            lblPortName.Text = "Nome da Porta:";
            // 
            // lblBaudRate
            // 
            lblBaudRate.AutoSize = true;
            lblBaudRate.Location = new Point(977, 227);
            lblBaudRate.Margin = new Padding(4, 0, 4, 0);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(91, 25);
            lblBaudRate.TabIndex = 10;
            lblBaudRate.Text = "Baud rate:";
            // 
            // btnSendOneTelegram
            // 
            btnSendOneTelegram.Enabled = false;
            btnSendOneTelegram.Location = new Point(980, 692);
            btnSendOneTelegram.Margin = new Padding(4, 5, 4, 5);
            btnSendOneTelegram.Name = "btnSendOneTelegram";
            btnSendOneTelegram.Size = new Size(146, 38);
            btnSendOneTelegram.TabIndex = 11;
            btnSendOneTelegram.Text = "Enviar";
            btnSendOneTelegram.UseVisualStyleBackColor = true;
            btnSendOneTelegram.Click += btnSendOneTelegram_Click;
            // 
            // lblParity
            // 
            lblParity.AutoSize = true;
            lblParity.Location = new Point(977, 302);
            lblParity.Margin = new Padding(4, 0, 4, 0);
            lblParity.Name = "lblParity";
            lblParity.Size = new Size(80, 25);
            lblParity.TabIndex = 13;
            lblParity.Text = "Paridade";
            // 
            // cmbParity
            // 
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(977, 332);
            cmbParity.Margin = new Padding(4, 5, 4, 5);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(147, 33);
            cmbParity.TabIndex = 14;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1085, 181);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(36, 35);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "R";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnRefresh);
            Controls.Add(cmbParity);
            Controls.Add(lblParity);
            Controls.Add(btnSendOneTelegram);
            Controls.Add(lblBaudRate);
            Controls.Add(lblPortName);
            Controls.Add(cmbPortName);
            Controls.Add(txtBaudRate);
            Controls.Add(btnOpenPort);
            Controls.Add(lblResExpected);
            Controls.Add(lblTelegram);
            Controls.Add(txtTelegramResExc);
            Controls.Add(txtTelegramReq);
            Controls.Add(MSForm1);
            Controls.Add(txtLog);
            MainMenuStrip = MSForm1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            MSForm1.ResumeLayout(false);
            MSForm1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLog;
        private MenuStrip MSForm1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem1;
        private ToolStripMenuItem carregarToolStripMenuItem1;
        private ToolStripMenuItem limparToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private TextBox txtTelegramReq;
        private TextBox txtTelegramResExc;
        private Label lblTelegram;
        private Label lblResExpected;
        private Button btnOpenPort;
        private TextBox txtBaudRate;
        private ComboBox cmbPortName;
        private Label lblPortName;
        private Label lblBaudRate;
        private Button btnSendOneTelegram;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private Label lblParity;
        private ComboBox cmbParity;
        private Button btnRefresh;
    }
}
