﻿namespace TestWebSocketClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.gbLevel1 = new System.Windows.Forms.GroupBox();
            this.cmbL1DataFeeds = new System.Windows.Forms.ComboBox();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.txtL1Symbol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.cmbHDataFeeds = new System.Windows.Forms.ComboBox();
            this.numHBarCount = new System.Windows.Forms.NumericUpDown();
            this.cmbHPeriodicity = new System.Windows.Forms.ComboBox();
            this.txtHSymbol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetHistory = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.cmbSymbol = new System.Windows.Forms.ComboBox();
            this.cmbExpiry = new System.Windows.Forms.ComboBox();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAssets = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbSide = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCurPrice = new System.Windows.Forms.TextBox();
            this.cmbShortTermExpiry = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbOptionType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.gbLevel1.SuspendLayout();
            this.gbHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHBarCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(61, 55);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(157, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(157, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "user";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(61, 107);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(61, 3);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(157, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(61, 29);
            this.numPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(157, 20);
            this.numPort.TabIndex = 3;
            this.numPort.Value = new decimal(new int[] {
            20017,
            0,
            0,
            0});
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.txtHost);
            this.pnlLogin.Controls.Add(this.numPort);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Location = new System.Drawing.Point(12, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(224, 153);
            this.pnlLogin.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 169);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(981, 315);
            this.txtLog.TabIndex = 5;
            // 
            // gbLevel1
            // 
            this.gbLevel1.Controls.Add(this.cmbL1DataFeeds);
            this.gbLevel1.Controls.Add(this.btnUnsubscribe);
            this.gbLevel1.Controls.Add(this.txtL1Symbol);
            this.gbLevel1.Controls.Add(this.label6);
            this.gbLevel1.Controls.Add(this.btnSubscribe);
            this.gbLevel1.Controls.Add(this.label5);
            this.gbLevel1.Location = new System.Drawing.Point(242, 3);
            this.gbLevel1.Name = "gbLevel1";
            this.gbLevel1.Size = new System.Drawing.Size(386, 68);
            this.gbLevel1.TabIndex = 6;
            this.gbLevel1.TabStop = false;
            this.gbLevel1.Text = "Level 1";
            // 
            // cmbL1DataFeeds
            // 
            this.cmbL1DataFeeds.FormattingEnabled = true;
            this.cmbL1DataFeeds.Location = new System.Drawing.Point(69, 11);
            this.cmbL1DataFeeds.Name = "cmbL1DataFeeds";
            this.cmbL1DataFeeds.Size = new System.Drawing.Size(85, 21);
            this.cmbL1DataFeeds.TabIndex = 2;
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(97, 39);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(85, 23);
            this.btnUnsubscribe.TabIndex = 0;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // txtL1Symbol
            // 
            this.txtL1Symbol.Location = new System.Drawing.Point(207, 11);
            this.txtL1Symbol.Name = "txtL1Symbol";
            this.txtL1Symbol.Size = new System.Drawing.Size(85, 20);
            this.txtL1Symbol.TabIndex = 1;
            this.txtL1Symbol.Text = "GOOG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data Feed";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(6, 38);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(85, 23);
            this.btnSubscribe.TabIndex = 0;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Symbol";
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.cmbHDataFeeds);
            this.gbHistory.Controls.Add(this.numHBarCount);
            this.gbHistory.Controls.Add(this.cmbHPeriodicity);
            this.gbHistory.Controls.Add(this.txtHSymbol);
            this.gbHistory.Controls.Add(this.label10);
            this.gbHistory.Controls.Add(this.label8);
            this.gbHistory.Controls.Add(this.label9);
            this.gbHistory.Controls.Add(this.label7);
            this.gbHistory.Controls.Add(this.btnGetHistory);
            this.gbHistory.Location = new System.Drawing.Point(242, 77);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(386, 76);
            this.gbHistory.TabIndex = 6;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "History";
            // 
            // cmbHDataFeeds
            // 
            this.cmbHDataFeeds.FormattingEnabled = true;
            this.cmbHDataFeeds.Location = new System.Drawing.Point(67, 19);
            this.cmbHDataFeeds.Name = "cmbHDataFeeds";
            this.cmbHDataFeeds.Size = new System.Drawing.Size(85, 21);
            this.cmbHDataFeeds.TabIndex = 2;
            // 
            // numHBarCount
            // 
            this.numHBarCount.Location = new System.Drawing.Point(221, 45);
            this.numHBarCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHBarCount.Name = "numHBarCount";
            this.numHBarCount.Size = new System.Drawing.Size(69, 20);
            this.numHBarCount.TabIndex = 3;
            this.numHBarCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cmbHPeriodicity
            // 
            this.cmbHPeriodicity.FormattingEnabled = true;
            this.cmbHPeriodicity.Location = new System.Drawing.Point(67, 46);
            this.cmbHPeriodicity.Name = "cmbHPeriodicity";
            this.cmbHPeriodicity.Size = new System.Drawing.Size(85, 21);
            this.cmbHPeriodicity.TabIndex = 2;
            // 
            // txtHSymbol
            // 
            this.txtHSymbol.Location = new System.Drawing.Point(221, 19);
            this.txtHSymbol.Name = "txtHSymbol";
            this.txtHSymbol.Size = new System.Drawing.Size(69, 20);
            this.txtHSymbol.TabIndex = 1;
            this.txtHSymbol.Text = "GOOG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bars Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data Feed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Periodicity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Symbol";
            // 
            // btnGetHistory
            // 
            this.btnGetHistory.Location = new System.Drawing.Point(296, 16);
            this.btnGetHistory.Name = "btnGetHistory";
            this.btnGetHistory.Size = new System.Drawing.Size(85, 27);
            this.btnGetHistory.TabIndex = 0;
            this.btnGetHistory.Text = "Get History";
            this.btnGetHistory.UseVisualStyleBackColor = true;
            this.btnGetHistory.Click += new System.EventHandler(this.btnGetHistory_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(873, 138);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(120, 23);
            this.btnNewOrder.TabIndex = 7;
            this.btnNewOrder.Text = "NewOrder";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // cmbSymbol
            // 
            this.cmbSymbol.FormattingEnabled = true;
            this.cmbSymbol.Location = new System.Drawing.Point(694, 10);
            this.cmbSymbol.Name = "cmbSymbol";
            this.cmbSymbol.Size = new System.Drawing.Size(121, 21);
            this.cmbSymbol.TabIndex = 8;
            this.cmbSymbol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbExpiry
            // 
            this.cmbExpiry.FormattingEnabled = true;
            this.cmbExpiry.Location = new System.Drawing.Point(862, 10);
            this.cmbExpiry.Name = "cmbExpiry";
            this.cmbExpiry.Size = new System.Drawing.Size(131, 21);
            this.cmbExpiry.TabIndex = 9;
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Location = new System.Drawing.Point(695, 37);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderType.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(647, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Symbol";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(821, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Expiry";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnAssets
            // 
            this.btnAssets.Location = new System.Drawing.Point(873, 112);
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.Size = new System.Drawing.Size(120, 23);
            this.btnAssets.TabIndex = 13;
            this.btnAssets.Text = "Load Symbol";
            this.btnAssets.UseVisualStyleBackColor = true;
            this.btnAssets.Click += new System.EventHandler(this.btnAssets_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(631, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "OrderType";
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(694, 89);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(121, 21);
            this.cmbAccount.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(641, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Account";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(641, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Amount";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(694, 116);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(821, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Side";
            // 
            // cmbSide
            // 
            this.cmbSide.FormattingEnabled = true;
            this.cmbSide.Location = new System.Drawing.Point(862, 37);
            this.cmbSide.Name = "cmbSide";
            this.cmbSide.Size = new System.Drawing.Size(131, 21);
            this.cmbSide.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(620, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Current Price";
            // 
            // txtCurPrice
            // 
            this.txtCurPrice.Location = new System.Drawing.Point(695, 143);
            this.txtCurPrice.Name = "txtCurPrice";
            this.txtCurPrice.Size = new System.Drawing.Size(120, 20);
            this.txtCurPrice.TabIndex = 23;
            // 
            // cmbShortTermExpiry
            // 
            this.cmbShortTermExpiry.FormattingEnabled = true;
            this.cmbShortTermExpiry.Items.AddRange(new object[] {
            "30",
            "60",
            "120",
            "300"});
            this.cmbShortTermExpiry.Location = new System.Drawing.Point(903, 62);
            this.cmbShortTermExpiry.Name = "cmbShortTermExpiry";
            this.cmbShortTermExpiry.Size = new System.Drawing.Size(48, 21);
            this.cmbShortTermExpiry.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(821, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Short Term";
            // 
            // cmbOptionType
            // 
            this.cmbOptionType.FormattingEnabled = true;
            this.cmbOptionType.Location = new System.Drawing.Point(694, 62);
            this.cmbOptionType.Name = "cmbOptionType";
            this.cmbOptionType.Size = new System.Drawing.Size(121, 21);
            this.cmbOptionType.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(631, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Option Type";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 496);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbOptionType);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbShortTermExpiry);
            this.Controls.Add(this.txtCurPrice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbSide);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAssets);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.cmbExpiry);
            this.Controls.Add(this.cmbSymbol);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.gbHistory);
            this.Controls.Add(this.gbLevel1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.pnlLogin);
            this.Name = "MainForm";
            this.Text = "WebSocket Test Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.gbLevel1.ResumeLayout(false);
            this.gbLevel1.PerformLayout();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHBarCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox gbLevel1;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtL1Symbol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.ComboBox cmbL1DataFeeds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHDataFeeds;
        private System.Windows.Forms.NumericUpDown numHBarCount;
        private System.Windows.Forms.ComboBox cmbHPeriodicity;
        private System.Windows.Forms.TextBox txtHSymbol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetHistory;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.ComboBox cmbSymbol;
        private System.Windows.Forms.ComboBox cmbExpiry;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbSide;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCurPrice;
        private System.Windows.Forms.ComboBox cmbShortTermExpiry;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbOptionType;
        private System.Windows.Forms.Label label19;
    }
}

