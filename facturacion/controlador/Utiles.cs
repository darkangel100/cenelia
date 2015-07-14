using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace facturacion.controlador
{
    class Utiles
    {
        public static string girafecha(String f)
        {
            String fec = "";
            fec = f.Substring(6, 4) + "-" + f.Substring(3, 2) + "-" + f.Substring(0, 2);
            return fec;
        }
        public static bool requerido(Component texto,ErrorProvider error)
        {
            TextBox txt = (TextBox)texto;
            bool band = true;
            error.Clear();
            if (txt.Text.Trim().Length <= 0)
            {
                error.SetError(txt, "Se requiere un valor");
                band = false;
            }
            
            return band;
        }
        /**
         *Para validar doubles de los textos
        */
        public static void soloDoubles(Object sender, KeyPressEventArgs e, TextBox txt)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            
            else if (e.KeyChar == '.')
            {
                if (verificarPunto(txt.Text) == false)
                {
                    e.KeyChar = ',';
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        
        public static bool verificarPunto(string txt)
        {

            if (txt.Contains(","))
                return true;
            else
                return false;

        }
        public static int generarid(int nro)
        {
            int id = nro;
            id++;
            return id;
        }

        public static void verificar(string txtcedula)
        {
            int numero = 0;
            int digito = 0;
            int suma = 0;
            string cadena = txtcedula;
            //   vectorcedula.Add(txtcedula.Text.ToString());
            char[] vectorcedula = cadena.ToArray();
            if (vectorcedula.Length > 10 || vectorcedula.Length < 10)
            {
                MessageBox.Show("El numero de cedula es incorrecto");
            }
            else
            {
                for (int i = 0; i < vectorcedula.Length - 1; i++)
                {
                    numero = int.Parse(vectorcedula[i + 1].ToString());

                    digito = int.Parse(vectorcedula[i].ToString());
                    if ((i + 1) % 2 == 1)
                    {
                        digito = digito * 2;
                        if (digito > 9)
                            digito = digito - 9;

                    }

                    suma += digito;

                }
                suma = 10 - (suma % 10);
                if (suma >= 10) suma = 0;
                if (numero == suma)
                {
                    MessageBox.Show("El numero es correcto");
                }
                else { MessageBox.Show("El numero ingresado es irroneo"); }
            }
        }  /**
        // *Para validar numeros 
        //*/
        public static void validacedula(TextBox tex1, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 13 & letra != 8)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                verificar(tex1.Text);
                //tex2.Focus();
            }
        }
        public static void soloNumeros(Object sender, KeyPressEventArgs e, TextBox txt, int max)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (max > 0)
            {
                if (txt.Text.Length == max)
                {
                    if (e.KeyChar == '\b')
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

            }
            
        }
        public static bool min(Component texto,int min, ErrorProvider error)
        {
            TextBox txt = (TextBox)texto;
            bool band = true;
            error.Clear();
            if (txt.Text.Trim().Length < min)
            {
                error.SetError(txt, "Se requiere un valor mayor a " + min);                
                band = false;
            }
            return band;            
        }
        /**
         *Para validar letras 
        */
        public static void soloLetras(Object sender, KeyPressEventArgs e, TextBox txt, int max)
        {            
            if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                
            }
            else if (e.KeyChar == '\b' )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (max > 0)
            {
                if (txt.Text.Length == max)
                {
                    if (e.KeyChar == '\b')
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

            }
            

        }
        public static void limpiar(Control.ControlCollection cont)
        {
            foreach (Control c in cont)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }
      
        public bool cedula(string ced)
        {
            bool ci = false;
            if (ced.Length == 10)
            {

                string car = "";
                int num = 0;
                int suma = 0;
                for (int cont = 0; cont < 9; cont++)
                {
                    car = Convert.ToString(ced[cont]);
                    num = Convert.ToInt32(car);
                    if (cont % 2 == 0)
                    {
                        num = num * 2;
                        if (num > 9)
                        {
                            num = num - 9;
                        }
                    }
                    suma = suma + num;
                }
                int ds = suma;
                bool de = false;
                while (de == false)
                {
                    if (ds % 10 == 0)
                    {
                        de = true;
                    }
                    else
                    {
                        ds = ds + 1;
                    }
                }
                ds = ds - suma;
                car = Convert.ToString(ced[9]);
                num = Convert.ToInt32(car);
                if (num == ds)
                {
                    ci = true;
                    return ci;
                }
                else
                {
                    ci = false;
                    return ci;
                }

            }
            return ci;

        }
        public static string ObtenerRuta()
        {
            string directory = "";
            directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return directory;
        }
        public static void guardarReporte(string datos, string nombre)
        {
            try
            {
                StreamWriter escribir = new StreamWriter(Utiles.ObtenerRuta() + "/cnch/" + nombre + ".html");
                escribir.Write(datos);
                escribir.Close();
            }
            catch (Exception ex)
            {
            }
        }

    }
}
