using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int Operacion;

        public Calculadora()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        public void limpiar_pantalla(){ //Para limpiar el textbox llamado "Pantalla"

            Pantalla.Text = "";
        
        }

        public double obtener_valor() { //Para transformar lo que se digite en el textbox a formato
                                        //numerico
            
            double valor = Convert.ToDouble(Pantalla.Text);
            limpiar_pantalla();
            return valor;
        
        }

        public void actualizar_pantalla(String texto) { //Para actualizar lo que se visualiza en el textbox

            Pantalla.Text = Pantalla.Text + texto;
        
        }

        private void button24_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Is1) {
                Num1 = obtener_valor();
                Is1 = true;             //Actualizamos el valor de la variable de control
                Operacion = 0;          // "0" indicara la operacion matematica "Suma"
            }
            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;             //Actualizamos el valor de la variable de control
                Operacion = 1;          // "0" indicara la operacion matematica "Suma"
            }
            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;             //Actualizamos el valor de la variable de control
                Operacion = 3;          // "0" indicara la operacion matematica "Suma"
            }
            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;             //Actualizamos el valor de la variable de control
                Operacion = 4;          // "0" indicara la operacion matematica "Suma"
            }
            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {

                if (Operacion == 0)
                { //Si se ha presionado el boton de la "suma"

                    Num2 = obtener_valor(); //Para obtener el segundo operando de la operacion suma
                    actualizar_pantalla(operar(Num1, Num2, "+").ToString());
                    Is1 = false;

                }else if (Operacion == 1)
                { //Si se ha presionado el boton de la "suma"

                    Num2 = obtener_valor(); //Para obtener el segundo operando de la operacion suma
                    actualizar_pantalla(operar(Num1, Num2, "-").ToString());
                    Is1 = false;

                }
                else if (Operacion == 3)
                { //Si se ha presionado el boton de la "suma"

                    Num2 = obtener_valor(); //Para obtener el segundo operando de la operacion suma
                    actualizar_pantalla(operar(Num1, Num2, "*").ToString());
                    Is1 = false;

                }
                else if (Operacion == 4)
                { //Si se ha presionado el boton de la "suma"

                    if (Pantalla.Text.Equals("0"))
                    {

                        MessageBox.Show("Math ERROR :v");
                        limpiar_pantalla();
                        Num1 = 0; //Numero 1 regresa a 0

                    }
                    else {

                        Num2 = obtener_valor(); //Para obtener el segundo operando de la operacion suma
                        actualizar_pantalla(operar(Num1, Num2, "/").ToString());
                        Is1 = false;                    
                    
                    }

                }
                else if (Operacion == 5)
                { //Si se ha presionado el boton de la "cos"

                    actualizar_pantalla(operar(Num1, 0, "cos").ToString());

                }
                else if (Operacion == 6)
                { //Si se ha presionado el boton de la "suma"

                  //actualizar_pantalla(operar(Num1, 0, "sen").ToString());

                }
                else if (Operacion == 7)
                { //Si se ha presionado el boton de la "suma"

                    Num2 = obtener_valor(); //Para obtener el segundo operando de la operacion suma
                    actualizar_pantalla(operar(Num1, Num2, "exp").ToString());
                    Is1 = false;

                }
                else
                {

                    MessageBox.Show("Seleccione una operacion para realizar");

                }

            }
            catch {

                MessageBox.Show("Esta operacion requiere dos operandos");
            
            }

            Pantalla.Focus(); //Regresamos el focus al control pantalla
        }

        public double operar(double operador1, double operador2, String signo) {

            double Resultado = 0.0;

            switch (signo) { 
                
                case "+":
                    Resultado = operador1 + operador2;
                    break;
                
                case "-":
                    Resultado = operador1 - operador2;
                    break;

                case "*":
                    Resultado = operador1 * operador2;
                    break;

                case "/":
                    Resultado = operador1 / operador2;
                    break;

                case "cos":
                    
                    Resultado = Math.Cos(operador1);
                    break;
                
                case "sen":
                    Resultado = Math.Sin(operador1);
                    break;
                
                case "log":
                    Resultado = Math.Log10(operador1);
                    break;
                
                case "ln":
                    Resultado = Math.Log(operador1);
                    break;
                
                case "tan":
                    Resultado = Math.Tan(operador1);
                    break;

                case "exp":
                    Resultado = Math.Pow(operador1,operador2);
                    break;

            }

            return Resultado;
        
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Num1 = obtener_valor(); //Obtenemos el valor anterior ingresado

            actualizar_pantalla(operar(Num1, 0, "sen").ToString()); 
            
            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Num1 = obtener_valor(); //Obtenemos el valor anterior ingresado

            actualizar_pantalla(operar(Num1, 0, "cos").ToString());

            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Num1 = obtener_valor(); //Obtenemos el valor anterior ingresado

            actualizar_pantalla(operar(Num1, 0, "log").ToString());

            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Num1 = obtener_valor(); //Obtenemos el valor anterior ingresado

            actualizar_pantalla(operar(Num1, 0, "ln").ToString());

            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Num1 = obtener_valor(); //Obtenemos el valor anterior ingresado

            actualizar_pantalla(operar(Num1, 0, "tan").ToString());

            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;             //Actualizamos el valor de la variable de control
                Operacion = 7;          // "10" exponente de un numero
            }
            Pantalla.Focus(); //Regresamos el focus a la pantalla
        }

        private void button23_Click(object sender, EventArgs e)
        {
            actualizar_pantalla(",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }
    }
}
