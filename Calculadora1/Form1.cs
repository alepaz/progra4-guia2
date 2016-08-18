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
            txtTexto.Text = "";
        
        }

        public double obtener_valor() { //Para transformar lo que se digite en el textbox a formato
                                        //numerico
            double valor = 0;
                
            if (Pantalla.Text.Length > 0)
                {
                    if (double.TryParse(Pantalla.Text, out valor))
                    {
                        valor = Convert.ToDouble(Pantalla.Text);
                        limpiar_pantalla();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un numero");
                    }
                    
                }
                else {
                    MessageBox.Show("El control se encuentra vacio"); 
                }
   
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

            txtTexto.Text = Numalet.ToCardinal(Resultado);

            //signo = toText(Resultado);

            //txtTexto.Text = signo.ToString();

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

        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }
    }
}
