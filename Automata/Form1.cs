using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Automata
{
    public partial class Form1 : Form
    {
        int[,] edos = new int[20,20];
        int[,] fin = new int[20, 20];
        List<Token> list = new List<Token>();
        //int[,]mas = new int[200, 200];
        public Form1()
        {
            InitializeComponent();
            //Tabla de estados
            #region Tabla de estados
            edos[0, 1] = 1; edos[1, 1] = 1; edos[2, 1] = 1; edos[3, 1] = 1; edos[4, 1] = 11; edos[5, 1] = 1; edos[6, 1] = 1; edos[7, 1] = 1; edos[8, 1] = 1; edos[9, 1] = 1; edos[10, 1] = 1; edos[11, 1] = 11;
            edos[0, 2] = 2; edos[1, 2] = 2; edos[2, 2] = 2; edos[3, 2] = 2; edos[4, 2] = 2; edos[5, 2] = 2; edos[6, 2] = 2; edos[7, 2] = 2; edos[8, 2] = 2; edos[9, 2] = 2; edos[10, 2] = 2; edos[11, 2] = 2;
            edos[0, 3] = 3; edos[1, 3] = 3; edos[2, 3] = 3; edos[3, 3] = 3; edos[4, 3] = 3; edos[5, 3] = 3; edos[6, 3] = 3; edos[7, 3] = 3; edos[8, 3] = 3; edos[9, 3] = 3; edos[10, 3] = 3; edos[11, 3] = 3;
            edos[0, 4] = 4; edos[1, 4] = 11; edos[2, 4] = 4; edos[3, 4] = 4; edos[4, 4] = 4; edos[5, 4] = 4; edos[6, 4] = 4; edos[7, 4] = 4; edos[8, 4] = 4; edos[9, 4] = 4; edos[10, 4] = 4; edos[11, 4] = 4;
            edos[0, 5] = 5; edos[1, 5] = 5; edos[2, 5] = 5; edos[3, 5] = 5; edos[4, 5] = 5; edos[5, 5] = 5; edos[6, 5] = 5; edos[7, 5] = 5; edos[8, 5] = 5; edos[9, 5] = 5; edos[10, 5] = 5; edos[11, 5] = 5;
            edos[0, 6] = 6; edos[1, 6] = 6; edos[2, 6] = 6; edos[3, 6] = 6; edos[4, 6] = 6; edos[5, 6] = 6; edos[6, 6] = 6; edos[7, 6] = 6; edos[8, 6] = 6; edos[9, 6] = 6; edos[10, 6] = 6; edos[11, 6] = 6;
            edos[0, 7] = 7; edos[1, 7] = 7; edos[2, 7] = 7; edos[3, 7] = 7; edos[4, 7] = 7; edos[5, 7] = 7; edos[6, 7] = 7; edos[7, 7] = 7; edos[8, 7] = 7; edos[9, 7] = 7; edos[10, 7] = 7; edos[11, 7] = 7;
            edos[0, 8] = 8; edos[1, 8] = 8; edos[2, 8] = 8; edos[3, 8] = 8; edos[4, 8] = 8; edos[5, 8] = 8; edos[6, 8] = 8; edos[7, 8] = 8; edos[8, 8] = 8; edos[9, 8] = 8; edos[10, 8] = 8; edos[11, 8] = 8;
            edos[0, 9] = 9; edos[1, 9] = 9; edos[2, 9] = 9; edos[3, 9] = 9; edos[4, 9] = 9; edos[5, 9] = 9; edos[6, 9] = 9; edos[7, 9] = 9; edos[8, 9] = 9; edos[9, 9] = 9; edos[10, 9] = 9; edos[11, 9] = 9;
            edos[0, 10] = 10; edos[1, 10] = 10; edos[2, 10] = 10; edos[3, 10] = 10; edos[4, 10] = 10; edos[5, 10] = 10; edos[6, 10] = 10; edos[7, 10] = 10; edos[8, 10] = 10; edos[9, 10] = 10; edos[10, 10] = 10; edos[11, 10] = 10;
            #endregion

            //tabla fin
            #region Tabala fin

            fin[0, 1] = 0; fin[1, 1] = 0; fin[2, 1] = 8; fin[3, 1] = 9; fin[4, 1] = 0; fin[5, 1] = 3; fin[6, 1] = 4; fin[7, 1] = 5; fin[8, 1] = 6; fin[9, 1] = 7; fin[10, 1] = 10; fin[11, 1] = 0;
            fin[0, 2] = 0; fin[1, 2] = 1; fin[2, 2] = 8; fin[3, 2] = 9; fin[4, 2] = 10; fin[5, 2] = 3; fin[6, 2] = 4; fin[7, 2] = 5; fin[8, 2] = 6; fin[9, 2] = 7; fin[10, 2] = 10; fin[11, 2] = 2;
            fin[0, 3] = 0; fin[1, 3] = 1; fin[2, 3] = 8; fin[3, 3] = 9; fin[4, 3] = 10; fin[5, 3] = 3; fin[6, 3] = 4; fin[7, 3] = 5; fin[8, 3] = 6; fin[9, 3] = 7; fin[10, 3] = 10; fin[11, 3] = 2;
            fin[0, 4] = 0; fin[1, 4] = 0; fin[2, 4] = 8; fin[3, 4] = 9; fin[4, 4] = 10; fin[5, 4] = 3; fin[6, 4] = 4; fin[7, 4] = 5; fin[8, 4] = 6; fin[9, 4] = 7; fin[10, 4] = 10; fin[11, 4] = 2;
            fin[0, 5] = 0; fin[1, 5] = 1; fin[2, 5] = 8; fin[3, 5] = 9; fin[4, 5] = 10; fin[5, 5] = 3; fin[6, 5] = 4; fin[7, 5] = 5; fin[8, 5] = 6; fin[9, 5] = 7; fin[10, 5] = 10; fin[11, 5] = 2;
            fin[0, 6] = 0; fin[1, 6] = 1; fin[2, 6] = 8; fin[3, 6] = 9; fin[4, 6] = 10; fin[5, 6] = 3; fin[6, 6] = 4; fin[7, 6] = 5; fin[8, 6] = 6; fin[9, 6] = 7; fin[10, 6] = 10; fin[11, 6] = 2;
            fin[0, 7] = 0; fin[1, 7] = 1; fin[2, 7] = 8; fin[3, 7] = 9; fin[4, 7] = 10; fin[5, 7] = 3; fin[6, 7] = 4; fin[7, 7] = 5; fin[8, 7] = 6; fin[9, 7] = 7; fin[10, 7] = 10; fin[11, 7] = 2;
            fin[0, 8] = 0; fin[1, 8] = 1; fin[2, 8] = 8; fin[3, 8] = 9; fin[4, 8] = 10; fin[5, 8] = 3; fin[6, 8] = 4; fin[7, 8] = 5; fin[8, 8] = 6; fin[9, 8] = 7; fin[10, 8] = 10; fin[11, 8] = 2;
            fin[0, 9] = 0; fin[1, 9] = 1; fin[2, 9] = 8; fin[3, 9] = 9; fin[4, 9] = 10; fin[5, 9] = 3; fin[6, 9] = 4; fin[7, 9] = 5; fin[8, 9] = 6; fin[9, 9] = 7; fin[10, 9] = 10; fin[11, 9] = 2;
            fin[0, 10] = 0; fin[1, 10] = 1; fin[2, 10] = 8; fin[3, 10] = 9; fin[4, 10] = 10; fin[5, 10] = 3; fin[6, 10] = 4; fin[7, 10] = 5; fin[8, 10] = 6; fin[9, 10] = 7; fin[10, 10] = 10; fin[11, 10] = 2;
           
            #endregion

            //Tabla mas comentada
            #region Tabla mas Comentada
            //for (int i = 0; i < 200; i++)
            //{
            //    for (int j = 0; j < 200; j++)
            //    {
            //        mas[i, j] = 99;
            //    }
            //}
            ////imprime('letras');
            //mas[0, 17] = 20; mas[20, 5] = 21;mas[21, 15] = 22;mas[21, 3] = 23; mas[21, 4] = 24;mas[21, 1] = 25; mas[21, 2] = 26; mas[22, 2] = 27; 
            //mas[22, 1] = 28; mas[27, 15] = 29;mas[28, 15] = 29;mas[29, 6] = 30;mas[23, 6] = 30;mas[24, 6] = 30;mas[25, 6] = 30; mas[26, 6] = 30;
            //mas[30, 7] = 100;
            ////(NE ND +-*/ NE ND);
            //mas[0, 5] = 31; mas[31, 3] = 32; mas[31, 4] = 33; mas[32, 10] = 34; mas[32, 11] = 35; mas[32, 12] = 36; mas[32, 13] = 37;
            //mas[33, 10] = 34; mas[33, 11] = 35; mas[33, 12] = 36; mas[33, 13] = 37;
            //mas[34, 3] = 38; mas[34, 4] = 39; mas[35, 3] = 38; mas[35, 4] = 39; mas[36, 3] = 38; mas[36, 4] = 39; mas[37, 3] = 38; mas[37, 4] = 39;
            //mas[38, 6] = 40; mas[39, 6] = 40; mas[40, 7] = 100;

            ////LM/NE
            //mas[0, 1] = 41; mas[41, 13] = 42; mas[42, 3] = 100;

            ////Lm(Nd +-*/ Ne);
            //mas[0,2] = 50; mas[50,5] = 51; mas[51,4] = 52; mas[52,10] = 53; mas[52, 11] = 54;
            //mas[52,12] = 55; mas[52, 13] = 56;
            //mas[53, 3] = 57; mas[54, 3] = 57; mas[55, 3] = 57; mas[56, 3] = 57;
            //mas[57, 6] = 58; mas[58, 7] = 100;

            ////Ne +- (Nd)..Palabra Mayuscula
            //mas[0, 3] = 60; mas[60, 10] = 61; mas[60, 11] = 62; mas[61, 5] = 63; mas[62, 5] = 63; mas[63, 4] = 64;
            //mas[64, 6] = 65; mas[65, 8] = 66; mas[66, 8] = 67;  mas[67, 1] = 100;

            ////mas[0, 3] = 60; mas[60, 10] = 61; mas[60, 11] = 61; mas[61, 5] = 63; mas[62, 5] = 63; mas[63, 4] = 64; mas[64, 4] = 64;
            ////mas[64, 5] = 65; mas[65, 8] = 100;
        }
        //public string AnalisisSintactico(List<Token> lt)
        //{
        //    int edo = 0;
        //    foreach (Token token in lt)
        //    {
        //        edo = mas[edo, token.Clave()];
        //    }
        //    if (edo == 100)
        //        return "Valido";
        //    else
        //        return "InValido";
        //}
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        //Metodo Simbolos
        #region Metodo Simbolos
        public int Simbolo(char c)
        {
            if (c >= 48 && c <= 57)
                return 1;          
            if (c == '(')
                return 2;
            if (c == ')')
                return 3;
            if (c == '.')
                return 4; 
            if (c == '+')
                return 5;
            if (c == '-')
                return 6;
            if (c == '*')
                return 7;
            if (c == '/')
                return 8;
            if (c == '^')
                return 9;
            else 
                return 10;
        }
        #endregion

        //Numeros Token metodo
        #region Numeros de Token
        public string Nomtoken(int t)
        {
            if (t == 1)
                return "Numero Entero";
            if (t == 2)
                return "Numero decimal";
            if (t == 3)
                return "Suma";
            if (t == 4)
                return "Resta";
            if (t == 5)
                return "Multiplicacion";
            if (t == 6)
                return "Divicion";
            if (t == 7)
                return "Potencia";
            if (t == 8)
                return "P. Abre";
            if (t == 9)
                return "P. Cierra";
            else
                return "Error";
        }
        #endregion

        //Metodo parentesis
        #region Metodo Parentesis Pila
        private bool Parentesis(string cadena)
        {
            Stack<int> pila = new Stack<int>();
            bool bandera = false;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i]=='(')
                {
                    pila.Push(1);
                }
                if (cadena[i] == ')' && pila.Count == 0)
                {
                    bandera = true; 
                }
                if (cadena[i] == ')' && pila.Count > 0)
                {
                    pila.Pop();
                }
            }
            if (pila.Count !=0 || bandera == true)
                return false;   
            else
                return true;
        }
        #endregion

        //resolver

        #region Prioridad de Expresion
        public int PrioridadExpresion(string pexpresion)
        {
            try
            {
                switch (pexpresion)
                {
                    case "(":
                        return 5;
                    case "^":
                        return 4;
                    case "*":
                        return 2;
                    case "/":
                        return 2;
                    case "+":
                        return 1;
                    case "-":
                        return 1;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido una excepción: " + ex.Message);
            }
            return 0;
        }
        #endregion

        #region Prioridad de Pila
        public int PrioridadPila(string ppila)
        {
            try
            {
                switch (ppila)
                {
                    case "(":
                        return 0;
                    case "^":
                        return 3;
                    case "*":
                        return 2;
                    case "/":
                        return 2;
                    case "+":
                        return 1;
                    case "-":
                        return 1;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido una excepción: " + ex.Message);
            }
            return 0;
        }
        #endregion



        #region Calculadora Polaca
        public string CalculadoraPolaca(List<Token> listatoken)
        {
            try
            {
                Stack<string> pilaoperadores = new Stack<string>();
                Stack<string> pilaposfija = new Stack<string>();
                foreach (Token token in listatoken)
                {
                    int clave = Convert.ToInt32(token.Clave().ToString());
                    int prioOP, prioP;
                    switch (clave)
                    {
                        case 1:
                        case 2:
                            pilaposfija.Push(token.Contenido());
                            break;
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        etiqueta:
                            if ((pilaoperadores.Count > 0))
                            {
                                prioOP = PrioridadExpresion(token.Contenido());
                                prioP = PrioridadPila(pilaoperadores.Peek());
                                if (prioOP <= prioP)
                                {
                                    pilaposfija.Push(pilaoperadores.Pop());
                                    goto etiqueta;
                                }
                            }
                            pilaoperadores.Push(token.Contenido());
                            break;
                        case 8:
                            pilaoperadores.Push(token.Contenido());
                            break;
                        case 9:
                            while ((pilaoperadores.Count > 0 && pilaoperadores.Peek() != "("))
                            {
                                pilaposfija.Push(pilaoperadores.Pop());
                            }
                            if (pilaoperadores.Peek() == "(")
                                pilaoperadores.Pop();
                            break;
                        default:
                            break;
                    }
                }
                while (pilaoperadores.Count > 0)
                    pilaposfija.Push(pilaoperadores.Pop());
                string posfijaordenada = string.Join(" ", pilaposfija.Reverse());
                txtResultado.Text = Convert.ToString(HacerOperacion(pilaposfija));
                return posfijaordenada;
            }
            catch (Exception ex)
            {
                return "Se ha producido una excepción: " + ex.ToString();
            }
        }
        #endregion


        #region Relaizar Operaciones Arismeticas
        public double HacerOperacion(Stack<string> posfija)
        {

            try
            {
                Stack<string> posfijaordenada = new Stack<string>();
                Stack<double> pilanumeros = new Stack<double>();
                while (posfija.Count > 0)
                {
                    posfijaordenada.Push(posfija.Pop());
                }
                foreach (string token in posfijaordenada)
                {
                    if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                    {
                        pilanumeros.Push(num);
                    }
                    else
                    {
                        double numero2 = pilanumeros.Pop();
                        double numero1 = pilanumeros.Pop();

                        switch (token)
                        {
                            case "+":
                                pilanumeros.Push(numero1 + numero2);
                                break;
                            case "-":
                                pilanumeros.Push(numero1 - numero2);
                                break;
                            case "*":
                                pilanumeros.Push(numero1 * numero2);
                                break;
                            case "/":
                                if (numero2 != 0)
                                {
                                    pilanumeros.Push(numero1 / numero2);
                                }
                                else
                                {
                                    MessageBox.Show("No se puede dividir entre cero");
                                }
                                break;
                            case "^":
                                pilanumeros.Push(Math.Pow(numero1, numero2));
                                break;
                        }
                    }
                }
                if (pilanumeros.Count > 0)
                {
                    return pilanumeros.Pop();
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {

                return Convert.ToInt32("Error: "+ex.ToString());
            }

        }
        #endregion


        //fin de metodos


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEntrada.Text))
                {
                    MessageBox.Show("El textbox está vacío");
                }

                int edo = 0, sim, ter;
                label1.Text = "";
                txtNombreToken.Text = "";
                list.Clear();
                string cadena = txtEntrada.Text + '\r';
                textBox1.Text = txtEntrada.Text;
                if (!Parentesis(cadena))
                {
                    MessageBox.Show("Los prentesis no estan equilibrados");
                    return;
                }
                string contenido = "";
                for (int i = 0; i < cadena.Length; i++)
                {
                    sim = Simbolo(cadena[i]);
                    label1.Text = label1.Text + sim + "/";
                    ter = fin[edo, sim];
                    edo = edos[edo, sim];
                    if (ter != 0)
                    {
                        if (contenido == "imprime")
                            ter = 17;
                        txtNombreToken.Text = txtNombreToken.Text + Nomtoken(ter) + " " + contenido + "/";
                        Token t1 = new Token(ter, contenido);
                        list.Add(t1);
                        contenido = "";
                    }
                    contenido = contenido + cadena[i];
                }
                //MessageBox.Show(AnalisisSintactico(list));
                string resultado = CalculadoraPolaca(list);
                txtOrdenPolaca.Text = resultado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido una excepción: " + ex);
            }

           

        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = "";
            textBox1.Text = "";
            label1.Text = ""; 
            txtNombreToken.Text = "";
            txtOrdenPolaca.Text = "";
            txtResultado.Text = "";
        }
    }
}
