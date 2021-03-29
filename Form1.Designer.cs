
namespace Tarea_Progra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttoninicio = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonBMW = new System.Windows.Forms.Button();
            this.buttonAltoTotal = new System.Windows.Forms.Button();
            this.buttonToyota = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.Hora = new System.Windows.Forms.Label();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.labelPalanca = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoninicio
            // 
            this.buttoninicio.Location = new System.Drawing.Point(42, 38);
            this.buttoninicio.Name = "buttoninicio";
            this.buttoninicio.Size = new System.Drawing.Size(151, 60);
            this.buttoninicio.TabIndex = 0;
            this.buttoninicio.Text = "Crear Carro";
            this.buttoninicio.UseVisualStyleBackColor = true;
            this.buttoninicio.Click += new System.EventHandler(this.buttoninicio_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.AllowDrop = true;
            this.buttonEncender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.ForeColor = System.Drawing.Color.Black;
            this.buttonEncender.Location = new System.Drawing.Point(12, 249);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(214, 66);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Encender / Apagar Carrito ";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Visible = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(42, 348);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(154, 61);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Visible = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(646, 22);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(79, 29);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "label1";
            this.labelEstadoVelocidad.Click += new System.EventHandler(this.labelEstadoVelocidad_Click);
            // 
            // buttonBMW
            // 
            this.buttonBMW.Location = new System.Drawing.Point(42, 121);
            this.buttonBMW.Name = "buttonBMW";
            this.buttonBMW.Size = new System.Drawing.Size(151, 33);
            this.buttonBMW.TabIndex = 5;
            this.buttonBMW.Text = "BMW";
            this.buttonBMW.UseVisualStyleBackColor = true;
            this.buttonBMW.Visible = false;
            this.buttonBMW.Click += new System.EventHandler(this.buttonBMW_Click);
            // 
            // buttonAltoTotal
            // 
            this.buttonAltoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltoTotal.ForeColor = System.Drawing.Color.Red;
            this.buttonAltoTotal.Location = new System.Drawing.Point(220, 571);
            this.buttonAltoTotal.Name = "buttonAltoTotal";
            this.buttonAltoTotal.Size = new System.Drawing.Size(176, 73);
            this.buttonAltoTotal.TabIndex = 6;
            this.buttonAltoTotal.Text = "Freno de Mano!";
            this.buttonAltoTotal.UseVisualStyleBackColor = true;
            this.buttonAltoTotal.Visible = false;
            this.buttonAltoTotal.Click += new System.EventHandler(this.buttonAltoTotal_Click);
            // 
            // buttonToyota
            // 
            this.buttonToyota.Location = new System.Drawing.Point(42, 178);
            this.buttonToyota.Name = "buttonToyota";
            this.buttonToyota.Size = new System.Drawing.Size(151, 36);
            this.buttonToyota.TabIndex = 7;
            this.buttonToyota.Text = "Toyota";
            this.buttonToyota.UseVisualStyleBackColor = true;
            this.buttonToyota.Visible = false;
            this.buttonToyota.Click += new System.EventHandler(this.buttonToyota_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(416, 204);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(436, 244);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea_Progra.Properties.Resources.radiojpg;
            this.pictureBox1.Location = new System.Drawing.Point(447, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 636);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1200, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Elegir Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(577, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(770, 618);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(718, 22);
            this.textBox1.TabIndex = 13;
            // 
            // buttonPause
            // 
            this.buttonPause.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPause.Location = new System.Drawing.Point(958, 618);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(148, 40);
            this.buttonPause.TabIndex = 14;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAnterior.Location = new System.Drawing.Point(677, 678);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(147, 40);
            this.buttonAnterior.TabIndex = 15;
            this.buttonAnterior.Text = "Previous";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Visible = false;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSiguiente.Location = new System.Drawing.Point(873, 678);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(148, 40);
            this.buttonSiguiente.TabIndex = 16;
            this.buttonSiguiente.Text = "Next";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Visible = false;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.Location = new System.Drawing.Point(42, 438);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(155, 61);
            this.buttonFrenar.TabIndex = 17;
            this.buttonFrenar.Text = "Bajar Velocidad / Freno";
            this.buttonFrenar.UseVisualStyleBackColor = true;
            this.buttonFrenar.Visible = false;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(925, 125);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(69, 29);
            this.Hora.TabIndex = 18;
            this.Hora.Text = "Time";
            this.Hora.Click += new System.EventHandler(this.Hora_Click);
            // 
            // buttonP
            // 
            this.buttonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonP.Location = new System.Drawing.Point(283, 264);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(53, 50);
            this.buttonP.TabIndex = 19;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Visible = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonR
            // 
            this.buttonR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonR.Location = new System.Drawing.Point(283, 335);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(53, 50);
            this.buttonR.TabIndex = 20;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Visible = false;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonN
            // 
            this.buttonN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.ForeColor = System.Drawing.Color.Green;
            this.buttonN.Location = new System.Drawing.Point(283, 407);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(53, 50);
            this.buttonN.TabIndex = 21;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Visible = false;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonD.Location = new System.Drawing.Point(284, 484);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(52, 50);
            this.buttonD.TabIndex = 22;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Visible = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // labelPalanca
            // 
            this.labelPalanca.AutoSize = true;
            this.labelPalanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalanca.Location = new System.Drawing.Point(239, 22);
            this.labelPalanca.Name = "labelPalanca";
            this.labelPalanca.Size = new System.Drawing.Size(106, 29);
            this.labelPalanca.TabIndex = 23;
            this.labelPalanca.Text = "Palanca";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(946, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPalanca);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonToyota);
            this.Controls.Add(this.buttonAltoTotal);
            this.Controls.Add(this.buttonBMW);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttoninicio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninicio;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonBMW;
        private System.Windows.Forms.Button buttonAltoTotal;
        private System.Windows.Forms.Button buttonToyota;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label labelPalanca;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

