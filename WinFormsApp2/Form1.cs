using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private TcpListener listener;
        private NetworkStream stream;

        public Form1()
        {
            InitializeComponent();

            // Asignar eventos de clic a los métodos correspondientes
            buttonenviar.Click += buttonenviar_Click;
            buttonconectar.Click += buttonconectar_Click;
            buttonconnect.Click += buttonconnect_Click;
        }

        private async void StartListening()
        {
            listener = new TcpListener(IPAddress.Any, int.Parse(textBoxpuerto.Text));
            listener.Start();
            textrecibido.AppendText("Listening on port " + textBoxpuerto.Text + "\n");

            while (true)
            {
                var client = await listener.AcceptTcpClientAsync();
                _ = Task.Run(() => HandleClient(client));
            }
        }

        private async void HandleClient(TcpClient client)
        {
            var buffer = new byte[1024];
            using (var stream = client.GetStream())
            {
                int bytesRead;
                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Invoke((Action)(() => textrecibido.AppendText($"Received: {message}\n")));
                }
            }
        }

        private async void buttonenviar_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                var message = textenvio.Text;
                var data = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length);
                textrecibido.AppendText($"Sent: {message}\n");
            }
            else
            {
                textrecibido.AppendText("No connection established\n");
            }
        }

        private void buttonconectar_Click(object sender, EventArgs e)
        {
            StartListening();
        }

        private async void buttonconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(textBoxIP.Text, int.Parse(textBoxpuerto.Text));
                stream = client.GetStream();
                textrecibido.AppendText("Connected as client\n");
            }
            catch (Exception ex)
            {
                textrecibido.AppendText($"Connection failed: {ex.Message}\n");
            }
        }
    }
}
