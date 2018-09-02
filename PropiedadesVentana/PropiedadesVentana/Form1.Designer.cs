namespace PropiedadesVentana
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
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelVelocidadOculto = new System.Windows.Forms.Label();
            this.labelTiempoOculto = new System.Windows.Forms.Label();
            this.trackBarPropulsor = new System.Windows.Forms.TrackBar();
            this.labelTrackBar = new System.Windows.Forms.Label();
            this.buttonEmpezar = new System.Windows.Forms.Button();
            this.labelDestruido = new System.Windows.Forms.Label();
            this.labelPotencia = new System.Windows.Forms.Label();
            this.buttonDetener = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPropulsor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(419, 29);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(55, 20);
            this.labelAltura.TabIndex = 0;
            this.labelAltura.Text = "Altura:";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(419, 76);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPeso.Size = new System.Drawing.Size(53, 20);
            this.labelPeso.TabIndex = 1;
            this.labelPeso.Text = "Peso: ";
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocidad.Location = new System.Drawing.Point(419, 117);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(79, 20);
            this.labelVelocidad.TabIndex = 2;
            this.labelVelocidad.Text = "Velocidad";
            this.labelVelocidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(419, 167);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(61, 20);
            this.labelTiempo.TabIndex = 3;
            this.labelTiempo.Text = "Tiempo";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(509, 29);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 4;
            this.textBoxAltura.TextChanged += new System.EventHandler(this.textBoxAltura_TextChanged);
            this.textBoxAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAltura_KeyPress);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(509, 76);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeso.TabIndex = 5;
            this.textBoxPeso.TextChanged += new System.EventHandler(this.textBoxPeso_TextChanged);
            this.textBoxPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPeso_KeyPress);
            // 
            // labelVelocidadOculto
            // 
            this.labelVelocidadOculto.AutoSize = true;
            this.labelVelocidadOculto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocidadOculto.Location = new System.Drawing.Point(509, 117);
            this.labelVelocidadOculto.Name = "labelVelocidadOculto";
            this.labelVelocidadOculto.Size = new System.Drawing.Size(0, 20);
            this.labelVelocidadOculto.TabIndex = 6;
            this.labelVelocidadOculto.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTiempoOculto
            // 
            this.labelTiempoOculto.AutoSize = true;
            this.labelTiempoOculto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempoOculto.Location = new System.Drawing.Point(509, 167);
            this.labelTiempoOculto.Name = "labelTiempoOculto";
            this.labelTiempoOculto.Size = new System.Drawing.Size(0, 20);
            this.labelTiempoOculto.TabIndex = 7;
            // 
            // trackBarPropulsor
            // 
            this.trackBarPropulsor.LargeChange = 10;
            this.trackBarPropulsor.Location = new System.Drawing.Point(423, 324);
            this.trackBarPropulsor.Maximum = 100;
            this.trackBarPropulsor.Name = "trackBarPropulsor";
            this.trackBarPropulsor.Size = new System.Drawing.Size(186, 45);
            this.trackBarPropulsor.TabIndex = 11;
            this.trackBarPropulsor.TickFrequency = 2;
            this.trackBarPropulsor.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelTrackBar
            // 
            this.labelTrackBar.AutoSize = true;
            this.labelTrackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackBar.Location = new System.Drawing.Point(419, 301);
            this.labelTrackBar.Name = "labelTrackBar";
            this.labelTrackBar.Size = new System.Drawing.Size(166, 20);
            this.labelTrackBar.TabIndex = 9;
            this.labelTrackBar.Text = "Potencia del propulsor";
            this.labelTrackBar.Click += new System.EventHandler(this.labelTrackBar_Click);
            // 
            // buttonEmpezar
            // 
            this.buttonEmpezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpezar.Location = new System.Drawing.Point(423, 226);
            this.buttonEmpezar.Name = "buttonEmpezar";
            this.buttonEmpezar.Size = new System.Drawing.Size(86, 29);
            this.buttonEmpezar.TabIndex = 10;
            this.buttonEmpezar.Text = "Empezar";
            this.buttonEmpezar.UseVisualStyleBackColor = true;
            this.buttonEmpezar.Click += new System.EventHandler(this.buttonEmpezar_Click);
            this.buttonEmpezar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonEmpezar_MouseClick);
            // 
            // labelDestruido
            // 
            this.labelDestruido.AutoSize = true;
            this.labelDestruido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestruido.ForeColor = System.Drawing.Color.Red;
            this.labelDestruido.Location = new System.Drawing.Point(423, 373);
            this.labelDestruido.Name = "labelDestruido";
            this.labelDestruido.Size = new System.Drawing.Size(0, 20);
            this.labelDestruido.TabIndex = 11;
            // 
            // labelPotencia
            // 
            this.labelPotencia.AutoSize = true;
            this.labelPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotencia.Location = new System.Drawing.Point(585, 301);
            this.labelPotencia.Name = "labelPotencia";
            this.labelPotencia.Size = new System.Drawing.Size(18, 20);
            this.labelPotencia.TabIndex = 12;
            this.labelPotencia.Text = "0";
            // 
            // buttonDetener
            // 
            this.buttonDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetener.Location = new System.Drawing.Point(515, 226);
            this.buttonDetener.Name = "buttonDetener";
            this.buttonDetener.Size = new System.Drawing.Size(88, 29);
            this.buttonDetener.TabIndex = 13;
            this.buttonDetener.Text = "Detener";
            this.buttonDetener.UseVisualStyleBackColor = true;
            this.buttonDetener.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDetener_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PropiedadesVentana.Properties.Resources.pisa;
            this.pictureBox1.Location = new System.Drawing.Point(160, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDetener);
            this.Controls.Add(this.labelPotencia);
            this.Controls.Add(this.labelDestruido);
            this.Controls.Add(this.buttonEmpezar);
            this.Controls.Add(this.labelTrackBar);
            this.Controls.Add(this.trackBarPropulsor);
            this.Controls.Add(this.labelTiempoOculto);
            this.Controls.Add(this.labelVelocidadOculto);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.labelVelocidad);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelAltura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caida libre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPropulsor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label labelVelocidadOculto;
        private System.Windows.Forms.Label labelTiempoOculto;
        private System.Windows.Forms.TrackBar trackBarPropulsor;
        private System.Windows.Forms.Label labelTrackBar;
        private System.Windows.Forms.Button buttonEmpezar;
        private System.Windows.Forms.Label labelDestruido;
        private System.Windows.Forms.Label labelPotencia;
        private System.Windows.Forms.Button buttonDetener;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

