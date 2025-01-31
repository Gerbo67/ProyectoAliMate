using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoAliMate
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // ===================== MÉTODOS DE INICIALIZACIÓN Y UTILIDAD =====================

        // Método para inicializar estados predeterminados
        private void InicializarEstado()
        {
            txtResultado.ForeColor = System.Drawing.Color.Black;
            txtResultado.Text = "";
        }

        // Método para obtener los operandos (a y b) de los campos de texto
        private (double a, double b) ObtenerOperandos()
        {
            try // Intenta ejecutar el codigo dentro de brackets {}
            {
                double a = double.Parse(txtInput1.Text);
                double b = double.Parse(txtInput2.Text);
                return (a, b);
            }
            catch
            {
                throw new Exception(
                    "Error al convertir los datos. Verifique que ambos campos contengan números válidos.");
            }
        }

        // ========================= MÉTODO CONTROLADOR PRINCIPAL =========================

        // Método principal para realizar operaciones
        private void RealizarOperacion(string operacion)
        {
            try
            {
                InicializarEstado(); // Restaurar estados predeterminados
                var (a, b) = ObtenerOperandos(); // Obtener los operandos

                switch (operacion)
                {
                    case "Sumar":
                        Sumar(a, b);
                        break;

                    case "Restar":
                        Restar(a, b);
                        break;

                    case "Multiplicar":
                        Multiplicar(a, b);
                        break;

                    case "Dividir":
                        Dividir(a, b);
                        break;

                    default:
                        MessageBox.Show("Operación no válida. Por favor, selecciona una operación válida.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ====================== MÉTODOS PARA OPERACIONES MATEMÁTICAS ======================

        private void Sumar(double a, double b)
        {
            double resultado = a + b;
            txtResultado.Text = resultado.ToString();
            listHistorial.Items.Add($"Suma: {a} + {b} = {resultado}");
        }

        private void Restar(double a, double b)
        {
            double resultado = a - b;
            txtResultado.Text = resultado.ToString();
            listHistorial.Items.Add($"Resta: {a} - {b} = {resultado}");
        }

        private void Multiplicar(double a, double b)
        {
            double resultado = a * b;
            txtResultado.Text = resultado.ToString();
            listHistorial.Items.Add($"Multiplicación: {a} * {b} = {resultado}");
        }

        private void Dividir(double a, double b)
        {
            if (b == 0)
            {
                txtResultado.ForeColor = System.Drawing.Color.Red;
                txtResultado.Text = "No se puede dividir entre 0";
                return;
            }

            double resultado = a / b;
            txtResultado.Text = resultado.ToString();
            listHistorial.Items.Add($"División: {a} / {b} = {resultado}");
        }

        // ============================= EVENTOS DE LA INTERFAZ =============================

        private void btnSumar_Click(object sender, EventArgs e)
            => RealizarOperacion("Sumar");

        private void btnRestar_Click(object sender, EventArgs e)
            => RealizarOperacion("Restar");

        private void btnMultiplicar_Click(object sender, EventArgs e)
            => RealizarOperacion("Multiplicar");

        private void btnDividir_Click(object sender, EventArgs e)
            => RealizarOperacion("Dividir");

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            listHistorial.Items.Clear();
        }

        // ========================== MÉTODOS ADICIONALES ==========================

        private void btnExportarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta de destino
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "history");
                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                string archivo = Path.Combine(carpeta, "historial.txt");

                // Escribir los elementos del historial en el archivo
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    foreach (var item in listHistorial.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Historial exportado correctamente en la carpeta 'history'.",
                    "Exportación Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el historial: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        
        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta donde se guarda el historial
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "history");

                // Verificar si la carpeta existe
                if (Directory.Exists(carpeta))
                {
                    // Abrir el explorador en la carpeta
                    System.Diagnostics.Process.Start("explorer.exe", carpeta);
                }
                else
                {
                    MessageBox.Show("La carpeta de historial no existe. Primero exporta el historial.", 
                        "Carpeta no encontrada", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar abrir la carpeta: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}