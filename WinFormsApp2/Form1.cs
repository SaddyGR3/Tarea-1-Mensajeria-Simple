using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class Tarea1 : Form
    {
        private TcpClient client; //Ciente TCP para conectarse
        private TcpListener listener; //Servidor TCP que escucha conexiones entrantes
        private NetworkStream stream; //Red para enviar y recibir mensajes

        public Tarea1()
        {
            InitializeComponent();

            //Eventos de los botones
            buttonenviar.Click += buttonenviar_Click;
            buttonconectar.Click += buttonconectar_Click;
            buttonconnect.Click += buttonconnect_Click;
        }

        private async void StartListening()
        {
            listener = new TcpListener(IPAddress.Any, int.Parse(textBoxpuerto.Text)); //Empieza a escuchar conexiones entrantes en el puerto que se puso
            listener.Start(); //Empieza a escuchar
            textrecibido.AppendText($"Escuchando en el Puerto " + textBoxpuerto.Text + "\n");

            while (true)
            {
                var client = await listener.AcceptTcpClientAsync();  //Acepta la conexion entrante
                _ = Task.Run(() => HandleClient(client)); //Se lleva la conexion del cliente a un hilo separado
            }
        }

        private async void HandleClient(TcpClient client)
        {
            var buffer = new byte[1024];//Buffer para recibir datos
            using (var stream = client.GetStream()) //Obtiene el flujo de red para la conexión del cliente
            {
                int bytesRead;
                while ((bytesRead = await stream.ReadAsync(buffer,0,buffer.Length)) != 0)
                {
                    var message = Encoding.UTF8.GetString(buffer,0,bytesRead);//Convierte los bytes en texto
                    Invoke((Action)(() => textrecibido.AppendText($"Recibido: {message}\n"))); //Muestra el mensaje recibido en el textbox
                }
            }
        }

        private async void buttonenviar_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected) //Verifica si el cliente esta conectado antes de enviar un msj.
            {
                var message = textenvio.Text; //Obtiene el mensaje para enviar
                var data = Encoding.UTF8.GetBytes(message); //Lo codifica en bytes
                await stream.WriteAsync(data,0,data.Length);  //Envía el mensaje
                textrecibido.AppendText($"Enviado:{message}\n"); //muestra el mensaje enviado
            }
            else
            {
                textrecibido.AppendText("No se logro conectar\n");
            }
        }

        private void buttonconectar_Click(object sender, EventArgs e)
        {
            StartListening(); //Empieza a escuchar 
        }

        private async void buttonconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(textBoxIP.Text, int.Parse(textBoxpuerto.Text)); //Crea una instancia de TcpClient y se conecta al servidor especificado
                stream = client.GetStream(); //Obtiene el flujo de red
                textrecibido.AppendText($"Conectado como cliente\n"); //Muestra si la conexion es exitosa
            }
            catch (Exception ex)
            {
                textrecibido.AppendText($"Conexion Fallada: {ex.Message}\n");//Notifica si la conexion falla
            }
        }
        private void labelmsg_Click(object sender, EventArgs e)
        {
            //s
        }
    }
}
