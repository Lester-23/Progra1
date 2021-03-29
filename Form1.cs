using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Progra.Clases;

namespace Tarea_Progra
{
    public partial class Form1 : Form
    {
        ClsAutoMotor carrito;


        public Form1()
        {
            InitializeComponent();
        }

        private void buttoninicio_Click(object sender, EventArgs e)
        {


            buttonEncender.Visible = true;
            buttoninicio.Visible = false;
            buttonBMW.Visible = true;
            buttonToyota.Visible = true;
            button2.Visible = true;
            buttonP.Visible = true;
            buttonR.Visible = true;
            buttonN.Visible = true;
            buttonD.Visible = true;





        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            button1.Visible = true;

            if (carrito == null)
            {
                MessageBox.Show("Selecciona un carrito primero");
            }
            else
            {                
                labelEstadoVelocidad.Text = carrito.encender();
            }
            

        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Enciende el carro primero");
            }
            else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
            }
            

        }

        private void buttonBMW_Click(object sender, EventArgs e)
        {
                
            buttonAcelerar.Visible = true;
            buttonAltoTotal.Visible = true;
            buttonFrenar.Visible = true;
            

            MessageBox.Show("Llave insertada!");

            carrito = new ClsAutoMotor("BMW", 200, "NEGRO");
            carrito.color = "Negro";
            carrito.placa = "P 308CSH";

            MessageBox.Show($"El carro {carrito.marca} color {carrito.color} llega a {carrito.vel_max} KPH. " +
                   $"\nNúmero de placa '{carrito.placa}' \n\n\t'Es unicamente automatico'");            

        }

        private void buttonAltoTotal_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha();
        }

        private void buttonToyota_Click(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = true;
            buttonAltoTotal.Visible = true;
            buttonFrenar.Visible = true;

            MessageBox.Show("Llave insertada!");

            carrito = new ClsAutoMotor("Toyota", 150, "BLANCO");
            carrito.color = "Blanco";
            carrito.placa = "P 923CSH";

            MessageBox.Show($"El carro {carrito.marca} color {carrito.color} llega a {carrito.vel_max} KPH. " +
                   $"\nNúmero de placa '{carrito.placa}' \n\n\t'Es unicamente automatico'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Precaucion! Mientras conduces no utilices el estereo, " +
                    "ya que ver videos mientras vas en movimiento puede ser extremadamente peligroso.");

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                this.textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            buttonPause.Visible = true;
            buttonAnterior.Visible = true;
            buttonSiguiente.Visible = true;

            if (carrito == null)
            {
                MessageBox.Show("Enciende el carro primero");
            }
            else
            {                
                labelEstadoVelocidad.Text = carrito.inicio();
            }

            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Enciende el carro primero");
            }
            else
            {
                labelEstadoVelocidad.Text = carrito.frenar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Hora_Click(object sender, EventArgs e)
        {            
                       
        }

        private void labelEstadoVelocidad_Click(object sender, EventArgs e)
        {

        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Elije un carro primero");
            }
            else
            {
                labelPalanca.Text = carrito.P();
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Elije un carro primero");
            }
            else
            {
                labelPalanca.Text = carrito.R();
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Elije un carro primero");
            }
            else
            {
                labelPalanca.Text = carrito.N();
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Elije un carro primero");
            }
            else
            {
                labelPalanca.Text = carrito.D();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Hora.Text = DateTime.Now.ToString("h:mm:ss");
        }
    }
}
