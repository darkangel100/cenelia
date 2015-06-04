using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;


namespace facturacion.vista
{
    partial class Frm_nuevoUsuario : Form
    {
        private AccesoRol ar = new AccesoRol();
        private AccesoUsuario au = new AccesoUsuario();
        private AccesoCuenta ac = new AccesoCuenta();
        public Frm_nuevoUsuario()
        {
            InitializeComponent();
            this.cbx_rol.DataSource = ar.listar();
        }

        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                // Obtener todos los atributos Title en este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // Si hay al menos un atributo Title
                if (attributes.Length > 0)
                {
                    // Seleccione el primero
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // Si no es una cadena vacía, devuélvalo
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // Si no había ningún atributo Title, o si el atributo Title era una cadena vacía, devuelva el nombre del archivo .exe
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // Obtener todos los atributos de descripción de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // Si no hay ningún atributo de descripción, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de descripción, devuelva su valor
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // Obtenga todos los atributos del producto de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // Si no hay atributos del producto, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de producto, devuelva su valor
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // Obtenga todos los atributos de copyright de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // Si no hay atributos de copyright, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de copyright, devuelva su valor
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // Obtenga todos los atributos de compañía en este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // Si no hay ningún atributo de compañía, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de compañía, devuelva su valor
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utiles.requerido(txt_cedula, errorProvider1) && Utiles.requerido(txt_apellido, errorProvider1) && Utiles.requerido(txt_nombre, errorProvider1) && Utiles.requerido(txt_telefono, errorProvider1))
            {
                this.au.getPersona().Apellido=txt_apellido.Text;
                this.au.getPersona().Cedula = txt_cedula.Text;
                this.au.getPersona().Celular = txt_celular.Text;
                this.au.getPersona().Telefono = txt_telefono.Text;
                this.au.getPersona().Nombre = txt_nombre.Text;
                this.au.getPersona().Direccion.Barrio = txt_direccion.Text;
                this.au.getPersona().Rol = (facturacion.modelo.Rol)cbx_rol.SelectedItem;
                this.au.getPersona().Id_persona = this.au.generarId();

                this.ac.getCuenta().Id_cuenta = this.ac.generarId();
                this.ac.getCuenta().Usuario = txt_cedula.Text;
                this.ac.getCuenta().Clave = txt_cedula.Text;
                this.ac.getCuenta().Persona = this.au.getPersona();

                this.au.getPersona().Cuenta = this.ac.getCuenta();

                if (this.au.guardar(this.au.getPersona()) == true)
                {
                    this.ac.guardar(this.ac.getCuenta());
                    MessageBox.Show("Se a registrado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se a registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloNumeros(sender,e,txt_cedula,10);
        }
    }
}
