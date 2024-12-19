using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба____Телекомуникация_
{
    public partial class Form1 : Form
    {
        private ServerObject server;
        private ClientObject client;

        private string userName = "Клиент";
        private string serverName = "Сервер";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string role = textBoxRole.Text.Trim().ToLower();
            if (role == "s")
            {
                try
                {
                    server = new ServerObject(AppendTextToChat);

                    string inputServerName = textBoxUserName.Text.Trim();
                    if (!string.IsNullOrEmpty(inputServerName))
                    {
                        serverName = inputServerName;
                        server.ServerName = serverName;
                    }

                    Task.Run(() => server.Listen());
                    AppendTextToChat($"Сервер запущен... Хост {server.ServerName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка запуска сервера: {ex.Message}");
                }
            }
            else if (role == "c")
            {
                string ipAddress = textBoxIpAddress.Text.Trim();
                if (string.IsNullOrEmpty(ipAddress))
                {
                    MessageBox.Show("Введите IP-адрес сервера.");
                    return;
                }

                userName = textBoxUserName.Text.Trim();
                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("Введите имя пользователя.");
                    return;
                }

                try
                {
                    client = new ClientObject(ipAddress, 12345, userName, AppendTextToChat);
                    Task.Run(() => client.Connect());
                    AppendTextToChat("Подключение к серверу...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения к серверу: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Укажите корректную роль: 's' для сервера или 'c' для клиента.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role = textBoxRole.Text.Trim().ToLower();
            if (role == "s")
            {
                try
                {
                    string localIP = GetLocalIPAddress();
                    textBoxIpAddress.Text = localIP;
                    textBoxIpAddress.ReadOnly = true;
                    AppendTextToChat($"Ваш IP: {localIP}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка получения IP-адреса: {ex.Message}");
                }
            }
            else if (role == "c")
            {
                textBoxIpAddress.ReadOnly = false;
                MessageBox.Show("Введите IP-адрес сервера в поле IP.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, укажите корректную роль: 's' для сервера или 'c' для клиента.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string role = textBoxRole.Text.Trim().ToLower();
            if (role == "s")
            {
                server?.Disconnect();
                AppendTextToChat("Сервер остановлен.");
            }
            else if (role == "c")
            {
                client?.Close();
                AppendTextToChat("Клиент отключен.");
            }
            else
            {
                MessageBox.Show("Укажите корректную роль: 's' для сервера или 'c' для клиента.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string role = textBoxRole.Text.Trim().ToLower();
            string message = textBoxMessage.Text.Trim();
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Введите сообщение.");
                return;
            }

            if (role == "s")
            {
                string hostMessage = $"{serverName}: {message}";
                server.BroadcastMessage(hostMessage);
                AppendTextToChat(hostMessage);
                textBoxMessage.Clear();
            }
            else if (role == "c")
            {
                if (client != null && client.IsConnected)
                {
                    string fullMessage = $"{userName}: {message}";
                    client.SendMessage(fullMessage);
                    AppendTextToChat(fullMessage);
                    textBoxMessage.Clear();
                }
                else
                {
                    MessageBox.Show("Клиент не подключен к серверу.");
                }
            }
            else
            {
                MessageBox.Show("Укажите корректную роль: 's' для сервера или 'c' для клиента.");
            }
        }

        public void AppendTextToChat(string message)
        {
            if (textBoxChat.InvokeRequired)
            {
                textBoxChat.Invoke(new Action(() => textBoxChat.AppendText(message + Environment.NewLine)));
            }
            else
            {
                textBoxChat.AppendText(message + Environment.NewLine);
            }
        }


        private string GetLocalIPAddress()
        {
            string localIP = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            if (string.IsNullOrEmpty(localIP))
            {
                throw new Exception("Не удалось определить локальный IP-адрес.");
            }
            return localIP;
        }



        //----------------------------------------------------------------------//
        private void textBoxChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxIpAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    //------------------------------------------------------//
    public class ServerObject
    {
        private UdpClient udpServer;
        private Action<string> appendTextToChat;
        private IPEndPoint remoteEndPoint;
        private string logFilePath;

        public string ServerName { get; set; } = "Сервер";

        public ServerObject(Action<string> appendTextToChatCallback)
        {
            appendTextToChat = appendTextToChatCallback;

            string localIP = GetLocalIPAddress();
            udpServer = new UdpClient(new IPEndPoint(IPAddress.Parse(localIP), 12345));

            // Создаем файл для логирования
            logFilePath = $"{DateTime.Now:dd.MM.yyyy_HH-mm-ss}.txt";
            File.Create(logFilePath).Close();
        }

        public void Listen()
        {
            try
            {
                appendTextToChat($"Сервер запущен. Ожидание подключений...");

                while (true)
                {
                    byte[] receivedData = udpServer.Receive(ref remoteEndPoint);
                    string message = Encoding.UTF8.GetString(receivedData);

                    // Обработка сообщений
                    HandleIncomingMessage(message);
                }
            }
            catch (Exception ex)
            {
                appendTextToChat($"Ошибка сервера: {ex.Message}");
            }
            finally
            {
                Disconnect();
            }
        }

        private void HandleIncomingMessage(string message)
        {
            // Преобразование в двоичный вид
            string binaryMessage = string.Join(" ", Encoding.UTF8.GetBytes(message)
                .Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

            // Логирование сообщения в файл
            File.AppendAllText(logFilePath, $"{message}\n");

            // Отображение сообщения в разных форматах
            appendTextToChat($"Получено сообщение:\nЗакодированное: {message}\nДвоичное: {binaryMessage}\nДекодированное: {message}");

            // Пересылка сообщения всем подключенным клиентам
            BroadcastMessage(message);
        }

        public void BroadcastMessage(string message)
        {
            try
            {
                if (remoteEndPoint == null)
                {
                    appendTextToChat("Нет подключенных клиентов для отправки сообщения.");
                    return;
                }
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpServer.Send(data, data.Length, remoteEndPoint);
            }
            catch (Exception ex)
            {
                appendTextToChat($"Ошибка отправки сообщения: {ex.Message}");
            }
        }

        private string GetLocalIPAddress()
        {
            string localIP = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            if (string.IsNullOrEmpty(localIP))
            {
                throw new Exception("Не удалось определить локальный IP-адрес.");
            }
            return localIP;
        }

        public void Disconnect()
        {
            udpServer?.Close();
            appendTextToChat("Сервер остановлен.");
        }
    }


    public class ClientObject
    {
        private UdpClient udpClient;
        private IPEndPoint serverEndPoint;
        private string userName;
        private Action<string> appendTextToChat;

        public bool IsConnected { get; private set; } = false;

        public ClientObject(string serverIp, int port, string userName, Action<string> appendTextToChatCallback)
        {
            if (string.IsNullOrEmpty(serverIp))
                throw new ArgumentException("IP-адрес сервера не может быть пустым.", nameof(serverIp));
            if (port <= 0)
                throw new ArgumentException("Порт должен быть положительным числом.", nameof(port));

            this.userName = userName ?? "Anonymous";
            appendTextToChat = appendTextToChatCallback;

            udpClient = new UdpClient();
            serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIp), port);
            IsConnected = true;
        }

        public void Connect()
        {
            try
            {
                appendTextToChat("Подключение к серверу...");
                SendMessage($"{userName} подключился.");
            }
            catch (Exception ex)
            {
                appendTextToChat($"Ошибка при подключении: {ex.Message}");
                IsConnected = false;
            }
        }

        public void SendMessage(string message)
        {
            if (!IsConnected)
            {
                appendTextToChat("Клиент не подключен.");
                return;
            }

            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, serverEndPoint);
            }
            catch (Exception ex)
            {
                appendTextToChat($"Ошибка отправки сообщения: {ex.Message}");
            }
        }
        public void ReceiveMessage()
        {
            try
            {
                while (true)
                {
                    byte[] receivedData = udpClient.Receive(ref serverEndPoint);
                    string message = Encoding.UTF8.GetString(receivedData);

                    // Преобразование в двоичный вид
                    string binaryMessage = string.Join(" ", Encoding.UTF8.GetBytes(message)
                        .Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

                    // Вывод в разных форматах
                    appendTextToChat($"Закодированное: {message}\n Двоичное: {binaryMessage}\n Декодированное: {message}");
                }
            }
            catch (Exception ex)
            {
                appendTextToChat($"Ошибка получения сообщения: {ex.Message}");
            }
        }


        public void Close()
        {
            udpClient?.Close();
            IsConnected = false;
            appendTextToChat("Клиент отключен.");
        }

    }
}
