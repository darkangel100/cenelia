using System;
using System.Collections.Generic;
using System.Text;
using facturacion.modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace facturacion.controlador
{
    class Utiles
    {
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
         *Para validar doubles 
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


        public static void btnverificar(string txtcedula)
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
        public static void validacedula(TextBox tex1, KeyPressEventArgs e, TextBox tex2)
        {
            char letra = e.KeyChar;

            if ((letra < 48 || letra > 57) & letra != 13 & letra != 8)
            {
                e.Handled = true;
            }
            if (letra == 13)
            {
                btnverificar(tex1.Text);
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
        /**
         * Obtiene la ruta del directorio en donde se guardan los archivos
         * */
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
                StreamWriter escribir = new StreamWriter(Utiles.ObtenerRuta()+"/facturacion/"+nombre+".html");
                escribir.Write(datos);
                escribir.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
