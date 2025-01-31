namespace ProyectoAliMate
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblTituloCalculadora;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.ListBox listHistorial;
        private System.Windows.Forms.Button btnLimpiarHistorial;
        private System.Windows.Forms.Button btnExportarHistorial;
        private System.Windows.Forms.Button btnAbrirCarpeta;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblTituloCalculadora = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.listHistorial = new System.Windows.Forms.ListBox();
            this.btnAbrirCarpeta = new System.Windows.Forms.Button();
            
            this.SuspendLayout();

            // Título Calculadora
            this.lblTituloCalculadora.Text = "Calculadora";
            this.lblTituloCalculadora.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            this.lblTituloCalculadora.Location = new System.Drawing.Point(50, 20);
            this.lblTituloCalculadora.Size = new System.Drawing.Size(200, 30);

            // Input 1
            this.txtInput1.Location = new System.Drawing.Point(50, 60);
            this.txtInput1.Size = new System.Drawing.Size(100, 20);

            // Input 2
            this.txtInput2.Location = new System.Drawing.Point(180, 60);
            this.txtInput2.Size = new System.Drawing.Size(100, 20);

            // Botón Sumar
            this.btnSumar.Text = "Sumar";
            this.btnSumar.Location = new System.Drawing.Point(50, 100);
            this.btnSumar.Size = new System.Drawing.Size(100, 30);
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);

            // Botón Restar
            this.btnRestar.Text = "Restar";
            this.btnRestar.Location = new System.Drawing.Point(180, 100);
            this.btnRestar.Size = new System.Drawing.Size(100, 30);
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);

            // Botón Multiplicar
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.Location = new System.Drawing.Point(50, 140);
            this.btnMultiplicar.Size = new System.Drawing.Size(100, 30);
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);

            // Botón Dividir
            this.btnDividir.Text = "Dividir";
            this.btnDividir.Location = new System.Drawing.Point(180, 140);
            this.btnDividir.Size = new System.Drawing.Size(100, 30);
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);

            // Campo Resultado
            this.txtResultado.Location = new System.Drawing.Point(50, 200);
            this.txtResultado.Size = new System.Drawing.Size(230, 50);
            this.txtResultado.Enabled = true;
            this.txtResultado.ReadOnly = true;
            this.txtResultado.BackColor = System.Drawing.Color.LightGray;
            this.txtResultado.Font = new System.Drawing.Font("Arial", 10);

            // Etiqueta Resultado
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Location = new System.Drawing.Point(50, 180);

            // Etiqueta para Historial
            this.lblHistorial.Text = "Historial:";
            this.lblHistorial.Location = new System.Drawing.Point(350, 20);

            // ListBox para el historial
            this.listHistorial.Location = new System.Drawing.Point(350, 50);
            this.listHistorial.Size = new System.Drawing.Size(300, 300);
            this.listHistorial.BackColor = System.Drawing.Color.White;
            this.listHistorial.Font = new System.Drawing.Font("Arial", 10);
            
            // Botón para exportar el historial
            this.btnExportarHistorial = new System.Windows.Forms.Button();
            this.btnExportarHistorial.Text = "Exportar Historial";
            this.btnExportarHistorial.Location = new System.Drawing.Point(280, 360);
            this.btnExportarHistorial.Size = new System.Drawing.Size(120, 30);
            this.btnExportarHistorial.Click += new System.EventHandler(this.btnExportarHistorial_Click);
            
            // Botón para limpiar el historial
            this.btnLimpiarHistorial = new System.Windows.Forms.Button();
            this.btnLimpiarHistorial.Text = "Limpiar Historial";
            this.btnLimpiarHistorial.Location = new System.Drawing.Point(415, 360);
            this.btnLimpiarHistorial.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiarHistorial.Click += new System.EventHandler(this.btnLimpiarHistorial_Click);
            
            
            // Botón para abrir carpeta
            this.btnAbrirCarpeta = new System.Windows.Forms.Button();
            this.btnAbrirCarpeta.Text = "Abrir Carpeta";
            this.btnAbrirCarpeta.Location = new System.Drawing.Point(550, 360);
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(120, 30);
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);


            // Formulario
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.lblTituloCalculadora);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.listHistorial);
            this.Controls.Add(this.btnLimpiarHistorial);
            this.Controls.Add(this.btnExportarHistorial);
            this.Controls.Add(this.btnAbrirCarpeta);
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}