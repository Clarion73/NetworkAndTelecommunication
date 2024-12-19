namespace лаба____Телекомуникация_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Button buttonSend;


        /// <summary>
        /// Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">Указывает, нужно ли освобождать управляемые ресурсы.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelIpAddress = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(10, 30);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(100, 22);
            this.textBoxRole.TabIndex = 0;
            this.textBoxRole.TextChanged += new System.EventHandler(this.textBoxRole_TextChanged);
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(10, 80);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(150, 22);
            this.textBoxIpAddress.TabIndex = 1;
            this.textBoxIpAddress.TextChanged += new System.EventHandler(this.textBoxIpAddress_TextChanged);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(10, 130);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(150, 22);
            this.textBoxUserName.TabIndex = 2;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(10, 391);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(250, 22);
            this.textBoxMessage.TabIndex = 5;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(10, 172);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ReadOnly = true;
            this.textBoxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChat.Size = new System.Drawing.Size(360, 200);
            this.textBoxChat.TabIndex = 4;
            this.textBoxChat.TextChanged += new System.EventHandler(this.textBoxChat_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(270, 391);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 23);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(10, 10);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(186, 16);
            this.labelRole.TabIndex = 7;
            this.labelRole.Text = "Роль (s - сервер, c - клиент):";
            // 
            // labelIpAddress
            // 
            this.labelIpAddress.AutoSize = true;
            this.labelIpAddress.Location = new System.Drawing.Point(10, 60);
            this.labelIpAddress.Name = "labelIpAddress";
            this.labelIpAddress.Size = new System.Drawing.Size(65, 16);
            this.labelIpAddress.TabIndex = 8;
            this.labelIpAddress.Text = "IP-адрес:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(10, 110);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(132, 16);
            this.labelUserName.TabIndex = 9;
            this.labelUserName.Text = "Имя пользователя:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Подключение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(166, 79);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 11;
            this.button.Text = "IP адресс";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Отключение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(960, 500);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxIpAddress);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelIpAddress);
            this.Controls.Add(this.labelUserName);
            this.Name = "Form1";
            this.Text = "Чат";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelIpAddress;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button3;
    }
}
