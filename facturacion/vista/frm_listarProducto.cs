using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.vista.modeloTabla;
using facturacion.controlador;

namespace facturacion.vista
{
    partial class frm_listarProducto : Form
    {
        private ModeloTablaProducto modelo = new ModeloTablaProducto();
        private AccesoProducto ap = new AccesoProducto();
        public frm_listarProducto()
        {
            InitializeComponent();
            this.cargarProducto();
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
        public void cargarProducto()
        {
            this.modelo.Tabla = this.tbl_tabla;
            this.modelo.Lista = this.ap.listar();
            this.modelo.llenarTabla();
            this.tbl_tabla.Update();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cbx_criterio.Text.Equals("Todos"))
            {
                this.cargarProducto();
            }
            else
            {
                //this.modelo.Tabla = this.tbl_tabla;
                this.modelo.Lista = this.ap.buscar(cbx_criterio.Text,txt_texto.Text);
                this.modelo.llenarTabla();
                this.tbl_tabla.Update();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            AccesoProducto ac1 = this.rescatarObjeto();

            if (ac1 != null)
            {
                new Frm_Producto(ac1, this).ShowDialog();
            }
        }
        private AccesoProducto rescatarObjeto()
        {
            int aux = this.modelo.Lista.Count;
            AccesoProducto ac1 = null;
            if (aux > 0)
            {
                ac1 = new AccesoProducto();
                ac1.setProducto((facturacion.modelo.Producto)this.tbl_tabla.CurrentRow.DataBoundItem);
            }
            return ac1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
