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
            MSForm1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 29);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(668, 351);
            txtLog.TabIndex = 0;
            // 
            // MSForm1
            // 
            MSForm1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            MSForm1.Location = new Point(0, 0);
            MSForm1.Name = "MSForm1";
            MSForm1.Size = new Size(800, 24);
            MSForm1.TabIndex = 1;
            MSForm1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvarToolStripMenuItem1, carregarToolStripMenuItem1, limparToolStripMenuItem1, sairToolStripMenuItem1 });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem1
            // 
            salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            salvarToolStripMenuItem1.Size = new Size(119, 22);
            salvarToolStripMenuItem1.Text = "Salvar";
            salvarToolStripMenuItem1.Click += salvarToolStripMenuItem1_Click;
            // 
            // carregarToolStripMenuItem1
            // 
            carregarToolStripMenuItem1.Name = "carregarToolStripMenuItem1";
            carregarToolStripMenuItem1.Size = new Size(119, 22);
            carregarToolStripMenuItem1.Text = "Carregar";
            carregarToolStripMenuItem1.Click += carregarToolStripMenuItem1_Click;
            // 
            // limparToolStripMenuItem1
            // 
            limparToolStripMenuItem1.Name = "limparToolStripMenuItem1";
            limparToolStripMenuItem1.Size = new Size(119, 22);
            limparToolStripMenuItem1.Text = "Limpar";
            limparToolStripMenuItem1.Click += limparToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(119, 22);
            sairToolStripMenuItem1.Text = "Sair";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem1_Click;
            // 
            // txtTelegramReq
            // 
            txtTelegramReq.Location = new Point(97, 386);
            txtTelegramReq.Name = "txtTelegramReq";
            txtTelegramReq.Size = new Size(583, 23);
            txtTelegramReq.TabIndex = 2;
            txtTelegramReq.TextChanged += txtTelegramReq_TextChanged;
            // 
            // txtTelegramResExc
            // 
            txtTelegramResExc.Location = new Point(97, 415);
            txtTelegramResExc.Name = "txtTelegramResExc";
            txtTelegramResExc.Size = new Size(583, 23);
            txtTelegramResExc.TabIndex = 3;
            txtTelegramResExc.TextChanged += txtTelegramResExc_TextChanged;
            // 
            // lblTelegram
            // 
            lblTelegram.AutoSize = true;
            lblTelegram.Location = new Point(12, 389);
            lblTelegram.Name = "lblTelegram";
            lblTelegram.Size = new Size(64, 15);
            lblTelegram.TabIndex = 4;
            lblTelegram.Text = "Telegrama:";
            // 
            // lblResExpected
            // 
            lblResExpected.AutoSize = true;
            lblResExpected.Location = new Point(12, 418);
            lblResExpected.Name = "lblResExpected";
            lblResExpected.Size = new Size(79, 15);
            lblResExpected.TabIndex = 5;
            lblResExpected.Text = "Resposta Exp:";
            // 
            // btnOpenPort
            // 
            btnOpenPort.Location = new Point(686, 328);
            btnOpenPort.Name = "btnOpenPort";
            btnOpenPort.Size = new Size(102, 52);
            btnOpenPort.TabIndex = 6;
            btnOpenPort.Text = "Iniciar";
            btnOpenPort.UseVisualStyleBackColor = true;
            btnOpenPort.Click += btnOpenPort_Click;
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(684, 154);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(102, 23);
            txtBaudRate.TabIndex = 7;
            txtBaudRate.Text = "9600";
            // 
            // cmbPortName
            // 
            cmbPortName.FormattingEnabled = true;
            cmbPortName.Location = new Point(684, 110);
            cmbPortName.Name = "cmbPortName";
            cmbPortName.Size = new Size(104, 23);
            cmbPortName.TabIndex = 8;
            // 
            // lblPortName
            // 
            lblPortName.AutoSize = true;
            lblPortName.Location = new Point(684, 92);
            lblPortName.Name = "lblPortName";
            lblPortName.Size = new Size(90, 15);
            lblPortName.TabIndex = 9;
            lblPortName.Text = "Nome da Porta:";
            // 
            // lblBaudRate
            // 
            lblBaudRate.AutoSize = true;
            lblBaudRate.Location = new Point(684, 136);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(60, 15);
            lblBaudRate.TabIndex = 10;
            lblBaudRate.Text = "Baud rate:";
            // 
            // btnSendOneTelegram
            // 
            btnSendOneTelegram.Enabled = false;
            btnSendOneTelegram.Location = new Point(686, 415);
            btnSendOneTelegram.Name = "btnSendOneTelegram";
            btnSendOneTelegram.Size = new Size(102, 23);
            btnSendOneTelegram.TabIndex = 11;
            btnSendOneTelegram.Text = "Enviar";
            btnSendOneTelegram.UseVisualStyleBackColor = true;
            btnSendOneTelegram.Click += btnSendOneTelegram_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
