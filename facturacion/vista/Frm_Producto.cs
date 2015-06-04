﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using facturacion.controlador;

namespace facturacion.vista
{
    partial class Frm_Producto : Form
    {
        private AccesoMarca am = new AccesoMarca();
        private AccesoProducto ap = new AccesoProducto();
        private int accion = 0;
        private frm_listarProducto flp = null;
        public Frm_Producto()
        {
            InitializeComponent();
            this.cargarCombo();
        }
        public Frm_Producto(AccesoProducto ap, frm_listarProducto flp)
        {
            InitializeComponent();
            this.cargarCombo();
            this.ap = ap;
            this.flp = flp;
            this.accion = 1;
            this.cargarVista();
        }
        private void cargarVista()
        {
            this.txt_codigo.Text = ap.getProducto().Codigo;
            //this.txt_detalle.Text = ap.getProducto().Detalle;
            this.txt_nombre.Text = ap.getProducto().Nombre;
            this.txt_pc.Text = ap.getProducto().P_compra.ToString();
            this.txt_pvp.Text = ap.getProducto().Pvp.ToString();
            //this.txt_stock.Value = ap.getProducto().Stock;
            this.cbx_marca.SelectedItem = ap.getProducto().Marca;
            double porcentaje = ((ap.getProducto().Pvp-ap.getProducto().P_compra)/ap.getProducto().P_compra)*100;
            //this.cbx_porcentaje.SelectedItem = porcentaje.ToString();
        }
        public void cargarCombo()
        {
            cbx_marca.DataSource = am.listar();
        }
        private void cargarProducto()
        {
            this.ap.getProducto().Codigo = this.txt_codigo.Text;
            //this.ap.getProducto().Detalle = this.txt_detalle.Text;
            this.ap.getProducto().Marca = (facturacion.modelo.Marca)cbx_marca.SelectedItem;
            this.ap.getProducto().Nombre = this.txt_nombre.Text;
            this.ap.getProducto().P_compra = Convert.ToDouble(this.txt_pc.Text);
            this.ap.getProducto().Pvp = Convert.ToDouble(this.txt_pvp.Text);
            //this.ap.getProducto().Stock = Convert.ToInt32( txt_stock.Value.ToString());
            if(this.accion==0)
            {
                this.ap.getProducto().Id_producto = this.ap.generarId();
            }
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Utiles.requerido(this.txt_codigo, this.errorProvider1) == true && Utiles.requerido(this.txt_nombre, this.errorProvider1) == true && Utiles.requerido(this.txt_pc, this.errorProvider1) == true && Utiles.requerido(this.txt_pvp, this.errorProvider1) == true && Utiles.requerido(this.txt_detalle, this.errorProvider1) == true)
            {
                this.cargarProducto();
                if (this.accion == 0)
                {
                    if (this.ap.guardar(this.ap.getProducto()) == true)
                    {
                        MessageBox.Show("Se ha registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se ha registrado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (this.ap.modificar(this.ap.getProducto()) == true)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.flp.cargarProducto();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No se ha editar correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_pc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloDoubles(sender,e, this.txt_pc);
            
        }

        private void txt_pvp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utiles.soloDoubles(sender, e, this.txt_pvp);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbx_porcentaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.calcularpvp();
        }
        private void calcularpvp()
        {
            double precio = 0;
            try
            {                
                if (Utiles.requerido(txt_pc, errorProvider1) == true)
                {
                    int porcentaje = Convert.ToInt16(cbx_porcentaje.Text);
                    precio = Convert.ToDouble(txt_pc.Text) + (porcentaje * Convert.ToDouble(txt_pc.Text) / 100);
                    txt_pvp.Text = precio.ToString();
                }
            }catch(Exception ex){
                txt_pvp.Text = precio.ToString();
            }
        }

        private void txt_pc_KeyUp(object sender, KeyEventArgs e)
        {
            this.calcularpvp();
        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
    }
}
