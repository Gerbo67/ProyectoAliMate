namespace ProyectoAliMate
{
    partial class Form1
    {
        // Se declaran las variables
        
        // <visibilidad> <tipo> <nombre> = <asignacion>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnConcatenate;
        private System.Windows.Forms.Label lblResult;

        // Funcion para liberar memoria y recursos de la PC
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Funcion para inicializar componentes
        
        /*
         * Un componete es un elemento registrado en pantalla que tiene un espacio
         * en vista y tiene accion o meramente visual.
         */
        private void InitializeComponent()
        {
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnConcatenate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // TextBox1
            this.txtInput1.Location = new System.Drawing.Point(50, 50);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 20);

            // TextBox2
            this.txtInput2.Location = new System.Drawing.Point(170, 50);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 20);

            // Button
            this.btnConcatenate.Location = new System.Drawing.Point(290, 50);
            this.btnConcatenate.Name = "btnConcatenate";
            this.btnConcatenate.Size = new System.Drawing.Size(100, 23);
            this.btnConcatenate.Text = "Concatenar";
            this.btnConcatenate.Click += new System.EventHandler(this.btnConcatenate_Click);

            // Label
            this.lblResult.Location = new System.Drawing.Point(410, 50);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 20);
            this.lblResult.Text = "";

            // Form1 (Propiedades del formulario)
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btnConcatenate);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}