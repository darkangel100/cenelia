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
    partial class Frm_listarCliente : Form
    {
        private ModeloTablaCliente modelo = new ModeloTablaCliente();
        private AccesoCliente ac = new AccesoCliente();
        public Frm_listarCliente()
        {
            InitializeComponent();
            this.cargarTabla();
        }
        public void cargarTabla()
        {
            this.modelo.Tabla = this.tbl_tabla;
            this.modelo.Lista = this.ac.listar();
            this.modelo.llenarTabla();
            this.tbl_tabla.Update();
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
        private AccesoCliente rescatarObjeto()
        {
            int aux = this.modelo.Lista.Count;
            AccesoCliente ac1 = null;
            if(aux > 0)
            {
                ac1 = new AccesoCliente();
                ac1.setCliente((facturacion.modelo.Persona)this.tbl_tabla.CurrentRow.DataBoundItem);
            }
            return ac1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AccesoCliente ac1 = this.rescatarObjeto();            
            
            if(ac1!=null)
            {
                new Frm_cliente(ac1, this).ShowDialog();
            }
        }

        private void btn_biuscar_Click(object sender, EventArgs e)
        {
            if (this.cbx_criterio.Text.Equals("Todos"))
            {
                this.cargarTabla();
            }
            else
            {
                this.modelo.Lista = this.ac.buscar(cbx_criterio.Text, this.txt_texto.Text);
                this.modelo.llenarTabla();
                this.lbl_resultado.Text = "Se han encontrado " + this.modelo.Lista.Count + " resultados";
                this.tbl_tabla.Update();
            }            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void cambiarBoton(AccesoCliente auxC)
        {
            if (auxC.getCliente().Estado.Equals("activo"))
            {
                btn_activar.Text = "Desactivar";
            }
            else
            {
                btn_activar.Text = "Activar";
            }
        }

        

        private void tbl_tabla_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            AccesoCliente ac1 = this.rescatarObjeto();
            if (ac1 != null)
            {
                this.cambiarBoton(ac1);
            }
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            AccesoCliente ac1 = this.rescatarObjeto();
            if (ac1 != null)
            {
                if (ac1.getCliente().Estado.Equals("activo"))
                {
                    ac1.getCliente().Estado = "inactivo";
                }
                else
                {
                    ac1.getCliente().Estado = "activo";
                }
                DialogResult r = MessageBox.Show("Desea activar/desactivar el cliente "+ac1.getCliente().Nombre+" "+ac1.getCliente().Apellido,"Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                string aux = r.ToString();
                if(aux.Equals("Yes"))
                {
                    ac1.modificar(ac1.getCliente());
                    MessageBox.Show("Se a actualizado correctamente");
                    this.cargarTabla();
                }
            }
        }

        private void Frm_listarCliente_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
    }
}
