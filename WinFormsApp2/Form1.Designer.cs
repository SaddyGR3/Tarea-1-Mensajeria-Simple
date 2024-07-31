namespace WinFormsApp2
{
    partial class Tarea1
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
            textBoxIP = new TextBox();
            textBoxpuerto = new TextBox();
            textenvio = new TextBox();
            textrecibido = new TextBox();
            buttonenviar = new Button();
            buttonconectar = new Button();
            IPtext = new Label();
            labelpuerto = new Label();
            labelenvio = new Label();
            labelmsg = new Label();
            buttonconnect = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(85, 86);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(100, 23);
            textBoxIP.TabIndex = 0;
            // 
            // textBoxpuerto
            // 
            textBoxpuerto.Location = new Point(85, 122);
            textBoxpuerto.Name = "textBoxpuerto";
            textBoxpuerto.Size = new Size(100, 23);
            textBoxpuerto.TabIndex = 1;
            // 
            // textenvio
            // 
            textenvio.Location = new Point(33, 218);
            textenvio.Name = "textenvio";
            textenvio.Size = new Size(100, 23);
            textenvio.TabIndex = 2;
            // 
            // textrecibido
            // 
            textrecibido.Location = new Point(161, 218);
            textrecibido.Multiline = true;
            textrecibido.Name = "textrecibido";
            textrecibido.Size = new Size(193, 138);
            textrecibido.TabIndex = 3;
            // 
            // buttonenviar
            // 
            buttonenviar.Location = new Point(40, 247);
            buttonenviar.Name = "buttonenviar";
            buttonenviar.Size = new Size(75, 23);
            buttonenviar.TabIndex = 4;
            buttonenviar.Text = "Enviar";
            buttonenviar.UseVisualStyleBackColor = true;
            // 
            // buttonconectar
            // 
            buttonconectar.AccessibleRole = AccessibleRole.None;
            buttonconectar.Location = new Point(237, 86);
            buttonconectar.Name = "buttonconectar";
            buttonconectar.Size = new Size(75, 23);
            buttonconectar.TabIndex = 5;
            buttonconectar.Text = "Escuchar";
            buttonconectar.UseVisualStyleBackColor = true;
            // 
            // IPtext
            // 
            IPtext.AutoSize = true;
            IPtext.Location = new Point(38, 89);
            IPtext.Name = "IPtext";
            IPtext.Size = new Size(37, 15);
            IPtext.TabIndex = 6;
            IPtext.Text = "IPtext";
            // 
            // labelpuerto
            // 
            labelpuerto.AutoSize = true;
            labelpuerto.Location = new Point(33, 125);
            labelpuerto.Name = "labelpuerto";
            labelpuerto.Size = new Size(42, 15);
            labelpuerto.TabIndex = 7;
            labelpuerto.Text = "Puerto";
            // 
            // labelenvio
            // 
            labelenvio.AutoSize = true;
            labelenvio.Location = new Point(45, 191);
            labelenvio.Name = "labelenvio";
            labelenvio.Size = new Size(70, 15);
            labelenvio.TabIndex = 8;
            labelenvio.Text = "Msj a Enviar";
            // 
            // labelmsg
            // 
            labelmsg.AutoSize = true;
            labelmsg.Location = new Point(212, 191);
            labelmsg.Name = "labelmsg";
            labelmsg.Size = new Size(100, 15);
            labelmsg.TabIndex = 9;
            labelmsg.Text = "Mensaje Recibido";
            labelmsg.Click += labelmsg_Click;
            // 
            // buttonconnect
            // 
            buttonconnect.Location = new Point(237, 122);
            buttonconnect.Name = "buttonconnect";
            buttonconnect.Size = new Size(75, 23);
            buttonconnect.TabIndex = 10;
            buttonconnect.Text = "Conectar";
            buttonconnect.TextAlign = ContentAlignment.MiddleLeft;
            buttonconnect.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonconnect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Britannic Bold", 15F);
            label1.Location = new Point(59, 26);
            label1.Name = "label1";
            label1.Size = new Size(270, 23);
            label1.TabIndex = 11;
            label1.Text = "Mensajeria Simple Tarea 1";
            // 
            // Tarea1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 400);
            Controls.Add(label1);
            Controls.Add(buttonconnect);
            Controls.Add(labelmsg);
            Controls.Add(labelenvio);
            Controls.Add(labelpuerto);
            Controls.Add(IPtext);
            Controls.Add(buttonconectar);
            Controls.Add(buttonenviar);
            Controls.Add(textrecibido);
            Controls.Add(textenvio);
            Controls.Add(textBoxpuerto);
            Controls.Add(textBoxIP);
            Name = "Tarea1";
            Text = "Tarea1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIP;
        private TextBox textBoxpuerto;
        private TextBox textenvio;
        private TextBox textrecibido;
        private Button buttonenviar;
        private Button buttonconectar;
        private Label IPtext;
        private Label labelpuerto;
        private Label labelenvio;
        private Label labelmsg;
        private Button buttonconnect;
        private Label label1;
    }
}
