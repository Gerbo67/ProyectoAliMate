using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAliMate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los textboxes
            string input1 = txtInput1.Text;
            string input2 = txtInput2.Text;

            // Concatenar textos
            string resultado = input1 + " " + input2;

            // Mostrar el resultado en el label
            lblResult.Text = "Resultado: " + resultado;
        }


        private void variables()
        {
            // Tipos de variables
            
            // Tipo numerico int
            byte a = 1;
            short b = 1;
            int c = 1;
            long d = 1;
            
            // Tipos decimales
            float e = 1.5f;
            double f = 1.5;
            decimal g = 1.5m;

            // Texto
            char h = 'a';
            char[] i = {'h', 'o', 'l', 'a'};
            string j = "hola";
            
            // Boolean
            bool k = true;
            bool l = false;
            bool m = a == 1;
        }

        private void simbols()
        {
            // == igualadad
            // = asignacion
            // ++ sumar 1 incremental
            // -- restar 1 decremental
            // *= multiplicar el numero deseado al resultado
            // x *= 5; por cada pase va a multiplicar por 2
            // /= dividir el numero deseado al resultado
            // x /= 2; por cada pase va a dividir entre 2
            
            // % mod  x = 2, x % 2 = 0
            
            // Raiz cuadrada
            // Math.Sqrt(10);
            
            // Potencias
            // Math.Pow(2, 3);  2^3
        }

        private void conditions()
        {
            int x = 1;
            int y = 2;
            int z = 3;
            
            // Advertencia: Cuando se condicionan elmentos
            // son comparativas y por tanto deben ser vistos
            // con los mismos tipos de datos
            
            // == Comparar igualdad entre 2 terminos
            if (x == 1);
            
            // != Comparar desigualdad entre 2 terminos
            if (x != 1);
            // x = 2 es true
            
            // > Comparar mayor que
            if (x > 1);
            // x = 2 es true
            
            // < Comparar menor que
            if (x < 1);
            // x = 0 es true
            
            // >= Comparar mayor o igual que
            if (x >= 1);
            // x = 1 es true
            
            // <= Comparar menor o igual que
            if (x <= 1);
        }

        private void logics()
        {
            int existe = 1;
            int cheetos = 1;
            int coca = 0;
            // "Y" significa que haga las dos condiciones
            // AND, &&
            
            //      TRUE                 FALSE
            if (cheetos == existe && coca == existe); // false
            
            //      TRUE                 TRUE
            if (cheetos == existe && coca == 0); // true
            
            
            // Practica de and con muchos brackets {}
            if (existe == 1)
            {
                if (existe == 1)
                {
                    if (existe == 1)
                    {
                        if (existe == 1)
                        {
                            if (existe == 1)
                            {
                                if (cheetos == existe);
                            }
                        }
                    }
                }
            }
            
            // Recomendado
            if (existe == 1 && coca == existe);

            // "O" significa que haga una de las dos condiciones
            // OR, ||
            // minimo uno sea true sera true
            
            //      FALSE                 TRUE
            if (coca == existe ||  cheetos == existe); // true
            
            //      TRUE                 TRUE
            if (cheetos == existe || coca == 0); // true
            
            //      FALSE                 FALSE
            if (cheetos == 2 || coca == existe); // false
        }
    }
}
