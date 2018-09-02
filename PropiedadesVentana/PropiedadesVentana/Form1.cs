using System;
using System.Drawing;
using System.Windows.Forms;

namespace PropiedadesVentana
{
    public partial class Form1 : Form
    {
        double altura = 0;
        double peso = 0;
        double potencia = 0;
        const double g = 9.8;
        // BigInteger nepe = "5678998764567890"; no agarra este nepe, solo falta que esté obsoleto ya. voy a leer.
        Timer aTimer;
        public Form1()
        {
            InitializeComponent();
            buttonDetener.Enabled = false;
            trackBarPropulsor.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAltura_TextChanged(object sender, EventArgs e)
        {
            try
            {
                altura = Convert.ToDouble(textBoxAltura.Text);
                if (altura > 270)
                {
                    MessageBox.Show("La altura máxima es de 270 metros");
                    textBoxAltura.Text = "270";//
                }
            }
            catch (Exception)
            {
                
                altura = 270;
            }
            
        }

        private void textBoxPeso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                peso = Convert.ToDouble(textBoxPeso.Text);
            }
            catch (Exception)
            {
                peso = 0;
            }
            
            //labelVelocidadOculto.Text = Convert.ToString(peso);//Asignar una variable a un label
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelPotencia.Text = Convert.ToString(((peso*g)/100)*trackBarPropulsor.Value);
            potencia = Convert.ToDouble(trackBarPropulsor.Value);
        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar solo números en textBox Altura
            if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
            else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
            else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
            else
                {
                    e.Handled = true;
                }
        }

        private void textBoxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar solo números en textBox Peso
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void labelTrackBar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmpezar_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBoxAltura.Text=="" && textBoxPeso.Text=="") {//QUé error tan nep
                MessageBox.Show("Introduce valores para poder empezar");
                return;
            }
            textBoxAltura.Enabled = false;
            textBoxPeso.Enabled = false;
            buttonEmpezar.Enabled = false;
            buttonDetener.Enabled = true;
            trackBarPropulsor.Enabled = true;
            labelTiempoOculto.Text = "0 segundos";
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
            aTimer = new Timer();
            aTimer.Interval = 30;
            aTimer.Tick += timer_Tick;
            aTimer.Start();
            timer1.Enabled = true;
        }
        private int tiempo=0;
        private int conteo = 0;
        private int incrementoAltura = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            tiempo += 30;
            try
            {
                labelVelocidadOculto.Text = Convert.ToString(g * (tiempo / 1000)); 
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                
                detener();
            } catch(Exception)
            {
                Console.WriteLine("error");
            }
            
            incrementoAltura++;
            
            //Usemos la formula a ver que dice
            if ((0.5 * g * Math.Pow(((Math.Sqrt(2 * g * incrementoAltura)) / g), 2)) > altura)
            {
                reiniciarValores();
                
            }
          
        }

        private void buttonDetener_MouseClick(object sender, MouseEventArgs e)
        {
            reiniciarValores();
            //es algo válido y bueno. a ver, en donde esta el evento del voyon empezar. over-
        }

        private void reiniciarValores()
        {
            aTimer.Stop();
            timer1.Stop();
            if ((peso * g > 500) && altura > 50)
                MessageBox.Show("El objeto se destruyó");
            else
                MessageBox.Show("El objeto se salvó");
            peso = 0;
            altura = 0;
            conteo = 0;
            incrementoAltura = 0;
            labelVelocidadOculto.Text = "";
            labelTiempoOculto.Text = "";
            textBoxAltura.Text = "";
            textBoxPeso.Text = "";
            textBoxAltura.Enabled = true;
            textBoxPeso.Enabled = true;
            buttonEmpezar.Enabled = true;
            buttonDetener.Enabled = false;
            trackBarPropulsor.Enabled = false;
            trackBarPropulsor.Value = 0;
            trackBarPropulsor.Enabled = false;//Ya agarra bien falta corregir eso xD. ver.
            trackBarPropulsor.Value = 0;
            labelPotencia.Text = "0";
            pictureBox1.Location = new Point(160, 29);
            timer1.Enabled = false;
            Console.WriteLine("hhajhasjhajshjahsjsahjhj");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //No encuentro el metodo de la formula XD
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            labelTiempoOculto.Text = Convert.ToString(conteo) + " segundos";
            Console.WriteLine("u.u");
        }

        private void detener()
        {
            if(pictureBox1.Location.Y >= 302)
            {
                reiniciarValores();
            }
        }
    }
}
