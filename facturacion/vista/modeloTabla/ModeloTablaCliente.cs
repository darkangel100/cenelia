using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using facturacion.modelo;
using System.Data;

namespace facturacion.vista.modeloTabla
{
    class ModeloTablaCliente
    {
        private DataGridView tabla;
        private List<object> lista = new List<object>();

        internal List<object> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public DataGridView Tabla
        {
            get { return tabla; }
            set { tabla = value; }
        }
        
        public int filas()
        {
            return (this.lista.Count>0)?this.lista.Count:1;
        }
        public void llenarTabla()
        {
            //this.tabla = new DataGridView();            
            this.tabla.Columns.Clear();
            this.tabla.DataSource = null;
            this.tabla.AutoGenerateColumns = false;           
            this.tabla.RowCount = this.filas();
            //MessageBox.Show(this.filas()+"");
            this.textoColumnas();
            tabla.DataSource = lista;
            
        }
        private void textoColumnas()
        {
            this.tabla.Columns.RemoveAt(0);            
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.DataPropertyName = "cedula";
            c1.HeaderText = "Cédula";
            c1.Width = 100;            
            this.tabla.Columns.Add(c1);
            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.DataPropertyName = "Apellido";
            c2.HeaderText = "Apellido";
            c2.Width = 100;
            this.tabla.Columns.Add(c2);
            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.DataPropertyName = "Nombre";
            c3.HeaderText = "Nombre";
            c3.Width = 100;
            this.tabla.Columns.Add(c3); 
            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.DataPropertyName = "Telefono";
            c4.HeaderText = "Teléfono";
            c4.Width = 100;
            this.tabla.Columns.Add(c4);
            
            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.DataPropertyName = "Celular";
            c5.HeaderText = "Celular";
            c5.Width = 100;
            this.tabla.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.DataPropertyName = "Estado";
            c6.HeaderText = "Estado";
            c6.Width = 100;
            this.tabla.Columns.Add(c6);
            
            
        }
    }
}
